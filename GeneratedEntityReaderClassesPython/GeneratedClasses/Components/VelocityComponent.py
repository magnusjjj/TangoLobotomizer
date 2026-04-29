from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class VelocityComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    gravity_x:NoitaFloat = field(default_factory=NoitaFloat)
    gravity_y:NoitaFloat = field(default_factory=NoitaFloat)
    mass:NoitaFloat = field(default_factory=NoitaFloat)
    air_friction:NoitaFloat = field(default_factory=NoitaFloat)
    terminal_velocity:NoitaFloat = field(default_factory=NoitaFloat)
    apply_terminal_velocity:NoitaBool = field(default_factory=NoitaBool)
    updates_velocity:NoitaBool = field(default_factory=NoitaBool)
    displace_liquid:NoitaBool = field(default_factory=NoitaBool)
    affect_physics_bodies:NoitaBool = field(default_factory=NoitaBool)
    limit_to_max_velocity:NoitaBool = field(default_factory=NoitaBool)
    liquid_death_threshold:NoitaInt = field(default_factory=NoitaInt)
    liquid_drag:NoitaFloat = field(default_factory=NoitaFloat)
    mVelocity:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.gravity_x.Read(s)
        self.gravity_y.Read(s)
        self.mass.Read(s)
        self.air_friction.Read(s)
        self.terminal_velocity.Read(s)
        self.apply_terminal_velocity.Read(s)
        self.updates_velocity.Read(s)
        self.displace_liquid.Read(s)
        self.affect_physics_bodies.Read(s)
        self.limit_to_max_velocity.Read(s)
        self.liquid_death_threshold.Read(s)
        self.liquid_drag.Read(s)
        self.mVelocity.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.gravity_x.Write(s)
        self.gravity_y.Write(s)
        self.mass.Write(s)
        self.air_friction.Write(s)
        self.terminal_velocity.Write(s)
        self.apply_terminal_velocity.Write(s)
        self.updates_velocity.Write(s)
        self.displace_liquid.Write(s)
        self.affect_physics_bodies.Write(s)
        self.limit_to_max_velocity.Write(s)
        self.liquid_death_threshold.Write(s)
        self.liquid_drag.Write(s)
        self.mVelocity.Write(s)

