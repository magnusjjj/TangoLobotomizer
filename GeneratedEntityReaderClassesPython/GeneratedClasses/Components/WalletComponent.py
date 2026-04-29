from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt64

from NoitaStream import NoitaStream
@dataclass
class WalletComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    money:NoitaInt64 = field(default_factory=NoitaInt64)
    money_spent:NoitaInt64 = field(default_factory=NoitaInt64)
    mMoneyPrevFrame:NoitaInt64 = field(default_factory=NoitaInt64)
    mHasReachedInf:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.money.Read(s)
        self.money_spent.Read(s)
        self.mMoneyPrevFrame.Read(s)
        self.mHasReachedInf.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.money.Write(s)
        self.money_spent.Write(s)
        self.mMoneyPrevFrame.Write(s)
        self.mHasReachedInf.Write(s)

