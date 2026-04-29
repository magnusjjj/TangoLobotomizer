from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ConfigDamagesByType:
    melee:NoitaFloat = field(default_factory=NoitaFloat)
    projectile:NoitaFloat = field(default_factory=NoitaFloat)
    explosion:NoitaFloat = field(default_factory=NoitaFloat)
    electricity:NoitaFloat = field(default_factory=NoitaFloat)
    fire:NoitaFloat = field(default_factory=NoitaFloat)
    drill:NoitaFloat = field(default_factory=NoitaFloat)
    slice:NoitaFloat = field(default_factory=NoitaFloat)
    ice:NoitaFloat = field(default_factory=NoitaFloat)
    healing:NoitaFloat = field(default_factory=NoitaFloat)
    physics_hit:NoitaFloat = field(default_factory=NoitaFloat)
    radioactive:NoitaFloat = field(default_factory=NoitaFloat)
    poison:NoitaFloat = field(default_factory=NoitaFloat)
    overeating:NoitaFloat = field(default_factory=NoitaFloat)
    curse:NoitaFloat = field(default_factory=NoitaFloat)
    holy:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.melee.Read(s)
        self.projectile.Read(s)
        self.explosion.Read(s)
        self.electricity.Read(s)
        self.fire.Read(s)
        self.drill.Read(s)
        self.slice.Read(s)
        self.ice.Read(s)
        self.healing.Read(s)
        self.physics_hit.Read(s)
        self.radioactive.Read(s)
        self.poison.Read(s)
        self.overeating.Read(s)
        self.curse.Read(s)
        self.holy.Read(s)
    
    def Write(self, s:NoitaStream):
        self.melee.Write(s)
        self.projectile.Write(s)
        self.explosion.Write(s)
        self.electricity.Write(s)
        self.fire.Write(s)
        self.drill.Write(s)
        self.slice.Write(s)
        self.ice.Write(s)
        self.healing.Write(s)
        self.physics_hit.Write(s)
        self.radioactive.Write(s)
        self.poison.Write(s)
        self.overeating.Write(s)
        self.curse.Write(s)
        self.holy.Write(s)

