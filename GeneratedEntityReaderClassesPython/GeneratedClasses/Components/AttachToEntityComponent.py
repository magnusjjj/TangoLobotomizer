from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCXForm
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class AttachToEntityComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    only_position:NoitaBool = field(default_factory=NoitaBool)
    target_hotspot_tag:NoitaString = field(default_factory=NoitaString)
    target_sprite_id:NoitaInt = field(default_factory=NoitaInt)
    rotate_based_on_x_scale:NoitaBool = field(default_factory=NoitaBool)
    destroy_component_when_target_is_gone:NoitaBool = field(default_factory=NoitaBool)
    Transform:NoitaCXForm = field(default_factory=lambda: NoitaCXForm(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.only_position.Read(s)
        self.target_hotspot_tag.Read(s)
        self.target_sprite_id.Read(s)
        self.rotate_based_on_x_scale.Read(s)
        self.destroy_component_when_target_is_gone.Read(s)
        self.Transform.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.only_position.Write(s)
        self.target_hotspot_tag.Write(s)
        self.target_sprite_id.Write(s)
        self.rotate_based_on_x_scale.Write(s)
        self.destroy_component_when_target_is_gone.Write(s)
        self.Transform.Write(s)

