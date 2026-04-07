using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace PetriNoitaLib.V2
{
    internal class LZFile
    {
        public static NoitaStream ReadFile(string filename)
        {
            // We start with reading in the file
            byte[] bytes = File.ReadAllBytes(filename);

            // The first two bytes are little endian, the length of the file - 8 (length of the compressed data) and the size of the uncompressed data respectively
            int len_compressed = BinaryPrimitives.ReadInt32LittleEndian(bytes.AsSpan(0, 4));
            int len_decompressed = BinaryPrimitives.ReadInt32LittleEndian(bytes.AsSpan(4, 4));

            // Little sanity check, 
            if (bytes.Length - 8 != len_compressed)
            {
                throw new Exception("Compressed file is corrupt, file length exceeds what is expected.");
            }

            // We need a byte array to stick the decompressed data
            byte[] decompressed = new byte[len_decompressed];

            DotFastLZ.Compression.FastLZ.Decompress(bytes.AsSpan(8, len_compressed).ToArray(), len_compressed, decompressed, decompressed.Length);

            NoitaStream stream = new NoitaStream(); // We return a helper stream type. This just has a bunch of functions to read data in big endian format
            stream.Write(decompressed);
            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }

        public static void WriteFile(string filename, byte[] data)
        {
            // First, somewhere to stick the data.
            byte[] buffer = new byte[DotFastLZ.Compression.FastLZ.EstimateCompressedSize(data.Length)];

            // Checking the source, this is the length into the buffer the decompression has stopped. For our purposes, that would be the length of the compressed data.
            // So be aware if you decide optimizing the function is a good idea ;)
            long howfarintobuffer = DotFastLZ.Compression.FastLZ.CompressLevel(1, data, data.Length, buffer);

            FileStream f = File.Open(filename, FileMode.Create);
            f.Write(BitConverter.GetBytes((Int32)howfarintobuffer));
            f.Write(BitConverter.GetBytes((Int32)data.Length));
            f.Write(buffer);
        }
    }
}
