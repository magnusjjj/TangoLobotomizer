from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from GeneratedClasses.ValueRangeInt import ValueRangeInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class LoadEntitiesComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    entity_file:NoitaString = field(default_factory=NoitaString)
    count:ValueRangeInt = field(default_factory=ValueRangeInt)
    kill_entity:NoitaBool = field(default_factory=NoitaBool)
    timeout_frames:NoitaInt = field(default_factory=NoitaInt)
    mTimerTriggerFrame:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.entity_file.Read(s)
        self.count.Read(s)
        self.kill_entity.Read(s)
        self.timeout_frames.Read(s)
        self.mTimerTriggerFrame.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.entity_file.Write(s)
        self.count.Write(s)
        self.kill_entity.Write(s)
        self.timeout_frames.Write(s)
        self.mTimerTriggerFrame.Write(s)

