from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from GeneratedClasses.ConfigLaser import ConfigLaser
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class LaserEmitterComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    laser:ConfigLaser = field(default_factory=ConfigLaser)
    is_emitting:NoitaBool = field(default_factory=NoitaBool)
    emit_until_frame:NoitaInt = field(default_factory=NoitaInt)
    laser_angle_add_rad:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.laser.Read(s)
        self.is_emitting.Read(s)
        self.emit_until_frame.Read(s)
        self.laser_angle_add_rad.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.laser.Write(s)
        self.is_emitting.Write(s)
        self.emit_until_frame.Write(s)
        self.laser_angle_add_rad.Write(s)

