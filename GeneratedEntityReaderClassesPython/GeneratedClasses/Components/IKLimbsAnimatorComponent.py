from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class IKLimbsAnimatorComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    future_state_samples:NoitaInt = field(default_factory=NoitaInt)
    ground_attachment_ray_length_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    leg_velocity_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    affect_flying:NoitaBool = field(default_factory=NoitaBool)
    large_movement_penalty_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    no_ground_attachment_penalty_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    ray_skip_material:NoitaInt = field(default_factory=NoitaInt)
    is_limp:NoitaBool = field(default_factory=NoitaBool)
    mPrevBodyPosition:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.future_state_samples.Read(s)
        self.ground_attachment_ray_length_coeff.Read(s)
        self.leg_velocity_coeff.Read(s)
        self.affect_flying.Read(s)
        self.large_movement_penalty_coeff.Read(s)
        self.no_ground_attachment_penalty_coeff.Read(s)
        self.ray_skip_material.Read(s)
        self.is_limp.Read(s)
        self.mPrevBodyPosition.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.future_state_samples.Write(s)
        self.ground_attachment_ray_length_coeff.Write(s)
        self.leg_velocity_coeff.Write(s)
        self.affect_flying.Write(s)
        self.large_movement_penalty_coeff.Write(s)
        self.no_ground_attachment_penalty_coeff.Write(s)
        self.ray_skip_material.Write(s)
        self.is_limp.Write(s)
        self.mPrevBodyPosition.Write(s)

