from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class CollisionTriggerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    width:NoitaFloat = field(default_factory=NoitaFloat)
    height:NoitaFloat = field(default_factory=NoitaFloat)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    required_tag:NoitaString = field(default_factory=NoitaString)
    remove_component_when_triggered:NoitaBool = field(default_factory=NoitaBool)
    destroy_this_entity_when_triggered:NoitaBool = field(default_factory=NoitaBool)
    timer_for_destruction:NoitaInt = field(default_factory=NoitaInt)
    self_trigger:NoitaBool = field(default_factory=NoitaBool)
    skip_self_frames:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.width.Read(s)
        self.height.Read(s)
        self.radius.Read(s)
        self.required_tag.Read(s)
        self.remove_component_when_triggered.Read(s)
        self.destroy_this_entity_when_triggered.Read(s)
        self.timer_for_destruction.Read(s)
        self.self_trigger.Read(s)
        self.skip_self_frames.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.width.Write(s)
        self.height.Write(s)
        self.radius.Write(s)
        self.required_tag.Write(s)
        self.remove_component_when_triggered.Write(s)
        self.destroy_this_entity_when_triggered.Write(s)
        self.timer_for_destruction.Write(s)
        self.self_trigger.Write(s)
        self.skip_self_frames.Write(s)

