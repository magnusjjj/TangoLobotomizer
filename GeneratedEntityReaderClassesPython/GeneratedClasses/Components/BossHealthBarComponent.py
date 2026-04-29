from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class BossHealthBarComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    gui:NoitaBool = field(default_factory=NoitaBool)
    gui_special_final_boss:NoitaBool = field(default_factory=NoitaBool)
    in_world:NoitaBool = field(default_factory=NoitaBool)
    gui_max_distance_visible:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.gui.Read(s)
        self.gui_special_final_boss.Read(s)
        self.in_world.Read(s)
        self.gui_max_distance_visible.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.gui.Write(s)
        self.gui_special_final_boss.Write(s)
        self.in_world.Write(s)
        self.gui_max_distance_visible.Write(s)

