from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class TeleportComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    target:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    target_x_is_absolute_position:NoitaBool = field(default_factory=NoitaBool)
    target_y_is_absolute_position:NoitaBool = field(default_factory=NoitaBool)
    source_particle_fx_file:NoitaString = field(default_factory=NoitaString)
    target_particle_fx_file:NoitaString = field(default_factory=NoitaString)
    load_collapse_entity:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.target.Read(s)
        self.target_x_is_absolute_position.Read(s)
        self.target_y_is_absolute_position.Read(s)
        self.source_particle_fx_file.Read(s)
        self.target_particle_fx_file.Read(s)
        self.load_collapse_entity.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.target.Write(s)
        self.target_x_is_absolute_position.Write(s)
        self.target_y_is_absolute_position.Write(s)
        self.source_particle_fx_file.Write(s)
        self.target_particle_fx_file.Write(s)
        self.load_collapse_entity.Write(s)

