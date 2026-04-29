from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class CrawlerAnimalComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    ray_length:NoitaFloat = field(default_factory=NoitaFloat)
    ray_count:NoitaInt = field(default_factory=NoitaInt)
    gravity:NoitaFloat = field(default_factory=NoitaFloat)
    terminal_velocity:NoitaFloat = field(default_factory=NoitaFloat)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    give_up_area_radius:NoitaInt = field(default_factory=NoitaInt)
    give_up_time:NoitaInt = field(default_factory=NoitaInt)
    attack_from_ceiling_check_ray_length:NoitaFloat = field(default_factory=NoitaFloat)
    attack_from_ceiling_check_every_n_frames:NoitaInt = field(default_factory=NoitaInt)
    collision_damage:NoitaFloat = field(default_factory=NoitaFloat)
    collision_damage_radius:NoitaFloat = field(default_factory=NoitaFloat)
    collision_damage_frames_between:NoitaInt = field(default_factory=NoitaInt)
    animate:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.ray_length.Read(s)
        self.ray_count.Read(s)
        self.gravity.Read(s)
        self.terminal_velocity.Read(s)
        self.speed.Read(s)
        self.give_up_area_radius.Read(s)
        self.give_up_time.Read(s)
        self.attack_from_ceiling_check_ray_length.Read(s)
        self.attack_from_ceiling_check_every_n_frames.Read(s)
        self.collision_damage.Read(s)
        self.collision_damage_radius.Read(s)
        self.collision_damage_frames_between.Read(s)
        self.animate.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.ray_length.Write(s)
        self.ray_count.Write(s)
        self.gravity.Write(s)
        self.terminal_velocity.Write(s)
        self.speed.Write(s)
        self.give_up_area_radius.Write(s)
        self.give_up_time.Write(s)
        self.attack_from_ceiling_check_ray_length.Write(s)
        self.attack_from_ceiling_check_every_n_frames.Write(s)
        self.collision_damage.Write(s)
        self.collision_damage_radius.Write(s)
        self.collision_damage_frames_between.Write(s)
        self.animate.Write(s)

