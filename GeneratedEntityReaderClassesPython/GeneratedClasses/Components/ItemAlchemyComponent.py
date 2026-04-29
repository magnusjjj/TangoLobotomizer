from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ItemAlchemyComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    material_make_always_cast:NoitaInt = field(default_factory=NoitaInt)
    material_remove_shuffle:NoitaInt = field(default_factory=NoitaInt)
    material_animate_wand:NoitaInt = field(default_factory=NoitaInt)
    material_animate_wand_alt:NoitaInt = field(default_factory=NoitaInt)
    material_increase_uses_remaining:NoitaInt = field(default_factory=NoitaInt)
    material_sacrifice:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.material_make_always_cast.Read(s)
        self.material_remove_shuffle.Read(s)
        self.material_animate_wand.Read(s)
        self.material_animate_wand_alt.Read(s)
        self.material_increase_uses_remaining.Read(s)
        self.material_sacrifice.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.material_make_always_cast.Write(s)
        self.material_remove_shuffle.Write(s)
        self.material_animate_wand.Write(s)
        self.material_animate_wand_alt.Write(s)
        self.material_increase_uses_remaining.Write(s)
        self.material_sacrifice.Write(s)

