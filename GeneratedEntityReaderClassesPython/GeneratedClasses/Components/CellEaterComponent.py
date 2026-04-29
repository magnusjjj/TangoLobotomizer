from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class CellEaterComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    radius:NoitaFloat = field(default_factory=NoitaFloat)
    eat_probability:NoitaInt = field(default_factory=NoitaInt)
    ignored_material:NoitaInt = field(default_factory=NoitaInt)
    only_stain:NoitaBool = field(default_factory=NoitaBool)
    eat_dynamic_physics_bodies:NoitaBool = field(default_factory=NoitaBool)
    limited_materials:NoitaBool = field(default_factory=NoitaBool)
    ignored_material_tag:NoitaString = field(default_factory=NoitaString)
    materials:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaInt))
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.radius.Read(s)
        self.eat_probability.Read(s)
        self.ignored_material.Read(s)
        self.only_stain.Read(s)
        self.eat_dynamic_physics_bodies.Read(s)
        self.limited_materials.Read(s)
        self.ignored_material_tag.Read(s)
        self.materials.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.radius.Write(s)
        self.eat_probability.Write(s)
        self.ignored_material.Write(s)
        self.only_stain.Write(s)
        self.eat_dynamic_physics_bodies.Write(s)
        self.limited_materials.Write(s)
        self.ignored_material_tag.Write(s)
        self.materials.Write(s)

