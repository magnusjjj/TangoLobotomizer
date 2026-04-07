using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Windows.Markup;
using System.Drawing;
using System.Drawing.Imaging;


namespace PetriNoitaLib
{
    public interface INoitaLoadable<T>
    {
        public void Load(Stream s);
    }

    public class NoitaVector<T> : INoitaLoadable<NoitaVector<T>> where T : INoitaLoadable<T>, new()
    {
        public UInt32 length;
        public List<T> values = [];

        public void Load(Stream s)
        {
            length = BEHelper.ReadBeUInt32(s);
            for (int i = 0; i < length; i++)
            {
                T part = new T();
                part.Load(s);
                values.Add(part);
            }
        }
    }

    public class NoitaString : INoitaLoadable<NoitaString>
    {
        public UInt32 length;
        public string value;
        public void Load(Stream s)
        {
            this.length = BEHelper.ReadBeUInt32(s);
            byte[] buffer = new byte[this.length];
            s.Read(buffer, 0, buffer.Length);
            this.value = System.Text.ASCIIEncoding.ASCII.GetString(buffer, 0, (int)this.length);
        }
    }

    public class PhysicsObject : INoitaLoadable<PhysicsObject>
    {
        UInt64 id;
        UInt32 unknown1;
        float x, y;
        float rot_radians;
        byte[] unknown2 = new byte[49];
        UInt32 w;
        UInt32 h;
        UInt32[] colors;

        public void Load(Stream s)
        {
            id = BEHelper.ReadBeUInt64(s);
            unknown1 = BEHelper.ReadBeUInt32(s);
            x = BEHelper.ReadBeFloat(s);
            y = BEHelper.ReadBeFloat(s);
            rot_radians = BEHelper.ReadBeFloat(s);
            s.ReadExactly(unknown2, 0, unknown2.Length);
            w = BEHelper.ReadBeUInt32(s);
            h = BEHelper.ReadBeUInt32(s);
            colors = new UInt32[w * h];
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = BEHelper.ReadBeUInt32(s);
            }
        }
    }

    public class PhysicsJoint : INoitaLoadable<PhysicsJoint>
    {
        UInt64 id1;
        UInt32 padding;
        UInt64 id2;
        byte[] padding2 = new byte[95];

        public void Load(Stream s)
        {
            id1 = BEHelper.ReadBeUInt64(s);
            padding = BEHelper.ReadBeUInt32(s);
            id2 = BEHelper.ReadBeUInt64(s);
            s.ReadExactly(padding2, 0, padding2.Length);
        }
    }

    public class NoitaUint32 : INoitaLoadable<NoitaUint32>
    {
        public UInt32 value;
        public void Load(Stream s)
        {
            value = BEHelper.ReadBeUInt32(s);
        }
    }



    public class PngPetri
    {
        public UInt32 version, w, h;

        public byte[] materials;

        public NoitaVector<NoitaString> material_names = new NoitaVector<NoitaString>();
        public NoitaVector<NoitaUint32> custom_colors = new NoitaVector<NoitaUint32>();
        public NoitaVector<PhysicsObject> box2ds = new NoitaVector<PhysicsObject>();
        public NoitaVector<PhysicsJoint> joints = new NoitaVector<PhysicsJoint>();

        public static PngPetri Load(string filename)
        {
            PngPetri p = new PngPetri();
            var stream = LZFile.ReadFile(filename);
            p.version = BEHelper.ReadBeUInt32(stream);
            p.w = BEHelper.ReadBeUInt32(stream);
            p.h = BEHelper.ReadBeUInt32(stream);

            if (p.version != 24 || p.w != 512 || p.h != 512)
            {
                throw new Exception("Something is seriously wrong with the datafile.");
            }

            p.materials = new byte[p.w * p.h];

            stream.Read(p.materials, 0, p.materials.Length);

            p.material_names.Load(stream);
            p.custom_colors.Load(stream);
            p.box2ds.Load(stream);
            p.joints.Load(stream);

            return p;
        }
    }
}
