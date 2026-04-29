
from io import BytesIO
import struct
from typing import Any


class NoitaStream:
    content:BytesIO
#    position:int

    def __init__(self, content:bytes):
        self.content = BytesIO(content)
        #self.position = 0

    def ReadBytes(self, length:int) -> bytes:
        returner = self.content.read(length)
        if len(returner) != length:
            raise Exception("Unexpected end of file")
        return returner
#        returner = self.content[self.position:self.position+length]
#        self.position += length
#        return returner

    def ReadByte(self):
        return self.ReadBytes(1)[0]

    def ReadBool(self) -> bool:
        value = self.ReadByte()
        if value > 2:
            raise Exception("bool value was > 1")
        return value == 1

    def WriteBytes(self, buffer:bytes) -> None:
        self.Write(buffer)

    def Write(self, theinput:bytes) -> None:
        #self.position += len(theinput)
        self.content.write(theinput)
#        self.content += theinput
    
    def WriteBool(self, theinput:bool) -> None:
        self.Write(b"\x01" if theinput else b"\x00")

    def ReadBeString(self) -> str:
        length:int = self.ReadBeUInt32()
        buffer:bytes = self.ReadBytes(length)
        return buffer.decode()

    def WriteBeString(self, s:str) -> None:
        encoded:bytes = s.encode() # Todo: Correct encoding?
        self.WriteBeUInt32(len(encoded))
        self.WriteBytes(encoded)

    def ReadUnpackSingle(self, format:str) -> Any:
        buffer:bytes = self.ReadBytes(struct.calcsize(format))
        return struct.unpack(format, buffer)[0]

    def WritePackSingle(self, format:str, thevalue:Any) -> None:
        self.Write(struct.pack(format, thevalue))

    def ReadBeUInt16(self) -> int:
        return self.ReadUnpackSingle(">H")

    def ReadBeInt16(self) -> int:
        return self.ReadUnpackSingle(">h")

    def ReadBeUInt32(self) -> int:
        return self.ReadUnpackSingle(">I")

    def ReadBeInt32(self) -> int: 
        return self.ReadUnpackSingle(">i")

    def ReadBeUInt64(self) -> int: 
        return self.ReadUnpackSingle(">Q")

    def ReadBeInt64(self) -> int: 
        return self.ReadUnpackSingle(">q")

    def ReadBeFloat(self) -> float: 
        return self.ReadUnpackSingle(">f")

    def ReadBeDouble(self) -> float:
        return self.ReadUnpackSingle(">d")

    def WriteBeUInt16(self, i:int) -> None:
        self.WritePackSingle(">H", i)

    def WriteBeInt16(self, i:int) -> None: 
        self.WritePackSingle(">h", i)

    def WriteBeUInt32(self, i:int) -> None: 
        self.WritePackSingle(">I", i)

    def WriteBeInt32(self, i:int) -> None: 
        self.WritePackSingle(">i", i)

    def WriteBeUInt64(self, i:int) -> None: 
        self.WritePackSingle(">Q", i)

    def WriteBeInt64(self, i:int) -> None:
        self.WritePackSingle(">q", i)

    def WriteBeFloat(self, i:float) -> None:
        self.WritePackSingle(">f", i)

    def WriteBeDouble(self, i:float) -> None:
        self.WritePackSingle(">d", i)