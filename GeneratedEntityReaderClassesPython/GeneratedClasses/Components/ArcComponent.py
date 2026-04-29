from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ArcComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    type:NoitaUInt = field(default_factory=NoitaUInt)
    material:NoitaInt = field(default_factory=NoitaInt)
    lifetime:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.type.Read(s)
        self.material.Read(s)
        self.lifetime.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.type.Write(s)
        self.material.Write(s)
        self.lifetime.Write(s)

