from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ValueRange:
    min:NoitaFloat = field(default_factory=NoitaFloat)
    max:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.min.Read(s)
        self.max.Read(s)
    
    def Write(self, s:NoitaStream):
        self.min.Write(s)
        self.max.Write(s)

