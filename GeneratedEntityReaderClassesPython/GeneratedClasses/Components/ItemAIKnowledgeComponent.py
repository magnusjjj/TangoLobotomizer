from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ItemAIKnowledgeComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    is_ranged_weapon:NoitaBool = field(default_factory=NoitaBool)
    is_throwable_weapon:NoitaBool = field(default_factory=NoitaBool)
    is_melee_weapon:NoitaBool = field(default_factory=NoitaBool)
    is_self_healing:NoitaBool = field(default_factory=NoitaBool)
    is_other_healing:NoitaBool = field(default_factory=NoitaBool)
    is_self_buffing:NoitaBool = field(default_factory=NoitaBool)
    is_other_buffing:NoitaBool = field(default_factory=NoitaBool)
    is_weapon:NoitaBool = field(default_factory=NoitaBool)
    is_known:NoitaBool = field(default_factory=NoitaBool)
    is_safe:NoitaBool = field(default_factory=NoitaBool)
    is_consumed:NoitaBool = field(default_factory=NoitaBool)
    never_use:NoitaBool = field(default_factory=NoitaBool)
    ranged_min_distance:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.is_ranged_weapon.Read(s)
        self.is_throwable_weapon.Read(s)
        self.is_melee_weapon.Read(s)
        self.is_self_healing.Read(s)
        self.is_other_healing.Read(s)
        self.is_self_buffing.Read(s)
        self.is_other_buffing.Read(s)
        self.is_weapon.Read(s)
        self.is_known.Read(s)
        self.is_safe.Read(s)
        self.is_consumed.Read(s)
        self.never_use.Read(s)
        self.ranged_min_distance.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.is_ranged_weapon.Write(s)
        self.is_throwable_weapon.Write(s)
        self.is_melee_weapon.Write(s)
        self.is_self_healing.Write(s)
        self.is_other_healing.Write(s)
        self.is_self_buffing.Write(s)
        self.is_other_buffing.Write(s)
        self.is_weapon.Write(s)
        self.is_known.Write(s)
        self.is_safe.Write(s)
        self.is_consumed.Write(s)
        self.never_use.Write(s)
        self.ranged_min_distance.Write(s)

