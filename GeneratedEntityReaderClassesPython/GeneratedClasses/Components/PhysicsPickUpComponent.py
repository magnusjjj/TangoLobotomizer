from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaCXForm
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PhysicsPickUpComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    transform:NoitaCXForm = field(default_factory=lambda: NoitaCXForm(NoitaFloat))
    original_left_joint_pos:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    original_right_joint_pos:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    pick_up_strength:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.transform.Read(s)
        self.original_left_joint_pos.Read(s)
        self.original_right_joint_pos.Read(s)
        self.pick_up_strength.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.transform.Write(s)
        self.original_left_joint_pos.Write(s)
        self.original_right_joint_pos.Write(s)
        self.pick_up_strength.Write(s)

