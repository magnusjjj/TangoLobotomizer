from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class VariableStorageComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    name:NoitaString = field(default_factory=NoitaString)
    value_string:NoitaString = field(default_factory=NoitaString)
    value_int:NoitaInt = field(default_factory=NoitaInt)
    value_bool:NoitaBool = field(default_factory=NoitaBool)
    value_float:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.name.Read(s)
        self.value_string.Read(s)
        self.value_int.Read(s)
        self.value_bool.Read(s)
        self.value_float.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.name.Write(s)
        self.value_string.Write(s)
        self.value_int.Write(s)
        self.value_bool.Write(s)
        self.value_float.Write(s)

