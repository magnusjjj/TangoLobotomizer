from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class AreaDamageComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    aabb_min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    aabb_max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    circle_radius:NoitaFloat = field(default_factory=NoitaFloat)
    damage_type:NoitaUInt = field(default_factory=NoitaUInt)
    damage_per_frame:NoitaFloat = field(default_factory=NoitaFloat)
    update_every_n_frame:NoitaInt = field(default_factory=NoitaInt)
    entity_responsible:NoitaUInt = field(default_factory=NoitaUInt)
    death_cause:NoitaString = field(default_factory=NoitaString)
    entities_with_tag:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.aabb_min.Read(s)
        self.aabb_max.Read(s)
        self.circle_radius.Read(s)
        self.damage_type.Read(s)
        self.damage_per_frame.Read(s)
        self.update_every_n_frame.Read(s)
        self.entity_responsible.Read(s)
        self.death_cause.Read(s)
        self.entities_with_tag.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.aabb_min.Write(s)
        self.aabb_max.Write(s)
        self.circle_radius.Write(s)
        self.damage_type.Write(s)
        self.damage_per_frame.Write(s)
        self.update_every_n_frame.Write(s)
        self.entity_responsible.Write(s)
        self.death_cause.Write(s)
        self.entities_with_tag.Write(s)

