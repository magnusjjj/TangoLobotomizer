from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class HitboxComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    is_player:NoitaBool = field(default_factory=NoitaBool)
    is_enemy:NoitaBool = field(default_factory=NoitaBool)
    is_item:NoitaBool = field(default_factory=NoitaBool)
    aabb_min_x:NoitaFloat = field(default_factory=NoitaFloat)
    aabb_max_x:NoitaFloat = field(default_factory=NoitaFloat)
    aabb_min_y:NoitaFloat = field(default_factory=NoitaFloat)
    aabb_max_y:NoitaFloat = field(default_factory=NoitaFloat)
    offset:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    damage_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.is_player.Read(s)
        self.is_enemy.Read(s)
        self.is_item.Read(s)
        self.aabb_min_x.Read(s)
        self.aabb_max_x.Read(s)
        self.aabb_min_y.Read(s)
        self.aabb_max_y.Read(s)
        self.offset.Read(s)
        self.damage_multiplier.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.is_player.Write(s)
        self.is_enemy.Write(s)
        self.is_item.Write(s)
        self.aabb_min_x.Write(s)
        self.aabb_max_x.Write(s)
        self.aabb_min_y.Write(s)
        self.aabb_max_y.Write(s)
        self.offset.Write(s)
        self.damage_multiplier.Write(s)

