namespace GeneratedNoitaClasses;
public class ConfigLaser {
	public Int32 max_cell_durability_to_destroy { get; set; }
	public UInt32 damage_to_cells { get; set; }
	public float max_length { get; set; }
	public float beam_radius { get; set; }
	public Int32 beam_particle_chance { get; set; }
	public float beam_particle_fade { get; set; }
	public Int32 beam_particle_type { get; set; }
	public bool beam_particle_fade_reverse { get; set; }
	public Int32 hit_particle_chance { get; set; }
	public bool audio_enabled { get; set; }
	public bool audio_hit_always_enabled { get; set; }
	public float damage_to_entities { get; set; }
	public bool damage_apply_hitbox_dmg_multiplier { get; set; }
	public bool root_entity_is_responsible_for_damage { get; set; }

    public void Load(NoitaStream s){
		max_cell_durability_to_destroy = s.ReadBeInt32();
		damage_to_cells = s.ReadBeUInt32();
		max_length = s.ReadBeFloat();
		beam_radius = s.ReadBeFloat();
		beam_particle_chance = s.ReadBeInt32();
		beam_particle_fade = s.ReadBeFloat();
		beam_particle_type = s.ReadBeInt32();
		beam_particle_fade_reverse = s.ReadBool();
		hit_particle_chance = s.ReadBeInt32();
		audio_enabled = s.ReadBool();
		audio_hit_always_enabled = s.ReadBool();
		damage_to_entities = s.ReadBeFloat();
		damage_apply_hitbox_dmg_multiplier = s.ReadBool();
		root_entity_is_responsible_for_damage = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(max_cell_durability_to_destroy);
		s.WriteBeUInt32(damage_to_cells);
		s.WriteBeFloat(max_length);
		s.WriteBeFloat(beam_radius);
		s.WriteBeInt32(beam_particle_chance);
		s.WriteBeFloat(beam_particle_fade);
		s.WriteBeInt32(beam_particle_type);
		s.WriteBool(beam_particle_fade_reverse);
		s.WriteBeInt32(hit_particle_chance);
		s.WriteBool(audio_enabled);
		s.WriteBool(audio_hit_always_enabled);
		s.WriteBeFloat(damage_to_entities);
		s.WriteBool(damage_apply_hitbox_dmg_multiplier);
		s.WriteBool(root_entity_is_responsible_for_damage);

    }
}