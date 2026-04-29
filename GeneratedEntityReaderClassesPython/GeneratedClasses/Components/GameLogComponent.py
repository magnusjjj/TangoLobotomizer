from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class GameLogComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    report_death:NoitaBool = field(default_factory=NoitaBool)
    report_damage:NoitaBool = field(default_factory=NoitaBool)
    report_new_biomes:NoitaBool = field(default_factory=NoitaBool)
    mVisitiedBiomes:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaString))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.report_death.Read(s)
        self.report_damage.Read(s)
        self.report_new_biomes.Read(s)
        self.mVisitiedBiomes.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.report_death.Write(s)
        self.report_damage.Write(s)
        self.report_new_biomes.Write(s)
        self.mVisitiedBiomes.Write(s)

