from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class PhysicsKeepInWorldComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    check_whole_aabb:NoitaBool = field(default_factory=NoitaBool)
    predict_aabb:NoitaBool = field(default_factory=NoitaBool)
    keep_at_last_valid_pos:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.check_whole_aabb.Read(s)
        self.predict_aabb.Read(s)
        self.keep_at_last_valid_pos.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.check_whole_aabb.Write(s)
        self.predict_aabb.Write(s)
        self.keep_at_last_valid_pos.Write(s)

