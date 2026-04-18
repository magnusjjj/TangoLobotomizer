using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace GeneratedNoitaClasses
{
    public class NoitaStream : MemoryStream
    {
        public virtual byte[] ReadBytes(int length)
        {
            byte[] bytes = new byte[length];
            ReadAtLeast(bytes, bytes.Length);
            return bytes;
        }

        public virtual bool ReadBool()
        {
            int value = this.ReadByte();
            if (value > 2) throw new Exception("bool value was > 1");
            return value == 1;
        }

        public virtual void WriteBytes(byte[] input)
        {
            Write(input);
        }

        public virtual void WriteBool(bool input)
        {
            WriteByte(input ? (byte)1 : (byte)0);
        }

        public virtual string ReadBeString()
        {
            int length = (int)ReadBeUInt32();
            byte[] bytes = ReadBytes(length);
            string asciistring = Encoding.ASCII.GetString(bytes); // Todo: Correct encoding?
            return asciistring;
        }
        public virtual void WriteBeString(string s) {
            byte[] encoded = Encoding.ASCII.GetBytes(s); // Todo: Correct encoding?
            WriteBeUInt32((uint)encoded.Length);
            WriteBytes(encoded);
        }

        public virtual UInt16 ReadBeUInt16() => BinaryPrimitives.ReadUInt16BigEndian(ReadBytes(2));
        public virtual Int16 ReadBeInt16() => BinaryPrimitives.ReadInt16BigEndian(ReadBytes(2));
        public virtual UInt32 ReadBeUInt32() => BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(4));
        public virtual Int32 ReadBeInt32() => BinaryPrimitives.ReadInt32BigEndian(ReadBytes(4));
        public virtual UInt64 ReadBeUInt64() => BinaryPrimitives.ReadUInt64BigEndian(ReadBytes(8));
        public virtual Int64 ReadBeInt64() => BinaryPrimitives.ReadInt64BigEndian(ReadBytes(8));
        public virtual float ReadBeFloat() => BinaryPrimitives.ReadSingleBigEndian(ReadBytes(4));
        public virtual double ReadBeDouble() => BinaryPrimitives.ReadDoubleBigEndian(ReadBytes(8));

        public virtual void WriteBeUInt16(UInt16 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeInt16(Int16 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeUInt32(UInt32 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeInt32(Int32 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeUInt64(UInt64 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeInt64(Int64 i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeFloat(float i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());
        public virtual void WriteBeDouble(double i) => Write(BitConverter.GetBytes(i).Reverse().ToArray());

    }
}
