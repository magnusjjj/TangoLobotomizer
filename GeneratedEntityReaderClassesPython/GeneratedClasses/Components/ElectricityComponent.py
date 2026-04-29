from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ElectricityComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    energy:NoitaInt = field(default_factory=NoitaInt)
    probability_to_heat:NoitaFloat = field(default_factory=NoitaFloat)
    speed:NoitaInt = field(default_factory=NoitaInt)
    splittings_min:NoitaInt = field(default_factory=NoitaInt)
    splittings_max:NoitaInt = field(default_factory=NoitaInt)
    splitting_energy_min:NoitaInt = field(default_factory=NoitaInt)
    splitting_energy_max:NoitaInt = field(default_factory=NoitaInt)
    hack_is_material_crack:NoitaBool = field(default_factory=NoitaBool)
    hack_crack_ice:NoitaBool = field(default_factory=NoitaBool)
    hack_is_set_fire:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.energy.Read(s)
        self.probability_to_heat.Read(s)
        self.speed.Read(s)
        self.splittings_min.Read(s)
        self.splittings_max.Read(s)
        self.splitting_energy_min.Read(s)
        self.splitting_energy_max.Read(s)
        self.hack_is_material_crack.Read(s)
        self.hack_crack_ice.Read(s)
        self.hack_is_set_fire.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.energy.Write(s)
        self.probability_to_heat.Write(s)
        self.speed.Write(s)
        self.splittings_min.Write(s)
        self.splittings_max.Write(s)
        self.splitting_energy_min.Write(s)
        self.splitting_energy_max.Write(s)
        self.hack_is_material_crack.Write(s)
        self.hack_crack_ice.Write(s)
        self.hack_is_set_fire.Write(s)

