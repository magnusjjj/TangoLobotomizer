from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class IKLimbWalkerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    ground_attachment_min_spread:NoitaFloat = field(default_factory=NoitaFloat)
    ground_attachment_max_tries:NoitaInt = field(default_factory=NoitaInt)
    ground_attachment_max_angle:NoitaFloat = field(default_factory=NoitaFloat)
    ground_attachment_ray_length_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    leg_velocity_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    affect_flying:NoitaBool = field(default_factory=NoitaBool)
    ray_skip_material:NoitaInt = field(default_factory=NoitaInt)
    mTarget:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    mPrevTarget:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    mPrevCenterPosition:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    mState:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.ground_attachment_min_spread.Read(s)
        self.ground_attachment_max_tries.Read(s)
        self.ground_attachment_max_angle.Read(s)
        self.ground_attachment_ray_length_coeff.Read(s)
        self.leg_velocity_coeff.Read(s)
        self.affect_flying.Read(s)
        self.ray_skip_material.Read(s)
        self.mTarget.Read(s)
        self.mPrevTarget.Read(s)
        self.mPrevCenterPosition.Read(s)
        self.mState.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.ground_attachment_min_spread.Write(s)
        self.ground_attachment_max_tries.Write(s)
        self.ground_attachment_max_angle.Write(s)
        self.ground_attachment_ray_length_coeff.Write(s)
        self.leg_velocity_coeff.Write(s)
        self.affect_flying.Write(s)
        self.ray_skip_material.Write(s)
        self.mTarget.Write(s)
        self.mPrevTarget.Write(s)
        self.mPrevCenterPosition.Write(s)
        self.mState.Write(s)

