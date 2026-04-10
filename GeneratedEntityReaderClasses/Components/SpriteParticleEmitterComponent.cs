namespace GeneratedNoitaClasses;
public class SpriteParticleEmitterComponent {
	public string sprite_file { get; set; }
	public bool sprite_centered { get; set; }
	public bool sprite_random_rotation { get; set; }
	public bool render_back { get; set; }
	public float delay { get; set; }
	public float lifetime { get; set; }
	public ceng_CColorFloat color { get; set; }
	public ceng_CColorFloat color_change { get; set; }
	public bool additive { get; set; }
	public bool emissive { get; set; }
	public CVector2<float> velocity { get; set; }
	public CVector2<float> gravity { get; set; }
	public float velocity_slowdown { get; set; }
	public float rotation { get; set; }
	public float angular_velocity { get; set; }
	public bool use_velocity_as_rotation { get; set; }
	public bool use_rotation_from_velocity_component { get; set; }
	public bool use_rotation_from_entity { get; set; }
	public float entity_velocity_multiplier { get; set; }
	public CVector2<float> scale { get; set; }
	public CVector2<float> scale_velocity { get; set; }
	public float z_index { get; set; }
	public ValueRange randomize_lifetime { get; set; }
	public types_aabb randomize_position { get; set; }
	public bool randomize_position_inside_hitbox { get; set; }
	public types_aabb randomize_velocity { get; set; }
	public types_aabb randomize_scale { get; set; }
	public ValueRange randomize_rotation { get; set; }
	public ValueRange randomize_angular_velocity { get; set; }
	public ValueRange randomize_alpha { get; set; }
	public ValueRange randomize_animation_speed_coeff { get; set; }
	public bool velocity_always_away_from_center { get; set; }
	public CVector2<float> expand_randomize_position { get; set; }
	public bool camera_bound { get; set; }
	public float camera_distance { get; set; }
	public bool is_emitting { get; set; }
	public Int32 count_min { get; set; }
	public Int32 count_max { get; set; }
	public Int32 emission_interval_min_frames { get; set; }
	public Int32 emission_interval_max_frames { get; set; }
	public string entity_file { get; set; }

    public void Load(NoitaStream s){
		sprite_file = s.ReadBeString();
		sprite_centered = s.ReadBool();
		sprite_random_rotation = s.ReadBool();
		render_back = s.ReadBool();
		delay = s.ReadBeFloat();
		lifetime = s.ReadBeFloat();
		color.Load(s);
		color_change.Load(s);
		additive = s.ReadBool();
		emissive = s.ReadBool();
		velocity.Load(s);
		gravity.Load(s);
		velocity_slowdown = s.ReadBeFloat();
		rotation = s.ReadBeFloat();
		angular_velocity = s.ReadBeFloat();
		use_velocity_as_rotation = s.ReadBool();
		use_rotation_from_velocity_component = s.ReadBool();
		use_rotation_from_entity = s.ReadBool();
		entity_velocity_multiplier = s.ReadBeFloat();
		scale.Load(s);
		scale_velocity.Load(s);
		z_index = s.ReadBeFloat();
		randomize_lifetime.Load(s);
		randomize_position.Load(s);
		randomize_position_inside_hitbox = s.ReadBool();
		randomize_velocity.Load(s);
		randomize_scale.Load(s);
		randomize_rotation.Load(s);
		randomize_angular_velocity.Load(s);
		randomize_alpha.Load(s);
		randomize_animation_speed_coeff.Load(s);
		velocity_always_away_from_center = s.ReadBool();
		expand_randomize_position.Load(s);
		camera_bound = s.ReadBool();
		camera_distance = s.ReadBeFloat();
		is_emitting = s.ReadBool();
		count_min = s.ReadBeInt32();
		count_max = s.ReadBeInt32();
		emission_interval_min_frames = s.ReadBeInt32();
		emission_interval_max_frames = s.ReadBeInt32();
		entity_file = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(sprite_file);
		s.WriteBool(sprite_centered);
		s.WriteBool(sprite_random_rotation);
		s.WriteBool(render_back);
		s.WriteBeFloat(delay);
		s.WriteBeFloat(lifetime);
		color.Write(s);
		color_change.Write(s);
		s.WriteBool(additive);
		s.WriteBool(emissive);
		velocity.Write(s);
		gravity.Write(s);
		s.WriteBeFloat(velocity_slowdown);
		s.WriteBeFloat(rotation);
		s.WriteBeFloat(angular_velocity);
		s.WriteBool(use_velocity_as_rotation);
		s.WriteBool(use_rotation_from_velocity_component);
		s.WriteBool(use_rotation_from_entity);
		s.WriteBeFloat(entity_velocity_multiplier);
		scale.Write(s);
		scale_velocity.Write(s);
		s.WriteBeFloat(z_index);
		randomize_lifetime.Write(s);
		randomize_position.Write(s);
		s.WriteBool(randomize_position_inside_hitbox);
		randomize_velocity.Write(s);
		randomize_scale.Write(s);
		randomize_rotation.Write(s);
		randomize_angular_velocity.Write(s);
		randomize_alpha.Write(s);
		randomize_animation_speed_coeff.Write(s);
		s.WriteBool(velocity_always_away_from_center);
		expand_randomize_position.Write(s);
		s.WriteBool(camera_bound);
		s.WriteBeFloat(camera_distance);
		s.WriteBool(is_emitting);
		s.WriteBeInt32(count_min);
		s.WriteBeInt32(count_max);
		s.WriteBeInt32(emission_interval_min_frames);
		s.WriteBeInt32(emission_interval_max_frames);
		s.WriteBeString(entity_file);

    }
}