from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class FishAIComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    direction:NoitaInt = field(default_factory=NoitaInt)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    aabb_min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    aabb_max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.direction.Read(s)
        self.speed.Read(s)
        self.aabb_min.Read(s)
        self.aabb_max.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.direction.Write(s)
        self.speed.Write(s)
        self.aabb_min.Write(s)
        self.aabb_max.Write(s)

