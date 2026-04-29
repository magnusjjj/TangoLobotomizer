from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ConfigDamageCritical:
    chance:NoitaInt = field(default_factory=NoitaInt)
    damage_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.chance.Read(s)
        self.damage_multiplier.Read(s)
    
    def Write(self, s:NoitaStream):
        self.chance.Write(s)
        self.damage_multiplier.Write(s)

