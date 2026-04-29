from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class RotateTowardsComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    entity_with_tag:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.entity_with_tag.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.entity_with_tag.Write(s)

