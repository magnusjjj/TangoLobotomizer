from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class PotionComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    spray_velocity_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    spray_velocity_normalized_min:NoitaFloat = field(default_factory=NoitaFloat)
    body_colored:NoitaBool = field(default_factory=NoitaBool)
    throw_bunch:NoitaBool = field(default_factory=NoitaBool)
    throw_how_many:NoitaInt = field(default_factory=NoitaInt)
    dont_spray_static_materials:NoitaBool = field(default_factory=NoitaBool)
    dont_spray_just_leak_gas_materials:NoitaBool = field(default_factory=NoitaBool)
    never_color:NoitaBool = field(default_factory=NoitaBool)
    custom_color_material:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.spray_velocity_coeff.Read(s)
        self.spray_velocity_normalized_min.Read(s)
        self.body_colored.Read(s)
        self.throw_bunch.Read(s)
        self.throw_how_many.Read(s)
        self.dont_spray_static_materials.Read(s)
        self.dont_spray_just_leak_gas_materials.Read(s)
        self.never_color.Read(s)
        self.custom_color_material.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.spray_velocity_coeff.Write(s)
        self.spray_velocity_normalized_min.Write(s)
        self.body_colored.Write(s)
        self.throw_bunch.Write(s)
        self.throw_how_many.Write(s)
        self.dont_spray_static_materials.Write(s)
        self.dont_spray_just_leak_gas_materials.Write(s)
        self.never_color.Write(s)
        self.custom_color_material.Write(s)

