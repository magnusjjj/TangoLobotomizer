from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class IKLimbAttackerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    leg_velocity_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    targeting_radius:NoitaFloat = field(default_factory=NoitaFloat)
    targeting_raytrace:NoitaBool = field(default_factory=NoitaBool)
    target_entities_with_tag:NoitaString = field(default_factory=NoitaString)
    mTarget:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.leg_velocity_coeff.Read(s)
        self.targeting_radius.Read(s)
        self.targeting_raytrace.Read(s)
        self.target_entities_with_tag.Read(s)
        self.mTarget.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.leg_velocity_coeff.Write(s)
        self.targeting_radius.Write(s)
        self.targeting_raytrace.Write(s)
        self.target_entities_with_tag.Write(s)
        self.mTarget.Write(s)

