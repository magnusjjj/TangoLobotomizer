from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class BlackHoleComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    particle_attractor_force:NoitaFloat = field(default_factory=NoitaFloat)
    damage_probability:NoitaFloat = field(default_factory=NoitaFloat)
    damage_amount:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.particle_attractor_force.Read(s)
        self.damage_probability.Read(s)
        self.damage_amount.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.particle_attractor_force.Write(s)
        self.damage_probability.Write(s)
        self.damage_amount.Write(s)

