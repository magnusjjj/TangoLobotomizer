from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class HomingComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    target_tag:NoitaString = field(default_factory=NoitaString)
    target_who_shot:NoitaBool = field(default_factory=NoitaBool)
    detect_distance:NoitaFloat = field(default_factory=NoitaFloat)
    homing_velocity_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    homing_targeting_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    just_rotate_towards_target:NoitaBool = field(default_factory=NoitaBool)
    max_turn_rate:NoitaFloat = field(default_factory=NoitaFloat)
    predefined_target:NoitaUInt = field(default_factory=NoitaUInt)
    look_for_root_entities_only:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.target_tag.Read(s)
        self.target_who_shot.Read(s)
        self.detect_distance.Read(s)
        self.homing_velocity_multiplier.Read(s)
        self.homing_targeting_coeff.Read(s)
        self.just_rotate_towards_target.Read(s)
        self.max_turn_rate.Read(s)
        self.predefined_target.Read(s)
        self.look_for_root_entities_only.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.target_tag.Write(s)
        self.target_who_shot.Write(s)
        self.detect_distance.Write(s)
        self.homing_velocity_multiplier.Write(s)
        self.homing_targeting_coeff.Write(s)
        self.just_rotate_towards_target.Write(s)
        self.max_turn_rate.Write(s)
        self.predefined_target.Write(s)
        self.look_for_root_entities_only.Write(s)

