from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class InventoryGuiComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    has_opened_inventory_edit:NoitaBool = field(default_factory=NoitaBool)
    wallet_money_target:NoitaInt = field(default_factory=NoitaInt)
    mDisplayFireRateWaitBar:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.has_opened_inventory_edit.Read(s)
        self.wallet_money_target.Read(s)
        self.mDisplayFireRateWaitBar.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.has_opened_inventory_edit.Write(s)
        self.wallet_money_target.Write(s)
        self.mDisplayFireRateWaitBar.Write(s)

