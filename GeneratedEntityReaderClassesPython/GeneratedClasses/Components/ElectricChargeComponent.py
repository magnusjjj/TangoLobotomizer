from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ElectricChargeComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    charge_time_frames:NoitaInt = field(default_factory=NoitaInt)
    fx_velocity_max:NoitaFloat = field(default_factory=NoitaFloat)
    electricity_emission_interval_frames:NoitaInt = field(default_factory=NoitaInt)
    fx_emission_interval_min:NoitaInt = field(default_factory=NoitaInt)
    fx_emission_interval_max:NoitaInt = field(default_factory=NoitaInt)
    charge:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.charge_time_frames.Read(s)
        self.fx_velocity_max.Read(s)
        self.electricity_emission_interval_frames.Read(s)
        self.fx_emission_interval_min.Read(s)
        self.fx_emission_interval_max.Read(s)
        self.charge.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.charge_time_frames.Write(s)
        self.fx_velocity_max.Write(s)
        self.electricity_emission_interval_frames.Write(s)
        self.fx_emission_interval_min.Write(s)
        self.fx_emission_interval_max.Write(s)
        self.charge.Write(s)

