namespace GeneratedNoitaClasses;
public class MaterialInventoryComponent{
	public bool drop_as_item{ get; set; }
	public bool on_death_spill{ get; set; }
	public bool leak_gently{ get; set; }
	public float leak_on_damage_percent{ get; set; }
	public float leak_pressure_min{ get; set; }
	public float leak_pressure_max{ get; set; }
	public float min_damage_to_leak{ get; set; }
	public float b2_force_on_leak{ get; set; }
	public float death_throw_particle_velocity_coeff{ get; set; }
	public bool kill_when_empty{ get; set; }
	public bool halftime_materials{ get; set; }
	public int do_reactions{ get; set; }
	public bool do_reactions_explosions{ get; set; }
	public bool do_reactions_entities{ get; set; }
	public int reaction_speed{ get; set; }
	public bool reactions_shaking_speeds_up{ get; set; }
	public double max_capacity{ get; set; }
	public List<double> count_per_material_type{ get; set; }
	public float audio_collision_size_modifier_amount{ get; set; }
	public int last_frame_drank{ get; set; }

}