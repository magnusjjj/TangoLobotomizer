from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PressurePlateComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    check_every_x_frames:NoitaInt = field(default_factory=NoitaInt)
    state:NoitaInt = field(default_factory=NoitaInt)
    aabb_min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    aabb_max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    material_percent:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.check_every_x_frames.Read(s)
        self.state.Read(s)
        self.aabb_min.Read(s)
        self.aabb_max.Read(s)
        self.material_percent.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.check_every_x_frames.Write(s)
        self.state.Write(s)
        self.aabb_min.Write(s)
        self.aabb_max.Write(s)
        self.material_percent.Write(s)

