from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ValueRangeInt:
    min:NoitaInt = field(default_factory=NoitaInt)
    max:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.min.Read(s)
        self.max.Read(s)
    
    def Write(self, s:NoitaStream):
        self.min.Write(s)
        self.max.Write(s)

