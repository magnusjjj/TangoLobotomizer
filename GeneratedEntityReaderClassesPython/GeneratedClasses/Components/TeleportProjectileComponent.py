from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class TeleportProjectileComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    min_distance_from_wall:NoitaFloat = field(default_factory=NoitaFloat)
    actionable_lifetime:NoitaInt = field(default_factory=NoitaInt)
    reset_shooter_y_vel:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.min_distance_from_wall.Read(s)
        self.actionable_lifetime.Read(s)
        self.reset_shooter_y_vel.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.min_distance_from_wall.Write(s)
        self.actionable_lifetime.Write(s)
        self.reset_shooter_y_vel.Write(s)

