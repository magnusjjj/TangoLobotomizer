from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from GeneratedClasses.ConfigExplosion import ConfigExplosion
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class LightningComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    config_explosion:ConfigExplosion = field(default_factory=ConfigExplosion)
    sprite_lightning_file:NoitaString = field(default_factory=NoitaString)
    is_projectile:NoitaBool = field(default_factory=NoitaBool)
    explosion_type:NoitaInt = field(default_factory=NoitaInt)
    arc_lifetime:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.config_explosion.Read(s)
        self.sprite_lightning_file.Read(s)
        self.is_projectile.Read(s)
        self.explosion_type.Read(s)
        self.arc_lifetime.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.config_explosion.Write(s)
        self.sprite_lightning_file.Write(s)
        self.is_projectile.Write(s)
        self.explosion_type.Write(s)
        self.arc_lifetime.Write(s)

