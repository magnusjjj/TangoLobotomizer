from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ControlsComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    polymorph_hax:NoitaBool = field(default_factory=NoitaBool)
    polymorph_next_attack_frame:NoitaInt = field(default_factory=NoitaInt)
    enabled:NoitaBool = field(default_factory=NoitaBool)
    gamepad_indirect_aiming_enabled:NoitaBool = field(default_factory=NoitaBool)
    gamepad_fire_on_thumbstick_extend:NoitaBool = field(default_factory=NoitaBool)
    gamepad_fire_on_thumbstick_extend_threshold:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.polymorph_hax.Read(s)
        self.polymorph_next_attack_frame.Read(s)
        self.enabled.Read(s)
        self.gamepad_indirect_aiming_enabled.Read(s)
        self.gamepad_fire_on_thumbstick_extend.Read(s)
        self.gamepad_fire_on_thumbstick_extend_threshold.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.polymorph_hax.Write(s)
        self.polymorph_next_attack_frame.Write(s)
        self.enabled.Write(s)
        self.gamepad_indirect_aiming_enabled.Write(s)
        self.gamepad_fire_on_thumbstick_extend.Write(s)
        self.gamepad_fire_on_thumbstick_extend_threshold.Write(s)

