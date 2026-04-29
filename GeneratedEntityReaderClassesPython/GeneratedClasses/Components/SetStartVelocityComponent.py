from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat
from GeneratedClasses.ValueRange import ValueRange

from NoitaStream import NoitaStream
@dataclass
class SetStartVelocityComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    velocity:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    randomize_angle:ValueRange = field(default_factory=ValueRange)
    randomize_speed:ValueRange = field(default_factory=ValueRange)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.velocity.Read(s)
        self.randomize_angle.Read(s)
        self.randomize_speed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.velocity.Write(s)
        self.randomize_angle.Write(s)
        self.randomize_speed.Write(s)

