from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from GeneratedClasses.ConfigDrugFx import ConfigDrugFx

from NoitaStream import NoitaStream
@dataclass
class DrugEffectComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    drug_fx_target:ConfigDrugFx = field(default_factory=ConfigDrugFx)
    m_drug_fx_current:ConfigDrugFx = field(default_factory=ConfigDrugFx)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.drug_fx_target.Read(s)
        self.m_drug_fx_current.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.drug_fx_target.Write(s)
        self.m_drug_fx_current.Write(s)

