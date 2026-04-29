from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class WormAIComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    speed_hunt:NoitaFloat = field(default_factory=NoitaFloat)
    direction_adjust_speed:NoitaFloat = field(default_factory=NoitaFloat)
    direction_adjust_speed_hunt:NoitaFloat = field(default_factory=NoitaFloat)
    random_target_box_radius:NoitaFloat = field(default_factory=NoitaFloat)
    new_hunt_target_check_every:NoitaInt = field(default_factory=NoitaInt)
    new_random_target_check_every:NoitaInt = field(default_factory=NoitaInt)
    hunt_box_radius:NoitaFloat = field(default_factory=NoitaFloat)
    cocoon_food_required:NoitaInt = field(default_factory=NoitaInt)
    cocoon_entity:NoitaString = field(default_factory=NoitaString)
    give_up_area_radius:NoitaFloat = field(default_factory=NoitaFloat)
    give_up_time_frames:NoitaInt = field(default_factory=NoitaInt)
    debug_follow_mouse:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.speed.Read(s)
        self.speed_hunt.Read(s)
        self.direction_adjust_speed.Read(s)
        self.direction_adjust_speed_hunt.Read(s)
        self.random_target_box_radius.Read(s)
        self.new_hunt_target_check_every.Read(s)
        self.new_random_target_check_every.Read(s)
        self.hunt_box_radius.Read(s)
        self.cocoon_food_required.Read(s)
        self.cocoon_entity.Read(s)
        self.give_up_area_radius.Read(s)
        self.give_up_time_frames.Read(s)
        self.debug_follow_mouse.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.speed.Write(s)
        self.speed_hunt.Write(s)
        self.direction_adjust_speed.Write(s)
        self.direction_adjust_speed_hunt.Write(s)
        self.random_target_box_radius.Write(s)
        self.new_hunt_target_check_every.Write(s)
        self.new_random_target_check_every.Write(s)
        self.hunt_box_radius.Write(s)
        self.cocoon_food_required.Write(s)
        self.cocoon_entity.Write(s)
        self.give_up_area_radius.Write(s)
        self.give_up_time_frames.Write(s)
        self.debug_follow_mouse.Write(s)

