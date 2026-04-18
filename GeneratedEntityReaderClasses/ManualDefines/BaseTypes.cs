using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace GeneratedNoitaClasses
{
    public interface iNoitaType
    {
        void Read(NoitaStream s);
        public void Write(NoitaStream s);
    }

    public interface iNoitaType<TSelf> : iNoitaType where TSelf: iNoitaType<TSelf>, new()
    {
        public static TSelf ReadStatic(NoitaStream s) {
            TSelf self = new();
            self.Read(s);
            return self;
        }
    }

    public abstract class NoitaType<T> where T : new()
    {
        public T Value { get; set; } = new();
    }

    /*public interface NoitaTypeAutoConvert<ActualClass, InnerType> where ActualClass : NoitaType<InnerType>, new() where InnerType : class, iNoitaType, new()
    {
        public static virtual implicit operator ActualClass(InnerType n)
        {
            return (ActualClass)new ActualClass() { Value = n };
        }

        public static virtual implicit operator InnerType(ActualClass n)
        {
            return n.Value;
        }
    }*/




    public class NoitaBool : NoitaType<bool>, iNoitaType<NoitaBool>
    {
        public void Read(NoitaStream s) { Value = s.ReadBool(); }
        public void Write(NoitaStream s) => s.WriteBool(Value);
    }

    public class NoitaFloat : NoitaType<float>, iNoitaType<NoitaFloat>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeFloat(); }
        public void Write(NoitaStream s) => s.WriteBeFloat(Value);
    }

    public class NoitaDouble : NoitaType<double>, iNoitaType<NoitaDouble>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeDouble(); }
        public void Write(NoitaStream s) => s.WriteBeDouble(Value);
    }

    public class NoitaInt64 : NoitaType<Int64>, iNoitaType<NoitaInt64>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeInt64(); }
        public void Write(NoitaStream s) => s.WriteBeInt64(Value);
    }

    public class NoitaUInt64 : NoitaType<UInt64>, iNoitaType<NoitaUInt64>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeUInt64(); }
        public void Write(NoitaStream s) => s.WriteBeUInt64(Value);
    }

    public class NoitaInt : NoitaType<Int32>, iNoitaType<NoitaInt>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeInt32(); }
        public void Write(NoitaStream s) => s.WriteBeInt32(Value);
    }
    
    public class NoitaUInt : NoitaType<UInt32>, iNoitaType<NoitaUInt>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeUInt32(); }
        public void Write(NoitaStream s) => s.WriteBeUInt32(Value);
    }

    public class NoitaShort : NoitaType<Int16>, iNoitaType<NoitaShort>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeInt16(); }
        public void Write(NoitaStream s) => s.WriteBeInt16(Value);
    }

    public class NoitaUShort : NoitaType<UInt16>, iNoitaType<NoitaUShort>
    {
        public void Read(NoitaStream s) { Value = s.ReadBeUInt16(); }
        public void Write(NoitaStream s) => s.WriteBeUInt16(Value);
    }

    public class NoitaString : iNoitaType<NoitaString>
    {
        public string Value { get; set; } = String.Empty;
        public void Read(NoitaStream s) { Value = s.ReadBeString(); }
        public void Write(NoitaStream s) => s.WriteBeString(Value);

        //public static implicit operator string(NoitaString n) => n.Value;
        //public static implicit operator NoitaString(string a) => a;
    }

    // Todo: Converters for base types!


    public class NoitaLensValue<T> where T : iNoitaType<T>, new()
    {
        public T Value { get; set; } = new();
        public T Default { get; set; } = new();
        public NoitaUInt Frame { get; set; } = new();

        public void Read(NoitaStream s) {
            Value.Read(s);
            Default.Read(s);
            Frame.Read(s);
        }

        public void Write(NoitaStream s)
        {
            Value.Write(s);
            Default.Write(s);
            Frame.Write(s);
        }
    }

    public class NoitaCVector2<T> where T : iNoitaType<T>, new()
    {
        public T X { get; set; } = new();
        public T Y { get; set; } = new();

        public void Read(NoitaStream s)
        {
            X.Read(s);
            Y.Read(s);
        }

        public void Write(NoitaStream s)
        {
            X.Write(s);
            Y.Write(s);
        }
    }

    public class NoitaVector<T> where T : iNoitaType<T>, new()
    {
        public List<T> Data { get; set; } = new List<T>();

        public void Read(NoitaStream s)
        {
            UInt32 len = s.ReadBeUInt32();

            for (int x = 0; x < len; x++)
            {
                T part = new T();
                part.Read(s);
                Data.Add(part);
            }
        }

        public void Write(NoitaStream s)
        {
            s.WriteBeUInt32((UInt32)Data.Count);

            foreach(T t in Data)
            {
                t.Write(s);
            }
        }
    }

    public class NoitaUintArrayInline : iNoitaType<NoitaUintArrayInline>
    {
        public NoitaVector<NoitaInt> Data { get; set; } = new NoitaVector<NoitaInt>();
        public void Read(NoitaStream s)
        {
            Data.Read(s);
        }

        public void Write(NoitaStream s)
        {
            Data.Write(s);
        }
    }

    public class NoitaCXForm<T> where T : iNoitaType<T>, new()
    {
        public NoitaCVector2<T> Position { get; set; } = new();
        public NoitaCVector2<T> Scale { get; set; } = new();

        public T Rotation { get; set; } = new();

        public void Read(NoitaStream s)
        {
            Position.Read(s);
            Scale.Read(s);
            Rotation.Read(s);
        }

        public void Write(NoitaStream s)
        {
            Position.Write(s);
            Scale.Write(s);
            Rotation.Write(s);
        }
    }



    public class NoitaSpecialTexture : iNoitaType<NoitaSpecialTexture>
    {
        public NoitaCVector2<NoitaInt> Size { get; set; } = new();
        public List<NoitaUInt> Data { get; set; } = new();

        public void Read(NoitaStream s)
        {
            bool is_special = s.ReadBool();
            if (is_special)
            {
                Size.Read(s);
                Data = new List<NoitaUInt>();
                for(int i = 0; i < Size.X.Value*Size.Y.Value; i++)
                {
                    NoitaUInt a = new();
                    a.Read(s);
                    Data.Add(a);
                }
            } else
            {
                Size = new();
                Data = new();
            }
        }

        public void Write(NoitaStream s)
        {
            if (Data.Count > 0)
            {
                s.WriteBool(true);
                Size.Write(s);
                foreach(NoitaUInt noitaU in this.Data)
                {
                    noitaU.Write(s);
                }
            }
            else
            {
                s.WriteBool(false);
            }
        }
    }

    /*

    public class NoitaSpecialTexture : NoitaType
    {
        public override string Load() => Name + ".Load(s);";
        public override string Save() => Name + ".Write(s);";
    }*/
}
