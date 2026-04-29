from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from GeneratedClasses.types_iaabb import types_iaabb

from NoitaStream import NoitaStream
@dataclass
class MaterialSuckerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    material_type:NoitaInt = field(default_factory=NoitaInt)
    barrel_size:NoitaInt = field(default_factory=NoitaInt)
    num_cells_sucked_per_frame:NoitaInt = field(default_factory=NoitaInt)
    set_projectile_to_liquid:NoitaBool = field(default_factory=NoitaBool)
    last_material_id:NoitaInt = field(default_factory=NoitaInt)
    suck_gold:NoitaBool = field(default_factory=NoitaBool)
    suck_health:NoitaBool = field(default_factory=NoitaBool)
    suck_static_materials:NoitaBool = field(default_factory=NoitaBool)
    suck_tag:NoitaString = field(default_factory=NoitaString)
    randomized_position:types_iaabb = field(default_factory=types_iaabb)
    mAmountUsed:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.material_type.Read(s)
        self.barrel_size.Read(s)
        self.num_cells_sucked_per_frame.Read(s)
        self.set_projectile_to_liquid.Read(s)
        self.last_material_id.Read(s)
        self.suck_gold.Read(s)
        self.suck_health.Read(s)
        self.suck_static_materials.Read(s)
        self.suck_tag.Read(s)
        self.randomized_position.Read(s)
        self.mAmountUsed.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.material_type.Write(s)
        self.barrel_size.Write(s)
        self.num_cells_sucked_per_frame.Write(s)
        self.set_projectile_to_liquid.Write(s)
        self.last_material_id.Write(s)
        self.suck_gold.Write(s)
        self.suck_health.Write(s)
        self.suck_static_materials.Write(s)
        self.suck_tag.Write(s)
        self.randomized_position.Write(s)
        self.mAmountUsed.Write(s)

