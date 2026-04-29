from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class SineWaveComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    sinewave_freq:NoitaFloat = field(default_factory=NoitaFloat)
    sinewave_m:NoitaFloat = field(default_factory=NoitaFloat)
    lifetime:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.sinewave_freq.Read(s)
        self.sinewave_m.Read(s)
        self.lifetime.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.sinewave_freq.Write(s)
        self.sinewave_m.Write(s)
        self.lifetime.Write(s)

