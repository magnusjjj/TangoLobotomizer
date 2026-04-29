from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class SpriteOffsetAnimatorComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    x_amount:NoitaFloat = field(default_factory=NoitaFloat)
    x_speed:NoitaFloat = field(default_factory=NoitaFloat)
    y_amount:NoitaFloat = field(default_factory=NoitaFloat)
    y_speed:NoitaFloat = field(default_factory=NoitaFloat)
    sprite_id:NoitaInt = field(default_factory=NoitaInt)
    x_phase:NoitaFloat = field(default_factory=NoitaFloat)
    x_phase_offset:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.x_amount.Read(s)
        self.x_speed.Read(s)
        self.y_amount.Read(s)
        self.y_speed.Read(s)
        self.sprite_id.Read(s)
        self.x_phase.Read(s)
        self.x_phase_offset.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.x_amount.Write(s)
        self.x_speed.Write(s)
        self.y_amount.Write(s)
        self.y_speed.Write(s)
        self.sprite_id.Write(s)
        self.x_phase.Write(s)
        self.x_phase_offset.Write(s)

