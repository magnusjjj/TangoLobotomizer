from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class AltarComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    recognized_entity_tags:NoitaString = field(default_factory=NoitaString)
    good_fx_material:NoitaInt = field(default_factory=NoitaInt)
    neutral_fx_material:NoitaInt = field(default_factory=NoitaInt)
    evil_fx_material:NoitaInt = field(default_factory=NoitaInt)
    uses_remaining:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.recognized_entity_tags.Read(s)
        self.good_fx_material.Read(s)
        self.neutral_fx_material.Read(s)
        self.evil_fx_material.Read(s)
        self.uses_remaining.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.recognized_entity_tags.Write(s)
        self.good_fx_material.Write(s)
        self.neutral_fx_material.Write(s)
        self.evil_fx_material.Write(s)
        self.uses_remaining.Write(s)

