from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class ceng_CColorFloat:
    r:NoitaFloat = field(default_factory=NoitaFloat)
    g:NoitaFloat = field(default_factory=NoitaFloat)
    b:NoitaFloat = field(default_factory=NoitaFloat)
    a:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.r.Read(s)
        self.g.Read(s)
        self.b.Read(s)
        self.a.Read(s)
    
    def Write(self, s:NoitaStream):
        self.r.Write(s)
        self.g.Write(s)
        self.b.Write(s)
        self.a.Write(s)

