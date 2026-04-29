from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class PhysicsShapeComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    recreate:NoitaBool = field(default_factory=NoitaBool)
    is_circle:NoitaBool = field(default_factory=NoitaBool)
    is_box:NoitaBool = field(default_factory=NoitaBool)
    is_capsule:NoitaBool = field(default_factory=NoitaBool)
    is_based_on_sprite:NoitaBool = field(default_factory=NoitaBool)
    friction:NoitaFloat = field(default_factory=NoitaFloat)
    restitution:NoitaFloat = field(default_factory=NoitaFloat)
    density:NoitaFloat = field(default_factory=NoitaFloat)
    local_position_x:NoitaFloat = field(default_factory=NoitaFloat)
    local_position_y:NoitaFloat = field(default_factory=NoitaFloat)
    radius_x:NoitaFloat = field(default_factory=NoitaFloat)
    radius_y:NoitaFloat = field(default_factory=NoitaFloat)
    capsule_x_percent:NoitaFloat = field(default_factory=NoitaFloat)
    capsule_y_percent:NoitaFloat = field(default_factory=NoitaFloat)
    material:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.recreate.Read(s)
        self.is_circle.Read(s)
        self.is_box.Read(s)
        self.is_capsule.Read(s)
        self.is_based_on_sprite.Read(s)
        self.friction.Read(s)
        self.restitution.Read(s)
        self.density.Read(s)
        self.local_position_x.Read(s)
        self.local_position_y.Read(s)
        self.radius_x.Read(s)
        self.radius_y.Read(s)
        self.capsule_x_percent.Read(s)
        self.capsule_y_percent.Read(s)
        self.material.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.recreate.Write(s)
        self.is_circle.Write(s)
        self.is_box.Write(s)
        self.is_capsule.Write(s)
        self.is_based_on_sprite.Write(s)
        self.friction.Write(s)
        self.restitution.Write(s)
        self.density.Write(s)
        self.local_position_x.Write(s)
        self.local_position_y.Write(s)
        self.radius_x.Write(s)
        self.radius_y.Write(s)
        self.capsule_x_percent.Write(s)
        self.capsule_y_percent.Write(s)
        self.material.Write(s)

