from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class HitEffectComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    condition_effect:NoitaUInt = field(default_factory=NoitaUInt)
    condition_status:NoitaUInt = field(default_factory=NoitaUInt)
    effect_hit:NoitaUInt = field(default_factory=NoitaUInt)
    value:NoitaInt = field(default_factory=NoitaInt)
    value_string:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.condition_effect.Read(s)
        self.condition_status.Read(s)
        self.effect_hit.Read(s)
        self.value.Read(s)
        self.value_string.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.condition_effect.Write(s)
        self.condition_status.Write(s)
        self.effect_hit.Write(s)
        self.value.Write(s)
        self.value_string.Write(s)

