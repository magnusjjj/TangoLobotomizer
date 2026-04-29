from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PhysicsJointComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    nail_to_wall:NoitaBool = field(default_factory=NoitaBool)
    grid_joint:NoitaBool = field(default_factory=NoitaBool)
    breakable:NoitaBool = field(default_factory=NoitaBool)
    type:NoitaUInt = field(default_factory=NoitaUInt)
    body1_id:NoitaInt = field(default_factory=NoitaInt)
    body2_id:NoitaInt = field(default_factory=NoitaInt)
    pos_x:NoitaFloat = field(default_factory=NoitaFloat)
    pos_y:NoitaFloat = field(default_factory=NoitaFloat)
    delta_x:NoitaFloat = field(default_factory=NoitaFloat)
    delta_y:NoitaFloat = field(default_factory=NoitaFloat)
    mMotorEnabled:NoitaBool = field(default_factory=NoitaBool)
    mMotorSpeed:NoitaFloat = field(default_factory=NoitaFloat)
    mMaxMotorTorque:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.nail_to_wall.Read(s)
        self.grid_joint.Read(s)
        self.breakable.Read(s)
        self.type.Read(s)
        self.body1_id.Read(s)
        self.body2_id.Read(s)
        self.pos_x.Read(s)
        self.pos_y.Read(s)
        self.delta_x.Read(s)
        self.delta_y.Read(s)
        self.mMotorEnabled.Read(s)
        self.mMotorSpeed.Read(s)
        self.mMaxMotorTorque.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.nail_to_wall.Write(s)
        self.grid_joint.Write(s)
        self.breakable.Write(s)
        self.type.Write(s)
        self.body1_id.Write(s)
        self.body2_id.Write(s)
        self.pos_x.Write(s)
        self.pos_y.Write(s)
        self.delta_x.Write(s)
        self.delta_y.Write(s)
        self.mMotorEnabled.Write(s)
        self.mMotorSpeed.Write(s)
        self.mMaxMotorTorque.Write(s)

