from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class AudioLoopComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    file:NoitaString = field(default_factory=NoitaString)
    event_name:NoitaString = field(default_factory=NoitaString)
    auto_play:NoitaBool = field(default_factory=NoitaBool)
    auto_play_if_enabled:NoitaBool = field(default_factory=NoitaBool)
    play_on_component_enable:NoitaBool = field(default_factory=NoitaBool)
    calculate_material_lowpass:NoitaBool = field(default_factory=NoitaBool)
    set_speed_parameter:NoitaBool = field(default_factory=NoitaBool)
    set_speed_parameter_only_based_on_x_movement:NoitaBool = field(default_factory=NoitaBool)
    set_speed_parameter_only_based_on_y_movement:NoitaBool = field(default_factory=NoitaBool)
    volume_autofade_speed:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.file.Read(s)
        self.event_name.Read(s)
        self.auto_play.Read(s)
        self.auto_play_if_enabled.Read(s)
        self.play_on_component_enable.Read(s)
        self.calculate_material_lowpass.Read(s)
        self.set_speed_parameter.Read(s)
        self.set_speed_parameter_only_based_on_x_movement.Read(s)
        self.set_speed_parameter_only_based_on_y_movement.Read(s)
        self.volume_autofade_speed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.file.Write(s)
        self.event_name.Write(s)
        self.auto_play.Write(s)
        self.auto_play_if_enabled.Write(s)
        self.play_on_component_enable.Write(s)
        self.calculate_material_lowpass.Write(s)
        self.set_speed_parameter.Write(s)
        self.set_speed_parameter_only_based_on_x_movement.Write(s)
        self.set_speed_parameter_only_based_on_y_movement.Write(s)
        self.volume_autofade_speed.Write(s)

