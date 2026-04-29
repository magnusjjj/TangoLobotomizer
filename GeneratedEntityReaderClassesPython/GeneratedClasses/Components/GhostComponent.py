from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class GhostComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    velocity:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    new_hunt_target_check_every:NoitaInt = field(default_factory=NoitaInt)
    hunt_box_radius:NoitaFloat = field(default_factory=NoitaFloat)
    aggressiveness:NoitaFloat = field(default_factory=NoitaFloat)
    max_distance_from_home:NoitaFloat = field(default_factory=NoitaFloat)
    die_if_no_home:NoitaBool = field(default_factory=NoitaBool)
    target_tag:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.speed.Read(s)
        self.velocity.Read(s)
        self.new_hunt_target_check_every.Read(s)
        self.hunt_box_radius.Read(s)
        self.aggressiveness.Read(s)
        self.max_distance_from_home.Read(s)
        self.die_if_no_home.Read(s)
        self.target_tag.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.speed.Write(s)
        self.velocity.Write(s)
        self.new_hunt_target_check_every.Write(s)
        self.hunt_box_radius.Write(s)
        self.aggressiveness.Write(s)
        self.max_distance_from_home.Write(s)
        self.die_if_no_home.Write(s)
        self.target_tag.Write(s)

