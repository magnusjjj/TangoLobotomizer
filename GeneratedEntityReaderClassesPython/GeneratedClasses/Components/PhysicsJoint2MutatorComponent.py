from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUShort
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt64

from NoitaStream import NoitaStream
@dataclass
class PhysicsJoint2MutatorComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    joint_id:NoitaUShort = field(default_factory=NoitaUShort)
    destroy:NoitaBool = field(default_factory=NoitaBool)
    motor_speed:NoitaFloat = field(default_factory=NoitaFloat)
    motor_max_torque:NoitaFloat = field(default_factory=NoitaFloat)
    mBox2DJointId:NoitaUInt64 = field(default_factory=NoitaUInt64)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.joint_id.Read(s)
        self.destroy.Read(s)
        self.motor_speed.Read(s)
        self.motor_max_torque.Read(s)
        self.mBox2DJointId.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.joint_id.Write(s)
        self.destroy.Write(s)
        self.motor_speed.Write(s)
        self.motor_max_torque.Write(s)
        self.mBox2DJointId.Write(s)

