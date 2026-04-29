from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaLensValue
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class SpriteStainsComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    sprite_id:NoitaInt = field(default_factory=NoitaInt)
    fade_stains_towards_srite_top:NoitaBool = field(default_factory=NoitaBool)
    stain_shaken_drop_chance_multiplier:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaInt))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.sprite_id.Read(s)
        self.fade_stains_towards_srite_top.Read(s)
        self.stain_shaken_drop_chance_multiplier.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.sprite_id.Write(s)
        self.fade_stains_towards_srite_top.Write(s)
        self.stain_shaken_drop_chance_multiplier.Write(s)

