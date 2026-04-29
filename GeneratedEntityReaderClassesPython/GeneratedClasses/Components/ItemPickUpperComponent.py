from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ItemPickUpperComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    is_in_npc:NoitaBool = field(default_factory=NoitaBool)
    pick_up_any_item_buggy:NoitaBool = field(default_factory=NoitaBool)
    is_immune_to_kicks:NoitaBool = field(default_factory=NoitaBool)
    only_pick_this_entity:NoitaUInt = field(default_factory=NoitaUInt)
    drop_items_on_death:NoitaBool = field(default_factory=NoitaBool)
    mLatestItemOverlapInfoBoxPosition:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.is_in_npc.Read(s)
        self.pick_up_any_item_buggy.Read(s)
        self.is_immune_to_kicks.Read(s)
        self.only_pick_this_entity.Read(s)
        self.drop_items_on_death.Read(s)
        self.mLatestItemOverlapInfoBoxPosition.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.is_in_npc.Write(s)
        self.pick_up_any_item_buggy.Write(s)
        self.is_immune_to_kicks.Write(s)
        self.only_pick_this_entity.Write(s)
        self.drop_items_on_death.Write(s)
        self.mLatestItemOverlapInfoBoxPosition.Write(s)

