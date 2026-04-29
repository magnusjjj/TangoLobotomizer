from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUShort
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class PhysicsJoint2Component:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    joint_id:NoitaUShort = field(default_factory=NoitaUShort)
    break_force:NoitaFloat = field(default_factory=NoitaFloat)
    break_distance:NoitaFloat = field(default_factory=NoitaFloat)
    break_on_body_modified:NoitaBool = field(default_factory=NoitaBool)
    break_on_shear_angle_deg:NoitaFloat = field(default_factory=NoitaFloat)
    type:NoitaUInt = field(default_factory=NoitaUInt)
    body1_id:NoitaInt = field(default_factory=NoitaInt)
    body2_id:NoitaInt = field(default_factory=NoitaInt)
    offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    ray_x:NoitaFloat = field(default_factory=NoitaFloat)
    ray_y:NoitaFloat = field(default_factory=NoitaFloat)
    surface_attachment_offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    surface_attachment_offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.joint_id.Read(s)
        self.break_force.Read(s)
        self.break_distance.Read(s)
        self.break_on_body_modified.Read(s)
        self.break_on_shear_angle_deg.Read(s)
        self.type.Read(s)
        self.body1_id.Read(s)
        self.body2_id.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
        self.ray_x.Read(s)
        self.ray_y.Read(s)
        self.surface_attachment_offset_x.Read(s)
        self.surface_attachment_offset_y.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.joint_id.Write(s)
        self.break_force.Write(s)
        self.break_distance.Write(s)
        self.break_on_body_modified.Write(s)
        self.break_on_shear_angle_deg.Write(s)
        self.type.Write(s)
        self.body1_id.Write(s)
        self.body2_id.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)
        self.ray_x.Write(s)
        self.ray_y.Write(s)
        self.surface_attachment_offset_x.Write(s)
        self.surface_attachment_offset_y.Write(s)

