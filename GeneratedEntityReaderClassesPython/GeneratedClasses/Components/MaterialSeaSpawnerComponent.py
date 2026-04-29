from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaDouble

from NoitaStream import NoitaStream
@dataclass
class MaterialSeaSpawnerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    material:NoitaInt = field(default_factory=NoitaInt)
    size:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    offset:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    speed:NoitaInt = field(default_factory=NoitaInt)
    sine_wavelength:NoitaFloat = field(default_factory=NoitaFloat)
    sine_amplitude:NoitaFloat = field(default_factory=NoitaFloat)
    noise_scale:NoitaDouble = field(default_factory=NoitaDouble)
    noise_threshold:NoitaDouble = field(default_factory=NoitaDouble)
    m_position:NoitaInt = field(default_factory=NoitaInt)
    frames_run:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.material.Read(s)
        self.size.Read(s)
        self.offset.Read(s)
        self.speed.Read(s)
        self.sine_wavelength.Read(s)
        self.sine_amplitude.Read(s)
        self.noise_scale.Read(s)
        self.noise_threshold.Read(s)
        self.m_position.Read(s)
        self.frames_run.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.material.Write(s)
        self.size.Write(s)
        self.offset.Write(s)
        self.speed.Write(s)
        self.sine_wavelength.Write(s)
        self.sine_amplitude.Write(s)
        self.noise_scale.Write(s)
        self.noise_threshold.Write(s)
        self.m_position.Write(s)
        self.frames_run.Write(s)

