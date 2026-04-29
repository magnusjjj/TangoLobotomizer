from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ConfigDrugFx:
    distortion_amount:NoitaFloat = field(default_factory=NoitaFloat)
    color_amount:NoitaFloat = field(default_factory=NoitaFloat)
    fractals_amount:NoitaFloat = field(default_factory=NoitaFloat)
    fractals_size:NoitaFloat = field(default_factory=NoitaFloat)
    nightvision_amount:NoitaFloat = field(default_factory=NoitaFloat)
    doublevision_amount:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.distortion_amount.Read(s)
        self.color_amount.Read(s)
        self.fractals_amount.Read(s)
        self.fractals_size.Read(s)
        self.nightvision_amount.Read(s)
        self.doublevision_amount.Read(s)
    
    def Write(self, s:NoitaStream):
        self.distortion_amount.Write(s)
        self.color_amount.Write(s)
        self.fractals_amount.Write(s)
        self.fractals_size.Write(s)
        self.nightvision_amount.Write(s)
        self.doublevision_amount.Write(s)

