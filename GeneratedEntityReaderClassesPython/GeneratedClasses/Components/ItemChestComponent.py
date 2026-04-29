from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaUInt

from NoitaStream import NoitaStream
@dataclass
class ItemChestComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    item_count_min:NoitaInt = field(default_factory=NoitaInt)
    item_count_max:NoitaInt = field(default_factory=NoitaInt)
    level:NoitaInt = field(default_factory=NoitaInt)
    enemy_drop:NoitaBool = field(default_factory=NoitaBool)
    actions:NoitaString = field(default_factory=NoitaString)
    action_uses_remaining:NoitaString = field(default_factory=NoitaString)
    other_entities_to_spawn:NoitaString = field(default_factory=NoitaString)
    mSeed:NoitaUInt = field(default_factory=NoitaUInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.item_count_min.Read(s)
        self.item_count_max.Read(s)
        self.level.Read(s)
        self.enemy_drop.Read(s)
        self.actions.Read(s)
        self.action_uses_remaining.Read(s)
        self.other_entities_to_spawn.Read(s)
        self.mSeed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.item_count_min.Write(s)
        self.item_count_max.Write(s)
        self.level.Write(s)
        self.enemy_drop.Write(s)
        self.actions.Write(s)
        self.action_uses_remaining.Write(s)
        self.other_entities_to_spawn.Write(s)
        self.mSeed.Write(s)

