from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaUInt
from GeneratedClasses.ConfigExplosion import ConfigExplosion
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ExplosionComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    trigger:NoitaUInt = field(default_factory=NoitaUInt)
    config_explosion:ConfigExplosion = field(default_factory=ConfigExplosion)
    timeout_frames:NoitaInt = field(default_factory=NoitaInt)
    timeout_frames_random:NoitaInt = field(default_factory=NoitaInt)
    kill_entity:NoitaBool = field(default_factory=NoitaBool)
    mTimerTriggerFrame:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.trigger.Read(s)
        self.config_explosion.Read(s)
        self.timeout_frames.Read(s)
        self.timeout_frames_random.Read(s)
        self.kill_entity.Read(s)
        self.mTimerTriggerFrame.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.trigger.Write(s)
        self.config_explosion.Write(s)
        self.timeout_frames.Write(s)
        self.timeout_frames_random.Write(s)
        self.kill_entity.Write(s)
        self.mTimerTriggerFrame.Write(s)

