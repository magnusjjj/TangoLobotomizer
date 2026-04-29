from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class PlatformShooterPlayerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    aiming_reticle_distance_from_character:NoitaFloat = field(default_factory=NoitaFloat)
    camera_max_distance_from_character:NoitaFloat = field(default_factory=NoitaFloat)
    alcohol_drunken_speed:NoitaFloat = field(default_factory=NoitaFloat)
    blood_fungi_drunken_speed:NoitaFloat = field(default_factory=NoitaFloat)
    blood_worm_drunken_speed:NoitaFloat = field(default_factory=NoitaFloat)
    eating_area_min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    eating_area_max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    eating_cells_per_frame:NoitaInt = field(default_factory=NoitaInt)
    eating_probability:NoitaInt = field(default_factory=NoitaInt)
    eating_delay_frames:NoitaInt = field(default_factory=NoitaInt)
    stoned_speed:NoitaFloat = field(default_factory=NoitaFloat)
    center_camera_on_this_entity:NoitaBool = field(default_factory=NoitaBool)
    move_camera_with_aim:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.aiming_reticle_distance_from_character.Read(s)
        self.camera_max_distance_from_character.Read(s)
        self.alcohol_drunken_speed.Read(s)
        self.blood_fungi_drunken_speed.Read(s)
        self.blood_worm_drunken_speed.Read(s)
        self.eating_area_min.Read(s)
        self.eating_area_max.Read(s)
        self.eating_cells_per_frame.Read(s)
        self.eating_probability.Read(s)
        self.eating_delay_frames.Read(s)
        self.stoned_speed.Read(s)
        self.center_camera_on_this_entity.Read(s)
        self.move_camera_with_aim.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.aiming_reticle_distance_from_character.Write(s)
        self.camera_max_distance_from_character.Write(s)
        self.alcohol_drunken_speed.Write(s)
        self.blood_fungi_drunken_speed.Write(s)
        self.blood_worm_drunken_speed.Write(s)
        self.eating_area_min.Write(s)
        self.eating_area_max.Write(s)
        self.eating_cells_per_frame.Write(s)
        self.eating_probability.Write(s)
        self.eating_delay_frames.Write(s)
        self.stoned_speed.Write(s)
        self.center_camera_on_this_entity.Write(s)
        self.move_camera_with_aim.Write(s)

