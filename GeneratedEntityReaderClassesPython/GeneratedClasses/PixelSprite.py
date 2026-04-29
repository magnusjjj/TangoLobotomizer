from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaSpecialTexture

from NoitaStream import NoitaStream
@dataclass
class PixelSprite:
    Number1:NoitaString = field(default_factory=NoitaString)
    Number2:NoitaFloat = field(default_factory=NoitaFloat)
    Number3:NoitaFloat = field(default_factory=NoitaFloat)
    Number4:NoitaFloat = field(default_factory=NoitaFloat)
    Number5:NoitaFloat = field(default_factory=NoitaFloat)
    Number6:NoitaInt = field(default_factory=NoitaInt)
    Number7:NoitaInt = field(default_factory=NoitaInt)
    Number8:NoitaInt = field(default_factory=NoitaInt)
    Number9:NoitaBool = field(default_factory=NoitaBool)
    Number10:NoitaInt = field(default_factory=NoitaInt)
    Number11:NoitaString = field(default_factory=NoitaString)
    Number12:NoitaSpecialTexture = field(default_factory=NoitaSpecialTexture)
    
    def Read(self, s:NoitaStream):
        self.Number1.Read(s)
        self.Number2.Read(s)
        self.Number3.Read(s)
        self.Number4.Read(s)
        self.Number5.Read(s)
        self.Number6.Read(s)
        self.Number7.Read(s)
        self.Number8.Read(s)
        self.Number9.Read(s)
        self.Number10.Read(s)
        self.Number11.Read(s)
        self.Number12.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Number1.Write(s)
        self.Number2.Write(s)
        self.Number3.Write(s)
        self.Number4.Write(s)
        self.Number5.Write(s)
        self.Number6.Write(s)
        self.Number7.Write(s)
        self.Number8.Write(s)
        self.Number9.Write(s)
        self.Number10.Write(s)
        self.Number11.Write(s)
        self.Number12.Write(s)

