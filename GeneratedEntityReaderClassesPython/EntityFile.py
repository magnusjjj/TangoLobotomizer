from NoitaStream import NoitaStream
from GeneratedClasses.GeneratedClassFinder import GeneratedClassFinder
from dataclasses import dataclass, field

@dataclass
class Entity:
    Name:str = ""
    Deleted:bool = False
    Path:str = ""
    Tags:str = ""
    X:float = 0
    Y:float = 0
    ScaleX:float = 0
    ScaleY:float = 0
    Rotation:float = 0
    Components:list = field(default_factory=list)
    Children:list["Entity"] = field(default_factory=list)

    def Read(self, s:NoitaStream) -> None:
        self.Name = s.ReadBeString()
        self.Deleted = s.ReadBool()
        self.Path = s.ReadBeString()
        self.Tags = s.ReadBeString()
        self.X = s.ReadBeFloat()
        self.Y = s.ReadBeFloat()
        self.ScaleX = s.ReadBeFloat()
        self.ScaleY = s.ReadBeFloat()
        self.Rotation = s.ReadBeFloat()
        num_components = s.ReadBeUInt32()
        for i in range(0, num_components):
            componenttypename:str = s.ReadBeString()
            component = GeneratedClassFinder.GetGeneratedClass(componenttypename)
            component.ComponentName = componenttypename
            component.Read(s)
            self.Components.append(component)

        num_children = s.ReadBeUInt32()
        for i in range(0, num_children):
            child:Entity = Entity()
            child.Read(s)
            self.Children.append(child)

    def Write(self, s:NoitaStream) -> None:
        s.WriteBeString(self.Name)
        s.WriteBool(self.Deleted)
        s.WriteBeString(self.Path)
        s.WriteBeString(self.Tags)
        s.WriteBeFloat(self.X)
        s.WriteBeFloat(self.Y)
        s.WriteBeFloat(self.ScaleX)
        s.WriteBeFloat(self.ScaleY)
        s.WriteBeFloat(self.Rotation)
        s.WriteBeUInt32(len(self.Components))
        for component in self.Components:
            s.WriteBeString(component.ComponentName)
            component.Write(s)

        s.WriteBeUInt32(len(self.Children))
        for child in self.Children:
            child.Write(s);

@dataclass
class EntityFile:
    EmptyFlag:bytes = b"" # A very strange thing. In little endian, a file with 0x00020020 is empty. A file with 0x00000002 has content in it.
    # uint32 hash size here
    Hash:str = "" # This is filled with a sort of checksum. That checksum is the filename (sans .xml and path) of an xml file with the file format specification in it.
    # uint32 number of entities here
    Entities:list[Entity] = field(default_factory=list)

    def Read(self, stream:NoitaStream) -> None:
        # Read some of the stream headers
        self.EmptyFlag = stream.ReadBytes(4)
#        stream.ReadAtLeast(EmptyFlag, EmptyFlag.Length)
        self.Hash = stream.ReadBeString()
        num_entities = stream.ReadBeUInt32()
        if self.Hash != "": 
            for i in range(0, num_entities):
                entity:Entity = Entity()
                entity.Read(stream)
                self.Entities.append(entity)

    def Write(self, stream:NoitaStream) -> None:
        if len(self.Entities) == 0:
            stream.Write(bytes([ 0, 2, 0, 32, 0, 0, 0, 0 ]))
            stream.Write(b'\0' * 0x24)
            return
        else:
            stream.Write(bytes([ 0, 0, 0, 2]))

        stream.WriteBeString(self.Hash)
        stream.WriteBeUInt32(len(self.Entities))
        for entity in self.Entities:
            entity.Write(stream)