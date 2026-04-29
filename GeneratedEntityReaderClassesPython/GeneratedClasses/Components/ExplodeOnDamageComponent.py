from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from GeneratedClasses.ConfigExplosion import ConfigExplosion

from NoitaStream import NoitaStream
@dataclass
class ExplodeOnDamageComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    explode_on_death_percent:NoitaFloat = field(default_factory=NoitaFloat)
    explode_on_damage_percent:NoitaFloat = field(default_factory=NoitaFloat)
    physics_body_modified_death_probability:NoitaFloat = field(default_factory=NoitaFloat)
    physics_body_destruction_required:NoitaFloat = field(default_factory=NoitaFloat)
    config_explosion:ConfigExplosion = field(default_factory=ConfigExplosion)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.explode_on_death_percent.Read(s)
        self.explode_on_damage_percent.Read(s)
        self.physics_body_modified_death_probability.Read(s)
        self.physics_body_destruction_required.Read(s)
        self.config_explosion.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.explode_on_death_percent.Write(s)
        self.explode_on_damage_percent.Write(s)
        self.physics_body_modified_death_probability.Write(s)
        self.physics_body_destruction_required.Write(s)
        self.config_explosion.Write(s)

