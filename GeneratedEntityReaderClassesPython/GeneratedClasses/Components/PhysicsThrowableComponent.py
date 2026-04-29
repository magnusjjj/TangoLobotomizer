from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class PhysicsThrowableComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    throw_force_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    max_throw_speed:NoitaFloat = field(default_factory=NoitaFloat)
    min_torque:NoitaFloat = field(default_factory=NoitaFloat)
    max_torque:NoitaFloat = field(default_factory=NoitaFloat)
    tip_check_offset_min:NoitaFloat = field(default_factory=NoitaFloat)
    tip_check_offset_max:NoitaFloat = field(default_factory=NoitaFloat)
    tip_check_random_rotation_deg:NoitaFloat = field(default_factory=NoitaFloat)
    attach_min_speed:NoitaFloat = field(default_factory=NoitaFloat)
    attach_to_surfaces_knife_style:NoitaBool = field(default_factory=NoitaBool)
    hp:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.throw_force_coeff.Read(s)
        self.max_throw_speed.Read(s)
        self.min_torque.Read(s)
        self.max_torque.Read(s)
        self.tip_check_offset_min.Read(s)
        self.tip_check_offset_max.Read(s)
        self.tip_check_random_rotation_deg.Read(s)
        self.attach_min_speed.Read(s)
        self.attach_to_surfaces_knife_style.Read(s)
        self.hp.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.throw_force_coeff.Write(s)
        self.max_throw_speed.Write(s)
        self.min_torque.Write(s)
        self.max_torque.Write(s)
        self.tip_check_offset_min.Write(s)
        self.tip_check_offset_max.Write(s)
        self.tip_check_random_rotation_deg.Write(s)
        self.attach_min_speed.Write(s)
        self.attach_to_surfaces_knife_style.Write(s)
        self.hp.Write(s)

