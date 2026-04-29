from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaDouble
from BasicNoitaTypes import NoitaVector
from BasicNoitaTypes import NoitaDouble

from NoitaStream import NoitaStream
@dataclass
class MaterialInventoryComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    drop_as_item:NoitaBool = field(default_factory=NoitaBool)
    on_death_spill:NoitaBool = field(default_factory=NoitaBool)
    leak_gently:NoitaBool = field(default_factory=NoitaBool)
    leak_on_damage_percent:NoitaFloat = field(default_factory=NoitaFloat)
    leak_pressure_min:NoitaFloat = field(default_factory=NoitaFloat)
    leak_pressure_max:NoitaFloat = field(default_factory=NoitaFloat)
    min_damage_to_leak:NoitaFloat = field(default_factory=NoitaFloat)
    b2_force_on_leak:NoitaFloat = field(default_factory=NoitaFloat)
    death_throw_particle_velocity_coeff:NoitaFloat = field(default_factory=NoitaFloat)
    kill_when_empty:NoitaBool = field(default_factory=NoitaBool)
    halftime_materials:NoitaBool = field(default_factory=NoitaBool)
    do_reactions:NoitaInt = field(default_factory=NoitaInt)
    do_reactions_explosions:NoitaBool = field(default_factory=NoitaBool)
    do_reactions_entities:NoitaBool = field(default_factory=NoitaBool)
    reaction_speed:NoitaInt = field(default_factory=NoitaInt)
    reactions_shaking_speeds_up:NoitaBool = field(default_factory=NoitaBool)
    max_capacity:NoitaDouble = field(default_factory=NoitaDouble)
    count_per_material_type:NoitaVector = field(default_factory=lambda: NoitaVector(NoitaDouble))
    audio_collision_size_modifier_amount:NoitaFloat = field(default_factory=NoitaFloat)
    last_frame_drank:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.drop_as_item.Read(s)
        self.on_death_spill.Read(s)
        self.leak_gently.Read(s)
        self.leak_on_damage_percent.Read(s)
        self.leak_pressure_min.Read(s)
        self.leak_pressure_max.Read(s)
        self.min_damage_to_leak.Read(s)
        self.b2_force_on_leak.Read(s)
        self.death_throw_particle_velocity_coeff.Read(s)
        self.kill_when_empty.Read(s)
        self.halftime_materials.Read(s)
        self.do_reactions.Read(s)
        self.do_reactions_explosions.Read(s)
        self.do_reactions_entities.Read(s)
        self.reaction_speed.Read(s)
        self.reactions_shaking_speeds_up.Read(s)
        self.max_capacity.Read(s)
        self.count_per_material_type.Read(s)
        self.audio_collision_size_modifier_amount.Read(s)
        self.last_frame_drank.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.drop_as_item.Write(s)
        self.on_death_spill.Write(s)
        self.leak_gently.Write(s)
        self.leak_on_damage_percent.Write(s)
        self.leak_pressure_min.Write(s)
        self.leak_pressure_max.Write(s)
        self.min_damage_to_leak.Write(s)
        self.b2_force_on_leak.Write(s)
        self.death_throw_particle_velocity_coeff.Write(s)
        self.kill_when_empty.Write(s)
        self.halftime_materials.Write(s)
        self.do_reactions.Write(s)
        self.do_reactions_explosions.Write(s)
        self.do_reactions_entities.Write(s)
        self.reaction_speed.Write(s)
        self.reactions_shaking_speeds_up.Write(s)
        self.max_capacity.Write(s)
        self.count_per_material_type.Write(s)
        self.audio_collision_size_modifier_amount.Write(s)
        self.last_frame_drank.Write(s)

