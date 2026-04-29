from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class CameraBoundComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    enabled:NoitaBool = field(default_factory=NoitaBool)
    distance:NoitaFloat = field(default_factory=NoitaFloat)
    distance_border:NoitaFloat = field(default_factory=NoitaFloat)
    max_count:NoitaInt = field(default_factory=NoitaInt)
    freeze_on_distance_kill:NoitaBool = field(default_factory=NoitaBool)
    freeze_on_max_count_kill:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.enabled.Read(s)
        self.distance.Read(s)
        self.distance_border.Read(s)
        self.max_count.Read(s)
        self.freeze_on_distance_kill.Read(s)
        self.freeze_on_max_count_kill.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.enabled.Write(s)
        self.distance.Write(s)
        self.distance_border.Write(s)
        self.max_count.Write(s)
        self.freeze_on_distance_kill.Write(s)
        self.freeze_on_max_count_kill.Write(s)

