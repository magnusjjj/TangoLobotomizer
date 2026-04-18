namespace GeneratedNoitaClasses;
public class MaterialInventoryComponent : NoitaComponentBase,  iNoitaType<MaterialInventoryComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool drop_as_item { get; set; } = new();
	public NoitaBool on_death_spill { get; set; } = new();
	public NoitaBool leak_gently { get; set; } = new();
	public NoitaFloat leak_on_damage_percent { get; set; } = new();
	public NoitaFloat leak_pressure_min { get; set; } = new();
	public NoitaFloat leak_pressure_max { get; set; } = new();
	public NoitaFloat min_damage_to_leak { get; set; } = new();
	public NoitaFloat b2_force_on_leak { get; set; } = new();
	public NoitaFloat death_throw_particle_velocity_coeff { get; set; } = new();
	public NoitaBool kill_when_empty { get; set; } = new();
	public NoitaBool halftime_materials { get; set; } = new();
	public NoitaInt do_reactions { get; set; } = new();
	public NoitaBool do_reactions_explosions { get; set; } = new();
	public NoitaBool do_reactions_entities { get; set; } = new();
	public NoitaInt reaction_speed { get; set; } = new();
	public NoitaBool reactions_shaking_speeds_up { get; set; } = new();
	public NoitaDouble max_capacity { get; set; } = new();
	public NoitaVector<NoitaDouble> count_per_material_type { get; set; } = new();
	public NoitaFloat audio_collision_size_modifier_amount { get; set; } = new();
	public NoitaInt last_frame_drank { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		drop_as_item.Read(s);
		on_death_spill.Read(s);
		leak_gently.Read(s);
		leak_on_damage_percent.Read(s);
		leak_pressure_min.Read(s);
		leak_pressure_max.Read(s);
		min_damage_to_leak.Read(s);
		b2_force_on_leak.Read(s);
		death_throw_particle_velocity_coeff.Read(s);
		kill_when_empty.Read(s);
		halftime_materials.Read(s);
		do_reactions.Read(s);
		do_reactions_explosions.Read(s);
		do_reactions_entities.Read(s);
		reaction_speed.Read(s);
		reactions_shaking_speeds_up.Read(s);
		max_capacity.Read(s);
		count_per_material_type.Read(s);
		audio_collision_size_modifier_amount.Read(s);
		last_frame_drank.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		drop_as_item.Write(s);
		on_death_spill.Write(s);
		leak_gently.Write(s);
		leak_on_damage_percent.Write(s);
		leak_pressure_min.Write(s);
		leak_pressure_max.Write(s);
		min_damage_to_leak.Write(s);
		b2_force_on_leak.Write(s);
		death_throw_particle_velocity_coeff.Write(s);
		kill_when_empty.Write(s);
		halftime_materials.Write(s);
		do_reactions.Write(s);
		do_reactions_explosions.Write(s);
		do_reactions_entities.Write(s);
		reaction_speed.Write(s);
		reactions_shaking_speeds_up.Write(s);
		max_capacity.Write(s);
		count_per_material_type.Write(s);
		audio_collision_size_modifier_amount.Write(s);
		last_frame_drank.Write(s);

    }
}