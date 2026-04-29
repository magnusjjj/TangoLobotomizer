from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class EnergyShieldComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    damage_multiplier:NoitaFloat = field(default_factory=NoitaFloat)
    max_energy:NoitaFloat = field(default_factory=NoitaFloat)
    energy_required_to_shield:NoitaFloat = field(default_factory=NoitaFloat)
    recharge_speed:NoitaFloat = field(default_factory=NoitaFloat)
    sector_degrees:NoitaFloat = field(default_factory=NoitaFloat)
    energy:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.damage_multiplier.Read(s)
        self.max_energy.Read(s)
        self.energy_required_to_shield.Read(s)
        self.recharge_speed.Read(s)
        self.sector_degrees.Read(s)
        self.energy.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.damage_multiplier.Write(s)
        self.max_energy.Write(s)
        self.energy_required_to_shield.Write(s)
        self.recharge_speed.Write(s)
        self.sector_degrees.Write(s)
        self.energy.Write(s)

