from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class LightComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    update_properties:NoitaBool = field(default_factory=NoitaBool)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    r:NoitaUInt = field(default_factory=NoitaUInt)
    g:NoitaUInt = field(default_factory=NoitaUInt)
    b:NoitaUInt = field(default_factory=NoitaUInt)
    offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    fade_out_time:NoitaFloat = field(default_factory=NoitaFloat)
    blinking_freq:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.update_properties.Read(s)
        self.radius.Read(s)
        self.r.Read(s)
        self.g.Read(s)
        self.b.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
        self.fade_out_time.Read(s)
        self.blinking_freq.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.update_properties.Write(s)
        self.radius.Write(s)
        self.r.Write(s)
        self.g.Write(s)
        self.b.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)
        self.fade_out_time.Write(s)
        self.blinking_freq.Write(s)

