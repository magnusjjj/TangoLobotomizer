from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class CharacterCollisionComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    getting_crushed_threshold:NoitaInt = field(default_factory=NoitaInt)
    moving_up_before_getting_crushed_threshold:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.getting_crushed_threshold.Read(s)
        self.moving_up_before_getting_crushed_threshold.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.getting_crushed_threshold.Write(s)
        self.moving_up_before_getting_crushed_threshold.Write(s)

