from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PhysicsRagdollComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    filename:NoitaString = field(default_factory=NoitaString)
    filenames:NoitaString = field(default_factory=NoitaString)
    offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.filename.Read(s)
        self.filenames.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.filename.Write(s)
        self.filenames.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)

