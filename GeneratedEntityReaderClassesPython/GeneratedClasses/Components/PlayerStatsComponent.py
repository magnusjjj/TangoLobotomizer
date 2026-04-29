from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PlayerStatsComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    lives:NoitaInt = field(default_factory=NoitaInt)
    max_hp:NoitaFloat = field(default_factory=NoitaFloat)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.lives.Read(s)
        self.max_hp.Read(s)
        self.speed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.lives.Write(s)
        self.max_hp.Write(s)
        self.speed.Write(s)

