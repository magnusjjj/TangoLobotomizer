from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class GameAreaEffectComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    collide_with_tag:NoitaString = field(default_factory=NoitaString)
    frame_length:NoitaInt = field(default_factory=NoitaInt)
    game_effect_entitities:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaString))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.collide_with_tag.Read(s)
        self.frame_length.Read(s)
        self.game_effect_entitities.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.collide_with_tag.Write(s)
        self.frame_length.Write(s)
        self.game_effect_entitities.Write(s)

