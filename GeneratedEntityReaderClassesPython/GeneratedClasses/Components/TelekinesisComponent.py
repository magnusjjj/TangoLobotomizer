from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaUInt64

from NoitaStream import NoitaStream
@dataclass
class TelekinesisComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    min_size:NoitaUInt = field(default_factory=NoitaUInt)
    max_size:NoitaUInt = field(default_factory=NoitaUInt)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    throw_speed:NoitaFloat = field(default_factory=NoitaFloat)
    target_distance:NoitaFloat = field(default_factory=NoitaFloat)
    kick_to_use:NoitaBool = field(default_factory=NoitaBool)
    mState:NoitaInt = field(default_factory=NoitaInt)
    mBodyID:NoitaUInt64 = field(default_factory=NoitaUInt64)
    mStartBodyMaxExtent:NoitaFloat = field(default_factory=NoitaFloat)
    mStartAimAngle:NoitaFloat = field(default_factory=NoitaFloat)
    mStartBodyAngle:NoitaFloat = field(default_factory=NoitaFloat)
    mStartBodyDistance:NoitaFloat = field(default_factory=NoitaFloat)
    mStartTime:NoitaFloat = field(default_factory=NoitaFloat)
    mMinBodyDistance:NoitaFloat = field(default_factory=NoitaFloat)
    mInteract:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.min_size.Read(s)
        self.max_size.Read(s)
        self.radius.Read(s)
        self.throw_speed.Read(s)
        self.target_distance.Read(s)
        self.kick_to_use.Read(s)
        self.mState.Read(s)
        self.mBodyID.Read(s)
        self.mStartBodyMaxExtent.Read(s)
        self.mStartAimAngle.Read(s)
        self.mStartBodyAngle.Read(s)
        self.mStartBodyDistance.Read(s)
        self.mStartTime.Read(s)
        self.mMinBodyDistance.Read(s)
        self.mInteract.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.min_size.Write(s)
        self.max_size.Write(s)
        self.radius.Write(s)
        self.throw_speed.Write(s)
        self.target_distance.Write(s)
        self.kick_to_use.Write(s)
        self.mState.Write(s)
        self.mBodyID.Write(s)
        self.mStartBodyMaxExtent.Write(s)
        self.mStartAimAngle.Write(s)
        self.mStartBodyAngle.Write(s)
        self.mStartBodyDistance.Write(s)
        self.mStartTime.Write(s)
        self.mMinBodyDistance.Write(s)
        self.mInteract.Write(s)

