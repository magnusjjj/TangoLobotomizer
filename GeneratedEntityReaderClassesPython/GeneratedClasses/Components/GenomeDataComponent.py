from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaLensValue
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class GenomeDataComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    herd_id:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaInt))
    is_predator:NoitaBool = field(default_factory=NoitaBool)
    food_chain_rank:NoitaFloat = field(default_factory=NoitaFloat)
    berserk_dont_attack_friends:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.herd_id.Read(s)
        self.is_predator.Read(s)
        self.food_chain_rank.Read(s)
        self.berserk_dont_attack_friends.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.herd_id.Write(s)
        self.is_predator.Write(s)
        self.food_chain_rank.Write(s)
        self.berserk_dont_attack_friends.Write(s)

