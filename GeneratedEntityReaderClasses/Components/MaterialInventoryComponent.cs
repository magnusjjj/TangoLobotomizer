namespace GeneratedNoitaClasses;
public class MaterialInventoryComponent {
	public bool drop_as_item { get; set; }
	public bool on_death_spill { get; set; }
	public bool leak_gently { get; set; }
	public float leak_on_damage_percent { get; set; }
	public float leak_pressure_min { get; set; }
	public float leak_pressure_max { get; set; }
	public float min_damage_to_leak { get; set; }
	public float b2_force_on_leak { get; set; }
	public float death_throw_particle_velocity_coeff { get; set; }
	public bool kill_when_empty { get; set; }
	public bool halftime_materials { get; set; }
	public Int32 do_reactions { get; set; }
	public bool do_reactions_explosions { get; set; }
	public bool do_reactions_entities { get; set; }
	public Int32 reaction_speed { get; set; }
	public bool reactions_shaking_speeds_up { get; set; }
	public double max_capacity { get; set; }
	public List<double> count_per_material_type { get; set; }
	public float audio_collision_size_modifier_amount { get; set; }
	public Int32 last_frame_drank { get; set; }

    public void Load(NoitaStream s){
		drop_as_item = s.ReadBool();
		on_death_spill = s.ReadBool();
		leak_gently = s.ReadBool();
		leak_on_damage_percent = s.ReadBeFloat();
		leak_pressure_min = s.ReadBeFloat();
		leak_pressure_max = s.ReadBeFloat();
		min_damage_to_leak = s.ReadBeFloat();
		b2_force_on_leak = s.ReadBeFloat();
		death_throw_particle_velocity_coeff = s.ReadBeFloat();
		kill_when_empty = s.ReadBool();
		halftime_materials = s.ReadBool();
		do_reactions = s.ReadBeInt32();
		do_reactions_explosions = s.ReadBool();
		do_reactions_entities = s.ReadBool();
		reaction_speed = s.ReadBeInt32();
		reactions_shaking_speeds_up = s.ReadBool();
		max_capacity = s.ReadBeDouble();
		count_per_material_type = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 count_per_material_type.Add(double.Load(s));
}
		audio_collision_size_modifier_amount = s.ReadBeFloat();
		last_frame_drank = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBool(drop_as_item);
		s.WriteBool(on_death_spill);
		s.WriteBool(leak_gently);
		s.WriteBeFloat(leak_on_damage_percent);
		s.WriteBeFloat(leak_pressure_min);
		s.WriteBeFloat(leak_pressure_max);
		s.WriteBeFloat(min_damage_to_leak);
		s.WriteBeFloat(b2_force_on_leak);
		s.WriteBeFloat(death_throw_particle_velocity_coeff);
		s.WriteBool(kill_when_empty);
		s.WriteBool(halftime_materials);
		s.WriteBeInt32(do_reactions);
		s.WriteBool(do_reactions_explosions);
		s.WriteBool(do_reactions_entities);
		s.WriteBeInt32(reaction_speed);
		s.WriteBool(reactions_shaking_speeds_up);
		s.WriteBeDouble(max_capacity);
		s.WriteBeUInt32(count_per_material_type.Length);
foreach(var item in count_per_material_type){ count_per_material_type.Write(s);
}
		s.WriteBeFloat(audio_collision_size_modifier_amount);
		s.WriteBeInt32(last_frame_drank);

    }
}