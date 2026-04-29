from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class MagicXRayComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaInt = field(default_factory=NoitaInt)
    steps_per_frame:NoitaInt = field(default_factory=NoitaInt)
    mStep:NoitaInt = field(default_factory=NoitaInt)
    mRadius:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.steps_per_frame.Read(s)
        self.mStep.Read(s)
        self.mRadius.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.steps_per_frame.Write(s)
        self.mStep.Write(s)
        self.mRadius.Write(s)

