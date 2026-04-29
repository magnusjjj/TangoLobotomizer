from NoitaStream import NoitaStream
from dataclasses import dataclass, field

class NoitaComponentBase:
    pass

@dataclass
class NoitaBool:
    Value = False
    def Read(self, s:NoitaStream):
        self.Value = s.ReadBool()
    def Write(self, s:NoitaStream):
        s.WriteBool(self.Value)

@dataclass
class NoitaFloat:
    Value = 0
    def Read(self, s:NoitaStream):
       self.Value = s.ReadBeFloat()
    def Write(self, s:NoitaStream):
        s.WriteBeFloat(self.Value)

@dataclass
class NoitaDouble:
    Value = 0
    def Read(self, s:NoitaStream):
        self.Value = s.ReadBeDouble()
    def Write(self, s:NoitaStream):
        s.WriteBeDouble(self.Value)

@dataclass
class NoitaInt64:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeInt64()
    def Write(self, s:NoitaStream): s.WriteBeInt64(self.Value)

@dataclass
class NoitaUInt64:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeUInt64()
    def Write(self, s:NoitaStream): s.WriteBeUInt64(self.Value)

@dataclass
class NoitaInt:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeInt32()
    def Write(self, s:NoitaStream): s.WriteBeInt32(self.Value)

@dataclass
class NoitaUInt:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeUInt32()
    def Write(self, s:NoitaStream): s.WriteBeUInt32(self.Value)

@dataclass
class NoitaShort:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeInt16()
    def Write(self, s:NoitaStream): s.WriteBeInt16(self.Value)

@dataclass
class NoitaUShort:
    Value = 0
    def Read(self, s:NoitaStream): self.Value = s.ReadBeUInt16()
    def Write(self, s:NoitaStream): s.WriteBeUInt16(self.Value)

@dataclass
class NoitaString:
    Value = ""
    def Read(self, s:NoitaStream): self.Value = s.ReadBeString()
    def Write(self, s:NoitaStream): s.WriteBeString(self.Value)

@dataclass
class NoitaLensValue:
    __innerclass = None
    Value = None
    Default = None
    Frame = None

    def __init__(self, innerclass):
        self.__innerclass = innerclass
        self.Value = innerclass()
        self.Default = innerclass()
        self.Frame = innerclass()

    def Read(self, s:NoitaStream):
        self.Value.Read(s)
        self.Default.Read(s)
        self.Frame.Read(s)

    def Write(self, s:NoitaStream):
        self.Value.Write(s)
        self.Default.Write(s)
        self.Frame.Write(s)

@dataclass
class NoitaCVector2:
    __innerclass = None
    X = None
    Y = None

    def __init__(self, innerclass):
        self.__innerclass = innerclass
        self.X = innerclass()
        self.Y = innerclass()

    def Read(self, s:NoitaStream):
        self.X.Read(s)
        self.Y.Read(s)

    def Write(self, s:NoitaStream):
        self.X.Write(s)
        self.Y.Write(s)

@dataclass
class NoitaVector:
    __innerclass = None
    Data:list = field(default_factory=list)

    def __init__(self, innerclass):
        self.__innerclass = innerclass
        self.Data = []

    def Read(self, s:NoitaStream):
        length = s.ReadBeUInt32();

        for i in range(0, length):
            part = self.__innerclass();
            part.Read(s);
            self.Data.append(part);

    def Write(self, s:NoitaStream):
        s.WriteBeUInt32(len(self.Data));

        for t in self.Data:
            t.Write(s);

@dataclass
class NoitaCXForm:
    Position = None
    Scale = None
    Rotation = None

    def __init__(self, innerclass):
        self.__innerclass = innerclass
        self.Position = NoitaCVector2(innerclass)
        self.Scale = NoitaCVector2(innerclass)
        self.Rotation = innerclass()

    def Read(self, s:NoitaStream):
        self.Position.Read(s)
        self.Scale.Read(s)
        self.Rotation.Read(s)

    def Write(self, s:NoitaStream):
        self.Position.Write(s)
        self.Scale.Write(s)
        self.Rotation.Write(s)

@dataclass
class NoitaSpecialTexture:
    Size = NoitaCVector2(NoitaInt)
    Data = []

    def __init__(self):
        self.Size = NoitaCVector2(NoitaInt)

    def Read(self, s:NoitaStream):
        is_special = s.ReadBool()
        if is_special:
            self.Size.Read(s)
            self.Data = []
            for i in range(0, self.Size.X.Value*self.Size.Y.Value):
                a = NoitaUInt()
                a.Read(s)
                self.Data.append(a)
        else:
            self.Size = NoitaCVector2(NoitaInt)
            self.Data = []

    def Write(self, s:NoitaStream):
        if len(self.Data) > 0:
            s.WriteBool(True)
            self.Size.Write(s)
            for noitaU in self.Data:
                noitaU.Write(s)
        else:
            s.WriteBool(False)

@dataclass
class NoitaUintArrayInline:
    Data = NoitaVector(NoitaInt)

    def __init__(self):
        self.Data = NoitaVector(NoitaInt)

    def Read(self, s:NoitaStream):
        self.Data.Read(s)

    def Write(self, s:NoitaStream):
        self.Data.Write(s)

@dataclass
class MissingClassConfigPendingPortal:
    def Read(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")
    def Write(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")

@dataclass
class MissingClassConfigNpcParty:
    def Read(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")
    def Write(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")

@dataclass
class MissingClassConfigCutThroughWorld:
    def Read(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")
    def Write(self, s:NoitaStream):
        raise Exception("This class isn't implemented!")