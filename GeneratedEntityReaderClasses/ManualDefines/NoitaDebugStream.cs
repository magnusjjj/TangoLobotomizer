using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace GeneratedNoitaClasses
{
    public class NoitaDebugStream : NoitaStream
    {
        NoitaStream s;
        byte[] checkagainst;

        public NoitaDebugStream(NoitaStream thebase)
        {
            s = thebase;
            checkagainst = thebase.ToArray();
        }

        void ThrowOnInvalid()
        {
            if (!checkagainst.AsSpan(0, (int)this.Position).SequenceEqual(this.ToArray()))
            {
                throw new NotImplementedException("AGH! WRONG WRITE!");
            }
        }

        public override void WriteBytes(byte[] input)
        {
            base.Write(input);
            ThrowOnInvalid();
        }

        public override void WriteBool(bool input)
        {
            base.WriteByte(input ? (byte)1 : (byte)0);
            ThrowOnInvalid();
        }

        public override void WriteBeString(string s) {
            byte[] encoded = Encoding.ASCII.GetBytes(s); // Todo: Correct encoding?
            base.WriteBeUInt32((uint)encoded.Length);
            base.WriteBytes(encoded);
            ThrowOnInvalid();
        }

        public override void WriteBeUInt16(UInt16 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeInt16(Int16 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeUInt32(UInt32 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeInt32(Int32 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeUInt64(UInt64 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeInt64(Int64 i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeFloat(float i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }

        public override void WriteBeDouble(double i)
        {
            base.Write(BitConverter.GetBytes(i).Reverse().ToArray());
            ThrowOnInvalid();
        }
    }
}
