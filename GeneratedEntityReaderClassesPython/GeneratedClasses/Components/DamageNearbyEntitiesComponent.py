from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class DamageNearbyEntitiesComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    damage_min:NoitaFloat = field(default_factory=NoitaFloat)
    damage_max:NoitaFloat = field(default_factory=NoitaFloat)
    target_vec_max_len:NoitaFloat = field(default_factory=NoitaFloat)
    knockback_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    time_between_damaging:NoitaInt = field(default_factory=NoitaInt)
    damage_type:NoitaUInt = field(default_factory=NoitaUInt)
    damage_description:NoitaString = field(default_factory=NoitaString)
    target_tag:NoitaString = field(default_factory=NoitaString)
    ragdoll_fx:NoitaUInt = field(default_factory=NoitaUInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.damage_min.Read(s)
        self.damage_max.Read(s)
        self.target_vec_max_len.Read(s)
        self.knockback_multiplier.Read(s)
        self.time_between_damaging.Read(s)
        self.damage_type.Read(s)
        self.damage_description.Read(s)
        self.target_tag.Read(s)
        self.ragdoll_fx.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.damage_min.Write(s)
        self.damage_max.Write(s)
        self.target_vec_max_len.Write(s)
        self.knockback_multiplier.Write(s)
        self.time_between_damaging.Write(s)
        self.damage_type.Write(s)
        self.damage_description.Write(s)
        self.target_tag.Write(s)
        self.ragdoll_fx.Write(s)

