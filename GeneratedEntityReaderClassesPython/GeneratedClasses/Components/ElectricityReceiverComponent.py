from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ElectricityReceiverComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    offset_x:NoitaInt = field(default_factory=NoitaInt)
    offset_y:NoitaInt = field(default_factory=NoitaInt)
    radius:NoitaInt = field(default_factory=NoitaInt)
    active_time_frames:NoitaInt = field(default_factory=NoitaInt)
    switch_on_msg_interval_frames:NoitaInt = field(default_factory=NoitaInt)
    electrified_msg_interval_frames:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
        self.radius.Read(s)
        self.active_time_frames.Read(s)
        self.switch_on_msg_interval_frames.Read(s)
        self.electrified_msg_interval_frames.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)
        self.radius.Write(s)
        self.active_time_frames.Write(s)
        self.switch_on_msg_interval_frames.Write(s)
        self.electrified_msg_interval_frames.Write(s)

