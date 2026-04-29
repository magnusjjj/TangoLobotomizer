from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class MoveToSurfaceOnCreateComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    type:NoitaUInt = field(default_factory=NoitaUInt)
    lookup_radius:NoitaFloat = field(default_factory=NoitaFloat)
    offset_from_surface:NoitaFloat = field(default_factory=NoitaFloat)
    ray_count:NoitaInt = field(default_factory=NoitaInt)
    verlet_min_joint_distance:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.type.Read(s)
        self.lookup_radius.Read(s)
        self.offset_from_surface.Read(s)
        self.ray_count.Read(s)
        self.verlet_min_joint_distance.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.type.Write(s)
        self.lookup_radius.Write(s)
        self.offset_from_surface.Write(s)
        self.ray_count.Write(s)
        self.verlet_min_joint_distance.Write(s)

