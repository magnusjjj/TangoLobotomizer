from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class LooseGroundComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    probability:NoitaFloat = field(default_factory=NoitaFloat)
    max_durability:NoitaInt = field(default_factory=NoitaInt)
    max_distance:NoitaFloat = field(default_factory=NoitaFloat)
    max_angle:NoitaFloat = field(default_factory=NoitaFloat)
    min_radius:NoitaInt = field(default_factory=NoitaInt)
    max_radius:NoitaInt = field(default_factory=NoitaInt)
    chunk_probability:NoitaFloat = field(default_factory=NoitaFloat)
    chunk_max_angle:NoitaFloat = field(default_factory=NoitaFloat)
    chunk_count:NoitaInt = field(default_factory=NoitaInt)
    chunk_material:NoitaInt = field(default_factory=NoitaInt)
    collapse_images:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.probability.Read(s)
        self.max_durability.Read(s)
        self.max_distance.Read(s)
        self.max_angle.Read(s)
        self.min_radius.Read(s)
        self.max_radius.Read(s)
        self.chunk_probability.Read(s)
        self.chunk_max_angle.Read(s)
        self.chunk_count.Read(s)
        self.chunk_material.Read(s)
        self.collapse_images.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.probability.Write(s)
        self.max_durability.Write(s)
        self.max_distance.Write(s)
        self.max_angle.Write(s)
        self.min_radius.Write(s)
        self.max_radius.Write(s)
        self.chunk_probability.Write(s)
        self.chunk_max_angle.Write(s)
        self.chunk_count.Write(s)
        self.chunk_material.Write(s)
        self.collapse_images.Write(s)

