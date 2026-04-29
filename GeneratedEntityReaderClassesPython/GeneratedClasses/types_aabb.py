from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class types_aabb:
    min:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    max:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    
    def Read(self, s:NoitaStream):
        self.min.Read(s)
        self.max.Read(s)
    
    def Write(self, s:NoitaStream):
        self.min.Write(s)
        self.max.Write(s)

