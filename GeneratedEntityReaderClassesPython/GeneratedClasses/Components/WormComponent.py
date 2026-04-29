from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaLensValue
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class WormComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    speed:NoitaFloat = field(default_factory=NoitaFloat)
    acceleration:NoitaFloat = field(default_factory=NoitaFloat)
    ground_decceleration:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaFloat))
    gravity:NoitaFloat = field(default_factory=NoitaFloat)
    tail_gravity:NoitaFloat = field(default_factory=NoitaFloat)
    part_distance:NoitaFloat = field(default_factory=NoitaFloat)
    ground_check_offset:NoitaInt = field(default_factory=NoitaInt)
    hitbox_radius:NoitaFloat = field(default_factory=NoitaFloat)
    bite_damage:NoitaFloat = field(default_factory=NoitaFloat)
    target_kill_radius:NoitaFloat = field(default_factory=NoitaFloat)
    target_kill_ragdoll_force:NoitaFloat = field(default_factory=NoitaFloat)
    jump_cam_shake:NoitaFloat = field(default_factory=NoitaFloat)
    jump_cam_shake_distance:NoitaFloat = field(default_factory=NoitaFloat)
    eat_anim_wait_mult:NoitaFloat = field(default_factory=NoitaFloat)
    ragdoll_filename:NoitaString = field(default_factory=NoitaString)
    is_water_worm:NoitaBool = field(default_factory=NoitaBool)
    max_speed:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.speed.Read(s)
        self.acceleration.Read(s)
        self.ground_decceleration.Read(s)
        self.gravity.Read(s)
        self.tail_gravity.Read(s)
        self.part_distance.Read(s)
        self.ground_check_offset.Read(s)
        self.hitbox_radius.Read(s)
        self.bite_damage.Read(s)
        self.target_kill_radius.Read(s)
        self.target_kill_ragdoll_force.Read(s)
        self.jump_cam_shake.Read(s)
        self.jump_cam_shake_distance.Read(s)
        self.eat_anim_wait_mult.Read(s)
        self.ragdoll_filename.Read(s)
        self.is_water_worm.Read(s)
        self.max_speed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.speed.Write(s)
        self.acceleration.Write(s)
        self.ground_decceleration.Write(s)
        self.gravity.Write(s)
        self.tail_gravity.Write(s)
        self.part_distance.Write(s)
        self.ground_check_offset.Write(s)
        self.hitbox_radius.Write(s)
        self.bite_damage.Write(s)
        self.target_kill_radius.Write(s)
        self.target_kill_ragdoll_force.Write(s)
        self.jump_cam_shake.Write(s)
        self.jump_cam_shake_distance.Write(s)
        self.eat_anim_wait_mult.Write(s)
        self.ragdoll_filename.Write(s)
        self.is_water_worm.Write(s)
        self.max_speed.Write(s)

