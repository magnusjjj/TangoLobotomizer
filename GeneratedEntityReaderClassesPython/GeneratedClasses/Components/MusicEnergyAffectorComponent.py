from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class MusicEnergyAffectorComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    energy_target:NoitaFloat = field(default_factory=NoitaFloat)
    fade_range:NoitaFloat = field(default_factory=NoitaFloat)
    trigger_danger_music:NoitaBool = field(default_factory=NoitaBool)
    fog_of_war_threshold:NoitaInt = field(default_factory=NoitaInt)
    is_enemy:NoitaBool = field(default_factory=NoitaBool)
    energy_lerp_up_speed_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.energy_target.Read(s)
        self.fade_range.Read(s)
        self.trigger_danger_music.Read(s)
        self.fog_of_war_threshold.Read(s)
        self.is_enemy.Read(s)
        self.energy_lerp_up_speed_multiplier.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.energy_target.Write(s)
        self.fade_range.Write(s)
        self.trigger_danger_music.Write(s)
        self.fog_of_war_threshold.Write(s)
        self.is_enemy.Write(s)
        self.energy_lerp_up_speed_multiplier.Write(s)

