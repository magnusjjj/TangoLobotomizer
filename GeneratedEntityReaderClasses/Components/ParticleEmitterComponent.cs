namespace GeneratedNoitaClasses;
public class ParticleEmitterComponent {
	public string emitted_material_name { get; set; }
	public bool create_real_particles { get; set; }
	public bool emit_real_particles { get; set; }
	public bool emit_cosmetic_particles { get; set; }
	public bool cosmetic_force_create { get; set; }
	public bool render_back { get; set; }
	public bool render_ultrabright { get; set; }
	public bool collide_with_grid { get; set; }
	public bool collide_with_gas_and_fire { get; set; }
	public bool particle_single_width { get; set; }
	public bool emit_only_if_there_is_space { get; set; }
	public Int32 emitter_lifetime_frames { get; set; }
	public bool fire_cells_dont_ignite_damagemodel { get; set; }
	public bool color_is_based_on_pos { get; set; }
	public UInt32 color { get; set; }
	public float custom_alpha { get; set; }
	public CVector2<float> offset { get; set; }
	public float x_pos_offset_min { get; set; }
	public float y_pos_offset_min { get; set; }
	public float x_pos_offset_max { get; set; }
	public float y_pos_offset_max { get; set; }
	public ValueRange area_circle_radius { get; set; }
	public float area_circle_sector_degrees { get; set; }
	public float x_vel_min { get; set; }
	public float x_vel_max { get; set; }
	public float y_vel_min { get; set; }
	public float y_vel_max { get; set; }
	public float direction_random_deg { get; set; }
	public CVector2<float> gravity { get; set; }
	public float velocity_always_away_from_center { get; set; }
	public float lifetime_min { get; set; }
	public float lifetime_max { get; set; }
	public float airflow_force { get; set; }
	public float airflow_time { get; set; }
	public float airflow_scale { get; set; }
	public float friction { get; set; }
	public float attractor_force { get; set; }
	public LensValue<int> count_min { get; set; }
	public LensValue<int> count_max { get; set; }
	public Int32 emission_interval_min_frames { get; set; }
	public Int32 emission_interval_max_frames { get; set; }
	public Int32 emission_chance { get; set; }
	public UInt32 custom_style { get; set; }
	public Int32 delay_frames { get; set; }
	public bool is_emitting { get; set; }
	public bool use_material_inventory { get; set; }
	public bool is_trail { get; set; }
	public float trail_gap { get; set; }
	public bool render_on_grid { get; set; }
	public bool fade_based_on_lifetime { get; set; }
	public bool draw_as_long { get; set; }
	public float b2_force { get; set; }
	public bool set_magic_creation { get; set; }
	public string image_animation_file { get; set; }
	public string image_animation_colors_file { get; set; }
	public float image_animation_speed { get; set; }
	public bool image_animation_loop { get; set; }
	public float image_animation_phase { get; set; }
	public float image_animation_emission_probability { get; set; }
	public bool image_animation_raytrace_from_center { get; set; }
	public bool image_animation_use_entity_rotation { get; set; }
	public bool ignore_transform_updated_msg { get; set; }

    public void Load(NoitaStream s){
		emitted_material_name = s.ReadBeString();
		create_real_particles = s.ReadBool();
		emit_real_particles = s.ReadBool();
		emit_cosmetic_particles = s.ReadBool();
		cosmetic_force_create = s.ReadBool();
		render_back = s.ReadBool();
		render_ultrabright = s.ReadBool();
		collide_with_grid = s.ReadBool();
		collide_with_gas_and_fire = s.ReadBool();
		particle_single_width = s.ReadBool();
		emit_only_if_there_is_space = s.ReadBool();
		emitter_lifetime_frames = s.ReadBeInt32();
		fire_cells_dont_ignite_damagemodel = s.ReadBool();
		color_is_based_on_pos = s.ReadBool();
		color = s.ReadBeUInt32();
		custom_alpha = s.ReadBeFloat();
		offset.Load(s);
		x_pos_offset_min = s.ReadBeFloat();
		y_pos_offset_min = s.ReadBeFloat();
		x_pos_offset_max = s.ReadBeFloat();
		y_pos_offset_max = s.ReadBeFloat();
		area_circle_radius.Load(s);
		area_circle_sector_degrees = s.ReadBeFloat();
		x_vel_min = s.ReadBeFloat();
		x_vel_max = s.ReadBeFloat();
		y_vel_min = s.ReadBeFloat();
		y_vel_max = s.ReadBeFloat();
		direction_random_deg = s.ReadBeFloat();
		gravity.Load(s);
		velocity_always_away_from_center = s.ReadBeFloat();
		lifetime_min = s.ReadBeFloat();
		lifetime_max = s.ReadBeFloat();
		airflow_force = s.ReadBeFloat();
		airflow_time = s.ReadBeFloat();
		airflow_scale = s.ReadBeFloat();
		friction = s.ReadBeFloat();
		attractor_force = s.ReadBeFloat();
		count_min.Load(s);
		count_max.Load(s);
		emission_interval_min_frames = s.ReadBeInt32();
		emission_interval_max_frames = s.ReadBeInt32();
		emission_chance = s.ReadBeInt32();
		custom_style = s.ReadBeUInt32();
		delay_frames = s.ReadBeInt32();
		is_emitting = s.ReadBool();
		use_material_inventory = s.ReadBool();
		is_trail = s.ReadBool();
		trail_gap = s.ReadBeFloat();
		render_on_grid = s.ReadBool();
		fade_based_on_lifetime = s.ReadBool();
		draw_as_long = s.ReadBool();
		b2_force = s.ReadBeFloat();
		set_magic_creation = s.ReadBool();
		image_animation_file = s.ReadBeString();
		image_animation_colors_file = s.ReadBeString();
		image_animation_speed = s.ReadBeFloat();
		image_animation_loop = s.ReadBool();
		image_animation_phase = s.ReadBeFloat();
		image_animation_emission_probability = s.ReadBeFloat();
		image_animation_raytrace_from_center = s.ReadBool();
		image_animation_use_entity_rotation = s.ReadBool();
		ignore_transform_updated_msg = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(emitted_material_name);
		s.WriteBool(create_real_particles);
		s.WriteBool(emit_real_particles);
		s.WriteBool(emit_cosmetic_particles);
		s.WriteBool(cosmetic_force_create);
		s.WriteBool(render_back);
		s.WriteBool(render_ultrabright);
		s.WriteBool(collide_with_grid);
		s.WriteBool(collide_with_gas_and_fire);
		s.WriteBool(particle_single_width);
		s.WriteBool(emit_only_if_there_is_space);
		s.WriteBeInt32(emitter_lifetime_frames);
		s.WriteBool(fire_cells_dont_ignite_damagemodel);
		s.WriteBool(color_is_based_on_pos);
		s.WriteBeUInt32(color);
		s.WriteBeFloat(custom_alpha);
		offset.Write(s);
		s.WriteBeFloat(x_pos_offset_min);
		s.WriteBeFloat(y_pos_offset_min);
		s.WriteBeFloat(x_pos_offset_max);
		s.WriteBeFloat(y_pos_offset_max);
		area_circle_radius.Write(s);
		s.WriteBeFloat(area_circle_sector_degrees);
		s.WriteBeFloat(x_vel_min);
		s.WriteBeFloat(x_vel_max);
		s.WriteBeFloat(y_vel_min);
		s.WriteBeFloat(y_vel_max);
		s.WriteBeFloat(direction_random_deg);
		gravity.Write(s);
		s.WriteBeFloat(velocity_always_away_from_center);
		s.WriteBeFloat(lifetime_min);
		s.WriteBeFloat(lifetime_max);
		s.WriteBeFloat(airflow_force);
		s.WriteBeFloat(airflow_time);
		s.WriteBeFloat(airflow_scale);
		s.WriteBeFloat(friction);
		s.WriteBeFloat(attractor_force);
		count_min.Write(s);
		count_max.Write(s);
		s.WriteBeInt32(emission_interval_min_frames);
		s.WriteBeInt32(emission_interval_max_frames);
		s.WriteBeInt32(emission_chance);
		s.WriteBeUInt32(custom_style);
		s.WriteBeInt32(delay_frames);
		s.WriteBool(is_emitting);
		s.WriteBool(use_material_inventory);
		s.WriteBool(is_trail);
		s.WriteBeFloat(trail_gap);
		s.WriteBool(render_on_grid);
		s.WriteBool(fade_based_on_lifetime);
		s.WriteBool(draw_as_long);
		s.WriteBeFloat(b2_force);
		s.WriteBool(set_magic_creation);
		s.WriteBeString(image_animation_file);
		s.WriteBeString(image_animation_colors_file);
		s.WriteBeFloat(image_animation_speed);
		s.WriteBool(image_animation_loop);
		s.WriteBeFloat(image_animation_phase);
		s.WriteBeFloat(image_animation_emission_probability);
		s.WriteBool(image_animation_raytrace_from_center);
		s.WriteBool(image_animation_use_entity_rotation);
		s.WriteBool(ignore_transform_updated_msg);

    }
}