from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class IKLimbComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    length:NoitaFloat = field(default_factory=NoitaFloat)
    thigh_extra_lenght:NoitaFloat = field(default_factory=NoitaFloat)
    end_position:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    mJointSideInterpolation:NoitaFloat = field(default_factory=NoitaFloat)
    mJointWorldPos:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    mEndPrevPos:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.length.Read(s)
        self.thigh_extra_lenght.Read(s)
        self.end_position.Read(s)
        self.mJointSideInterpolation.Read(s)
        self.mJointWorldPos.Read(s)
        self.mEndPrevPos.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.length.Write(s)
        self.thigh_extra_lenght.Write(s)
        self.end_position.Write(s)
        self.mJointSideInterpolation.Write(s)
        self.mJointWorldPos.Write(s)
        self.mEndPrevPos.Write(s)

