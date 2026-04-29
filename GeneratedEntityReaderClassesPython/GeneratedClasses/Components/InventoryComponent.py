from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class InventoryComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    ui_container_type:NoitaInt = field(default_factory=NoitaInt)
    ui_container_size:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    ui_element_size:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    ui_position_on_screen:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    ui_element_sprite:NoitaString = field(default_factory=NoitaString)
    actions:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.ui_container_type.Read(s)
        self.ui_container_size.Read(s)
        self.ui_element_size.Read(s)
        self.ui_position_on_screen.Read(s)
        self.ui_element_sprite.Read(s)
        self.actions.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.ui_container_type.Write(s)
        self.ui_container_size.Write(s)
        self.ui_element_size.Write(s)
        self.ui_position_on_screen.Write(s)
        self.ui_element_sprite.Write(s)
        self.actions.Write(s)

