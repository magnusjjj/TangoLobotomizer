using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.RegularExpressions;

namespace PetriNoitaLib
{
    interface iField
    {
        string Type { get; set; }
        object Value { get; set; }
        bool Match(string s);
        void Read(Stream s);
        void Write(Stream s);
    }


    // A simple field is just anything that is one singular line to convert back or forth.
    class SimpleField : iField
    {
        public string Type { get; set; }
        public object Value { get; set; }

        // Anything 
        public static Dictionary<string, (Func<Stream, MatchCollection, object> reader, Action<Stream> writer)> simple_converters = new Dictionary<string, (Func<Stream, MatchCollection, object> reader, Action<Stream> writer)> { 
            { "float", ((s, m) => BEHelper.ReadBeFloat(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "double", ((s, m) => BEHelper.ReadBeDouble(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "int", ((s, m) => BEHelper.ReadBeInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "int32", ((s, m) => BEHelper.ReadBeInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "__int64", ((s, m) => BEHelper.ReadBeInt64(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "unsigned int", ((s, m) => BEHelper.ReadBeUInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "uint32", ((s, m) => BEHelper.ReadBeUInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "unsigned __int64", ((s, m) => BEHelper.ReadBeUInt64(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))},
            { "unsigned short", ((s, m) => BEHelper.ReadBeUInt16(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello")))}
        };

        public bool Match(string type)
        {
            return simple_converters.ContainsKey(type);
        }

        public void Read(Stream s)
        {
/*            foreach (var converter in simple_converters)
            {
                MatchCollection m = converter.tomatch.Matches(Type);
                if (m.Count > 0)
                {
                    this.Value = ;
                    //                            object test = converter.reader(stream);
                }
            }*/
        }

        public void Write(Stream s)
        {
            throw new NotImplementedException();
        }
    }
}
