from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class UIIconComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    icon_sprite_file:NoitaString = field(default_factory=NoitaString)
    name:NoitaString = field(default_factory=NoitaString)
    description:NoitaString = field(default_factory=NoitaString)
    display_above_head:NoitaBool = field(default_factory=NoitaBool)
    display_in_hud:NoitaBool = field(default_factory=NoitaBool)
    is_perk:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.icon_sprite_file.Read(s)
        self.name.Read(s)
        self.description.Read(s)
        self.display_above_head.Read(s)
        self.display_in_hud.Read(s)
        self.is_perk.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.icon_sprite_file.Write(s)
        self.name.Write(s)
        self.description.Write(s)
        self.display_above_head.Write(s)
        self.display_in_hud.Write(s)
        self.is_perk.Write(s)

