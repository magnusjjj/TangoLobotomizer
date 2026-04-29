from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaLensValue
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class KickComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    can_kick:NoitaBool = field(default_factory=NoitaBool)
    max_force:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaFloat))
    player_kickforce:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaFloat))
    kick_radius:NoitaFloat = field(default_factory=NoitaFloat)
    kick_damage:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaFloat))
    kick_knockback:NoitaLensValue = field(default_factory=lambda: NoitaLensValue(NoitaFloat))
    telekinesis_throw_speed:NoitaFloat = field(default_factory=NoitaFloat)
    kick_entities:NoitaString = field(default_factory=NoitaString)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.can_kick.Read(s)
        self.max_force.Read(s)
        self.player_kickforce.Read(s)
        self.kick_radius.Read(s)
        self.kick_damage.Read(s)
        self.kick_knockback.Read(s)
        self.telekinesis_throw_speed.Read(s)
        self.kick_entities.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.can_kick.Write(s)
        self.max_force.Write(s)
        self.player_kickforce.Write(s)
        self.kick_radius.Write(s)
        self.kick_damage.Write(s)
        self.kick_knockback.Write(s)
        self.telekinesis_throw_speed.Write(s)
        self.kick_entities.Write(s)

