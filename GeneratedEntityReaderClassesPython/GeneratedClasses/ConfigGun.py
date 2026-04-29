from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaBool

from NoitaStream import NoitaStream
@dataclass
class ConfigGun:
    actions_per_round:NoitaInt = field(default_factory=NoitaInt)
    shuffle_deck_when_empty:NoitaBool = field(default_factory=NoitaBool)
    reload_time:NoitaInt = field(default_factory=NoitaInt)
    deck_capacity:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.actions_per_round.Read(s)
        self.shuffle_deck_when_empty.Read(s)
        self.reload_time.Read(s)
        self.deck_capacity.Read(s)
    
    def Write(self, s:NoitaStream):
        self.actions_per_round.Write(s)
        self.shuffle_deck_when_empty.Write(s)
        self.reload_time.Write(s)
        self.deck_capacity.Write(s)

