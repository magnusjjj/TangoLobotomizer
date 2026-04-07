namespace GeneratedNoitaClasses;
public class SpriteParticleEmitterComponent{
	public string sprite_file{ get; set; }
	public bool sprite_centered{ get; set; }
	public bool sprite_random_rotation{ get; set; }
	public bool render_back{ get; set; }
	public float delay{ get; set; }
	public float lifetime{ get; set; }
	public CColorFloat color{ get; set; }
	public CColorFloat color_change{ get; set; }
	public bool additive{ get; set; }
	public bool emissive{ get; set; }
	public List<float> velocity{ get; set; }
	public List<float> gravity{ get; set; }
	public float velocity_slowdown{ get; set; }
	public float rotation{ get; set; }
	public float angular_velocity{ get; set; }
	public bool use_velocity_as_rotation{ get; set; }
	public bool use_rotation_from_velocity_component{ get; set; }
	public bool use_rotation_from_entity{ get; set; }
	public float entity_velocity_multiplier{ get; set; }
	public List<float> scale{ get; set; }
	public List<float> scale_velocity{ get; set; }
	public float z_index{ get; set; }
	public ValueRange randomize_lifetime{ get; set; }
	public types_aabb randomize_position{ get; set; }
	public bool randomize_position_inside_hitbox{ get; set; }
	public types_aabb randomize_velocity{ get; set; }
	public types_aabb randomize_scale{ get; set; }
	public ValueRange randomize_rotation{ get; set; }
	public ValueRange randomize_angular_velocity{ get; set; }
	public ValueRange randomize_alpha{ get; set; }
	public ValueRange randomize_animation_speed_coeff{ get; set; }
	public bool velocity_always_away_from_center{ get; set; }
	public List<float> expand_randomize_position{ get; set; }
	public bool camera_bound{ get; set; }
	public float camera_distance{ get; set; }
	public bool is_emitting{ get; set; }
	public int count_min{ get; set; }
	public int count_max{ get; set; }
	public int emission_interval_min_frames{ get; set; }
	public int emission_interval_max_frames{ get; set; }
	public string entity_file{ get; set; }

}