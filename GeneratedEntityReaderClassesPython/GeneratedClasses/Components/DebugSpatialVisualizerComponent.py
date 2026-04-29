from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class DebugSpatialVisualizerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    min_x:NoitaFloat = field(default_factory=NoitaFloat)
    min_y:NoitaFloat = field(default_factory=NoitaFloat)
    max_x:NoitaFloat = field(default_factory=NoitaFloat)
    max_y:NoitaFloat = field(default_factory=NoitaFloat)
    color:NoitaUInt = field(default_factory=NoitaUInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.min_x.Read(s)
        self.min_y.Read(s)
        self.max_x.Read(s)
        self.max_y.Read(s)
        self.color.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.min_x.Write(s)
        self.min_y.Write(s)
        self.max_x.Write(s)
        self.max_y.Write(s)
        self.color.Write(s)

