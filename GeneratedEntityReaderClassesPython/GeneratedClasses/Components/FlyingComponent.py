from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class FlyingComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    type:NoitaInt = field(default_factory=NoitaInt)
    perlin_freq:NoitaFloat = field(default_factory=NoitaFloat)
    perlin_time_freq:NoitaFloat = field(default_factory=NoitaFloat)
    perlin_wind_x:NoitaFloat = field(default_factory=NoitaFloat)
    perlin_wind_y:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.type.Read(s)
        self.perlin_freq.Read(s)
        self.perlin_time_freq.Read(s)
        self.perlin_wind_x.Read(s)
        self.perlin_wind_y.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.type.Write(s)
        self.perlin_freq.Write(s)
        self.perlin_time_freq.Write(s)
        self.perlin_wind_x.Write(s)
        self.perlin_wind_y.Write(s)

