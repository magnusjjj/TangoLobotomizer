namespace GeneratedNoitaClasses;
public class ConfigLaser :  iNoitaType<ConfigLaser>{
	public NoitaInt max_cell_durability_to_destroy { get; set; } = new();
	public NoitaUInt damage_to_cells { get; set; } = new();
	public NoitaFloat max_length { get; set; } = new();
	public NoitaFloat beam_radius { get; set; } = new();
	public NoitaInt beam_particle_chance { get; set; } = new();
	public NoitaFloat beam_particle_fade { get; set; } = new();
	public NoitaInt beam_particle_type { get; set; } = new();
	public NoitaBool beam_particle_fade_reverse { get; set; } = new();
	public NoitaInt hit_particle_chance { get; set; } = new();
	public NoitaBool audio_enabled { get; set; } = new();
	public NoitaBool audio_hit_always_enabled { get; set; } = new();
	public NoitaFloat damage_to_entities { get; set; } = new();
	public NoitaBool damage_apply_hitbox_dmg_multiplier { get; set; } = new();
	public NoitaBool root_entity_is_responsible_for_damage { get; set; } = new();

    public void Read(NoitaStream s){
		max_cell_durability_to_destroy.Read(s);
		damage_to_cells.Read(s);
		max_length.Read(s);
		beam_radius.Read(s);
		beam_particle_chance.Read(s);
		beam_particle_fade.Read(s);
		beam_particle_type.Read(s);
		beam_particle_fade_reverse.Read(s);
		hit_particle_chance.Read(s);
		audio_enabled.Read(s);
		audio_hit_always_enabled.Read(s);
		damage_to_entities.Read(s);
		damage_apply_hitbox_dmg_multiplier.Read(s);
		root_entity_is_responsible_for_damage.Read(s);

    }
    public void Write(NoitaStream s){
		max_cell_durability_to_destroy.Write(s);
		damage_to_cells.Write(s);
		max_length.Write(s);
		beam_radius.Write(s);
		beam_particle_chance.Write(s);
		beam_particle_fade.Write(s);
		beam_particle_type.Write(s);
		beam_particle_fade_reverse.Write(s);
		hit_particle_chance.Write(s);
		audio_enabled.Write(s);
		audio_hit_always_enabled.Write(s);
		damage_to_entities.Write(s);
		damage_apply_hitbox_dmg_multiplier.Write(s);
		root_entity_is_responsible_for_damage.Write(s);

    }
}