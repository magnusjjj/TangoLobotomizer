from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class TorchComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    probability_of_ignition_attempt:NoitaInt = field(default_factory=NoitaInt)
    suffocation_check_offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    frames_suffocated_to_extinguish:NoitaInt = field(default_factory=NoitaInt)
    extinguishable:NoitaBool = field(default_factory=NoitaBool)
    fire_audio_weight:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.probability_of_ignition_attempt.Read(s)
        self.suffocation_check_offset_y.Read(s)
        self.frames_suffocated_to_extinguish.Read(s)
        self.extinguishable.Read(s)
        self.fire_audio_weight.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.probability_of_ignition_attempt.Write(s)
        self.suffocation_check_offset_y.Write(s)
        self.frames_suffocated_to_extinguish.Write(s)
        self.extinguishable.Write(s)
        self.fire_audio_weight.Write(s)

