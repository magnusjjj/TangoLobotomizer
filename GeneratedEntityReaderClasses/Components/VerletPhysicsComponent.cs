namespace GeneratedNoitaClasses;
public class VerletPhysicsComponent{
	public int num_points{ get; set; }
	public int num_links{ get; set; }
	public int width{ get; set; }
	public VERLET_TYPE type{ get; set; }
	public float resting_distance{ get; set; }
	public float mass_min{ get; set; }
	public float mass_max{ get; set; }
	public float stiffness{ get; set; }
	public float velocity_dampening{ get; set; }
	public float liquid_damping{ get; set; }
	public float gets_entity_velocity_coeff{ get; set; }
	public bool collide_with_cells{ get; set; }
	public bool simulate_gravity{ get; set; }
	public bool simulate_wind{ get; set; }
	public float wind_change_speed{ get; set; }
	public bool constrain_stretching{ get; set; }
	public bool pixelate_sprite_transforms{ get; set; }
	public bool scale_sprite_x{ get; set; }
	public bool follow_entity_transform{ get; set; }
	public List<float> animation_target_offset{ get; set; }
	public float animation_amount{ get; set; }
	public float animation_speed{ get; set; }
	public float animation_energy{ get; set; }
	public float cloth_sprite_z_index{ get; set; }
	public int stain_cells_probability{ get; set; }
	public UInt32 cloth_color_edge{ get; set; }
	public UInt32 cloth_color{ get; set; }
	public List<float> m_position_previous{ get; set; }
	public bool m_is_culled_previous{ get; set; }
	public List<UInt32> colors{ get; set; }
	public List<UInt32> materials{ get; set; }

}