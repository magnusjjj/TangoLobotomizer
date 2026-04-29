from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class StatusEffectDataComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    stain_effects:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaFloat))
    stain_effect_cooldowns:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaInt))
    effects_previous:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaFloat))
    ingestion_effects:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaFloat))
    ingestion_effect_causes:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaInt))
    ingestion_effect_causes_many:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaInt))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.stain_effects.Read(s)
        self.stain_effect_cooldowns.Read(s)
        self.effects_previous.Read(s)
        self.ingestion_effects.Read(s)
        self.ingestion_effect_causes.Read(s)
        self.ingestion_effect_causes_many.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.stain_effects.Write(s)
        self.stain_effect_cooldowns.Write(s)
        self.effects_previous.Write(s)
        self.ingestion_effects.Write(s)
        self.ingestion_effect_causes.Write(s)
        self.ingestion_effect_causes_many.Write(s)

