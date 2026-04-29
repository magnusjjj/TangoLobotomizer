from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaBool

from NoitaStream import NoitaStream
@dataclass
class ConfigLaser:
    max_cell_durability_to_destroy:NoitaInt = field(default_factory=NoitaInt)
    damage_to_cells:NoitaUInt = field(default_factory=NoitaUInt)
    max_length:NoitaFloat = field(default_factory=NoitaFloat)
    beam_radius:NoitaFloat = field(default_factory=NoitaFloat)
    beam_particle_chance:NoitaInt = field(default_factory=NoitaInt)
    beam_particle_fade:NoitaFloat = field(default_factory=NoitaFloat)
    beam_particle_type:NoitaInt = field(default_factory=NoitaInt)
    beam_particle_fade_reverse:NoitaBool = field(default_factory=NoitaBool)
    hit_particle_chance:NoitaInt = field(default_factory=NoitaInt)
    audio_enabled:NoitaBool = field(default_factory=NoitaBool)
    audio_hit_always_enabled:NoitaBool = field(default_factory=NoitaBool)
    damage_to_entities:NoitaFloat = field(default_factory=NoitaFloat)
    damage_apply_hitbox_dmg_multiplier:NoitaBool = field(default_factory=NoitaBool)
    root_entity_is_responsible_for_damage:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.max_cell_durability_to_destroy.Read(s)
        self.damage_to_cells.Read(s)
        self.max_length.Read(s)
        self.beam_radius.Read(s)
        self.beam_particle_chance.Read(s)
        self.beam_particle_fade.Read(s)
        self.beam_particle_type.Read(s)
        self.beam_particle_fade_reverse.Read(s)
        self.hit_particle_chance.Read(s)
        self.audio_enabled.Read(s)
        self.audio_hit_always_enabled.Read(s)
        self.damage_to_entities.Read(s)
        self.damage_apply_hitbox_dmg_multiplier.Read(s)
        self.root_entity_is_responsible_for_damage.Read(s)
    
    def Write(self, s:NoitaStream):
        self.max_cell_durability_to_destroy.Write(s)
        self.damage_to_cells.Write(s)
        self.max_length.Write(s)
        self.beam_radius.Write(s)
        self.beam_particle_chance.Write(s)
        self.beam_particle_fade.Write(s)
        self.beam_particle_type.Write(s)
        self.beam_particle_fade_reverse.Write(s)
        self.hit_particle_chance.Write(s)
        self.audio_enabled.Write(s)
        self.audio_hit_always_enabled.Write(s)
        self.damage_to_entities.Write(s)
        self.damage_apply_hitbox_dmg_multiplier.Write(s)
        self.root_entity_is_responsible_for_damage.Write(s)

