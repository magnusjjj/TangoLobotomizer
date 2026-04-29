from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class HotspotComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    offset:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    transform_with_scale:NoitaBool = field(default_factory=NoitaBool)
    sprite_hotspot_name:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.offset.Read(s)
        self.transform_with_scale.Read(s)
        self.sprite_hotspot_name.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.offset.Write(s)
        self.transform_with_scale.Write(s)
        self.sprite_hotspot_name.Write(s)

