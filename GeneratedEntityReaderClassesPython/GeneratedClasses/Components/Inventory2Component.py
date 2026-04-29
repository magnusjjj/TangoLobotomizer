from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class Inventory2Component:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    quick_inventory_slots:NoitaInt = field(default_factory=NoitaInt)
    full_inventory_slots_x:NoitaInt = field(default_factory=NoitaInt)
    full_inventory_slots_y:NoitaInt = field(default_factory=NoitaInt)
    mSavedActiveItemIndex:NoitaUInt = field(default_factory=NoitaUInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.quick_inventory_slots.Read(s)
        self.full_inventory_slots_x.Read(s)
        self.full_inventory_slots_y.Read(s)
        self.mSavedActiveItemIndex.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.quick_inventory_slots.Write(s)
        self.full_inventory_slots_x.Write(s)
        self.full_inventory_slots_y.Write(s)
        self.mSavedActiveItemIndex.Write(s)

