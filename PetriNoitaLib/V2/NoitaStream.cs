using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace PetriNoitaLib.V2
{
    public class NoitaStream : MemoryStream
    {
        public byte[] ReadBytes(int length)
        {
            byte[] bytes = new byte[length];
            ReadAtLeast(bytes, bytes.Length);
            return bytes;
        }

        public bool ReadBool()
        {
            int value = this.ReadByte();
            if (value > 2) throw new Exception("bool value was > 1");
            return value == 1;
        }

        public void WriteBytes(byte[] input)
        {
            Write(input);
        }

        public void WriteBool(bool input)
        {
            WriteByte(input ? (byte)1 : (byte)0);
        }

        public string ReadBeString() => Encoding.ASCII.GetString(ReadBytes((int)ReadBeUInt32())); // Todo: Correct encoding?
        public void WriteBeString(string s) {
            byte[] encoded = Encoding.ASCII.GetBytes(s); // Todo: Correct encoding?
            WriteBeInt32(encoded.Length);
            WriteBytes(encoded);
        }

        public UInt16 ReadBeUInt16() => BinaryPrimitives.ReadUInt16BigEndian(ReadBytes(2));
        public Int16 ReadBeInt16() => BinaryPrimitives.ReadInt16BigEndian(ReadBytes(2));
        public UInt32 ReadBeUInt32() => BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(4));
        public Int32 ReadBeInt32() => BinaryPrimitives.ReadInt32BigEndian(ReadBytes(4));
        public UInt64 ReadBeUInt64() => BinaryPrimitives.ReadUInt64BigEndian(ReadBytes(8));
        public Int64 ReadBeInt64() => BinaryPrimitives.ReadInt64BigEndian(ReadBytes(8));
        public float ReadBeFloat() => BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(4));
        public double ReadBeDouble() => BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(8));

        public void WriteBeUInt16(UInt16 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeInt16(Int16 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeUInt32(UInt32 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeInt32(Int32 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeUInt64(UInt64 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeInt64(Int64 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeFloat(float i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public void WriteBeDouble(double i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());

    }
}
