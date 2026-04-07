using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace PetriNoitaLib
{
    internal class LZFile
    {
        public static MemoryStream ReadFile(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);

            int len_compressed = BinaryPrimitives.ReadInt32LittleEndian(bytes.AsSpan(0, 4));
            int len_decompressed = BinaryPrimitives.ReadInt32LittleEndian(bytes.AsSpan(4, 4));
            byte[] decompressed = new byte[len_decompressed];

            if (bytes.Length - 8 != len_compressed)
            {
                throw new Exception("Something with the compression is screwed up");
            }

            MemoryStream stream = new MemoryStream();

            DotFastLZ.Compression.FastLZ.Decompress(bytes.AsSpan(8, len_compressed).ToArray(), len_compressed, decompressed, decompressed.Length);


            stream.Write(decompressed);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}
