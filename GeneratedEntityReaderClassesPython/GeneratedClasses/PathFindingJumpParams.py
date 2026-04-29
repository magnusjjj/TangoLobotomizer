from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PathFindingJumpParams:
    x:NoitaFloat = field(default_factory=NoitaFloat)
    y:NoitaFloat = field(default_factory=NoitaFloat)
    lob:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.x.Read(s)
        self.y.Read(s)
        self.lob.Read(s)
    
    def Write(self, s:NoitaStream):
        self.x.Write(s)
        self.y.Write(s)
        self.lob.Write(s)

