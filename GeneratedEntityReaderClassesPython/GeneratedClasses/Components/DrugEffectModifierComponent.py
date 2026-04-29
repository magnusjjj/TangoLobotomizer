from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from GeneratedClasses.ConfigDrugFx import ConfigDrugFx

from NoitaStream import NoitaStream
@dataclass
class DrugEffectModifierComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    fx_add:ConfigDrugFx = field(default_factory=ConfigDrugFx)
    fx_multiply:ConfigDrugFx = field(default_factory=ConfigDrugFx)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.fx_add.Read(s)
        self.fx_multiply.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.fx_add.Write(s)
        self.fx_multiply.Write(s)

