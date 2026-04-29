from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class VerletWeaponComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    damage_radius:NoitaFloat = field(default_factory=NoitaFloat)
    physics_force_radius:NoitaFloat = field(default_factory=NoitaFloat)
    damage_min_step:NoitaFloat = field(default_factory=NoitaFloat)
    damage_max:NoitaFloat = field(default_factory=NoitaFloat)
    damage_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    impulse_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    fade_duration_frames:NoitaInt = field(default_factory=NoitaInt)
    physics_impulse_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.damage_radius.Read(s)
        self.physics_force_radius.Read(s)
        self.damage_min_step.Read(s)
        self.damage_max.Read(s)
        self.damage_coeff.Read(s)
        self.impulse_coeff.Read(s)
        self.fade_duration_frames.Read(s)
        self.physics_impulse_coeff.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.damage_radius.Write(s)
        self.physics_force_radius.Write(s)
        self.damage_min_step.Write(s)
        self.damage_max.Write(s)
        self.damage_coeff.Write(s)
        self.impulse_coeff.Write(s)
        self.fade_duration_frames.Write(s)
        self.physics_impulse_coeff.Write(s)

