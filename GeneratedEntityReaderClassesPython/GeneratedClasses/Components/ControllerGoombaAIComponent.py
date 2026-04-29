from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ControllerGoombaAIComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    auto_turn_around_enabled:NoitaBool = field(default_factory=NoitaBool)
    wait_to_turn_around:NoitaInt = field(default_factory=NoitaInt)
    wall_hit_wait:NoitaInt = field(default_factory=NoitaInt)
    check_wall_detection:NoitaBool = field(default_factory=NoitaBool)
    wall_detection_aabb_min_x:NoitaFloat = field(default_factory=NoitaFloat)
    wall_detection_aabb_max_x:NoitaFloat = field(default_factory=NoitaFloat)
    wall_detection_aabb_min_y:NoitaFloat = field(default_factory=NoitaFloat)
    wall_detection_aabb_max_y:NoitaFloat = field(default_factory=NoitaFloat)
    check_floor_detection:NoitaBool = field(default_factory=NoitaBool)
    floor_detection_aabb_min_x:NoitaFloat = field(default_factory=NoitaFloat)
    floor_detection_aabb_max_x:NoitaFloat = field(default_factory=NoitaFloat)
    floor_detection_aabb_min_y:NoitaFloat = field(default_factory=NoitaFloat)
    floor_detection_aabb_max_y:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.auto_turn_around_enabled.Read(s)
        self.wait_to_turn_around.Read(s)
        self.wall_hit_wait.Read(s)
        self.check_wall_detection.Read(s)
        self.wall_detection_aabb_min_x.Read(s)
        self.wall_detection_aabb_max_x.Read(s)
        self.wall_detection_aabb_min_y.Read(s)
        self.wall_detection_aabb_max_y.Read(s)
        self.check_floor_detection.Read(s)
        self.floor_detection_aabb_min_x.Read(s)
        self.floor_detection_aabb_max_x.Read(s)
        self.floor_detection_aabb_min_y.Read(s)
        self.floor_detection_aabb_max_y.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.auto_turn_around_enabled.Write(s)
        self.wait_to_turn_around.Write(s)
        self.wall_hit_wait.Write(s)
        self.check_wall_detection.Write(s)
        self.wall_detection_aabb_min_x.Write(s)
        self.wall_detection_aabb_max_x.Write(s)
        self.wall_detection_aabb_min_y.Write(s)
        self.wall_detection_aabb_max_y.Write(s)
        self.check_floor_detection.Write(s)
        self.floor_detection_aabb_min_x.Write(s)
        self.floor_detection_aabb_max_x.Write(s)
        self.floor_detection_aabb_min_y.Write(s)
        self.floor_detection_aabb_max_y.Write(s)

