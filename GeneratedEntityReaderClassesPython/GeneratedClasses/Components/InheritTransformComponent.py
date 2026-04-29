from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCXForm
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class InheritTransformComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    use_root_parent:NoitaBool = field(default_factory=NoitaBool)
    only_position:NoitaBool = field(default_factory=NoitaBool)
    parent_hotspot_tag:NoitaString = field(default_factory=NoitaString)
    parent_sprite_id:NoitaInt = field(default_factory=NoitaInt)
    always_use_immediate_parent_rotation:NoitaBool = field(default_factory=NoitaBool)
    rotate_based_on_x_scale:NoitaBool = field(default_factory=NoitaBool)
    Transform:NoitaCXForm = field(default_factory=lambda: NoitaCXForm(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.use_root_parent.Read(s)
        self.only_position.Read(s)
        self.parent_hotspot_tag.Read(s)
        self.parent_sprite_id.Read(s)
        self.always_use_immediate_parent_rotation.Read(s)
        self.rotate_based_on_x_scale.Read(s)
        self.Transform.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.use_root_parent.Write(s)
        self.only_position.Write(s)
        self.parent_hotspot_tag.Write(s)
        self.parent_sprite_id.Write(s)
        self.always_use_immediate_parent_rotation.Write(s)
        self.rotate_based_on_x_scale.Write(s)
        self.Transform.Write(s)

