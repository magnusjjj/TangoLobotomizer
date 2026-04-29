from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class types_iaabb:
    min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaInt))
    
    def Read(self, s:NoitaStream):
        self.min.Read(s)
        self.max.Read(s)
    
    def Write(self, s:NoitaStream):
        self.min.Write(s)
        self.max.Write(s)

