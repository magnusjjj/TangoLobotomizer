using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

// Class for just reading big endian stuff

namespace PetriNoitaLib
{
    class BEHelper
    {
        static public UInt32 ReadBeUInt32(Stream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadUInt32BigEndian(buffer);
        }

        static public Int32 ReadBeInt32(Stream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadInt32BigEndian(buffer);
        }

        static public UInt16 ReadBeUInt16(Stream stream)
        {
            byte[] buffer = new byte[2];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadUInt16BigEndian(buffer);
        }

        static public Int16 ReadBeInt16(Stream stream)
        {
            byte[] buffer = new byte[2];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadInt16BigEndian(buffer);
        }

        static public UInt64 ReadBeUInt64(Stream stream)
        {
            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadUInt64BigEndian(buffer);
        }

        static public float ReadBeFloat(Stream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadSingleBigEndian(buffer);
        }

        static public double ReadBeDouble(Stream stream)
        {
            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadDoubleBigEndian(buffer);
        }

        static public Int64 ReadBeInt64(Stream stream)
        {
            byte[] buffer = new byte[8];
            stream.Read(buffer, 0, buffer.Length);
            return BinaryPrimitives.ReadInt64BigEndian(buffer);
        }
    }
}
