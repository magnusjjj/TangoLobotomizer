namespace GeneratedNoitaClasses;
public class AnimalAIComponent {
	public Int32 ai_state { get; set; }
	public Int32 ai_state_timer { get; set; }
	public bool keep_state_alive_when_enabled { get; set; }
	public string preferred_job { get; set; }
	public Int32 escape_if_damaged_probability { get; set; }
	public Int32 attack_if_damaged_probability { get; set; }
	public Int32 eye_offset_x { get; set; }
	public Int32 eye_offset_y { get; set; }
	public bool attack_only_if_attacked { get; set; }
	public bool dont_counter_attack_own_herd { get; set; }
	public float creature_detection_range_x { get; set; }
	public float creature_detection_range_y { get; set; }
	public float creature_detection_angular_range_deg { get; set; }
	public Int32 creature_detection_check_every_x_frames { get; set; }
	public float max_distance_to_cam_to_start_hunting { get; set; }
	public Int32 pathfinding_max_depth_no_target { get; set; }
	public Int32 pathfinding_max_depth_has_target { get; set; }
	public float aggressiveness_min { get; set; }
	public float aggressiveness_max { get; set; }
	public bool tries_to_ranged_attack_friends { get; set; }
	public bool attack_melee_enabled { get; set; }
	public bool attack_dash_enabled { get; set; }
	public bool attack_landing_ranged_enabled { get; set; }
	public bool attack_ranged_enabled { get; set; }
	public float attack_knockback_multiplier { get; set; }
	public bool is_static_turret { get; set; }
	public Int32 attack_melee_max_distance { get; set; }
	public Int32 attack_melee_action_frame { get; set; }
	public Int32 attack_melee_frames_between { get; set; }
	public float attack_melee_damage_min { get; set; }
	public float attack_melee_damage_max { get; set; }
	public float attack_melee_impulse_vector_x { get; set; }
	public float attack_melee_impulse_vector_y { get; set; }
	public float attack_melee_impulse_multiplier { get; set; }
	public float attack_melee_offset_x { get; set; }
	public float attack_melee_offset_y { get; set; }
	public bool attack_melee_finish_enabled { get; set; }
	public ConfigExplosion attack_melee_finish_config_explosion { get; set; }
	public Int32 attack_melee_finish_action_frame { get; set; }
	public float attack_dash_distance { get; set; }
	public Int32 attack_dash_frames_between { get; set; }
	public float attack_dash_damage { get; set; }
	public float attack_dash_speed { get; set; }
	public float attack_dash_lob { get; set; }
	public float attack_ranged_min_distance { get; set; }
	public float attack_ranged_max_distance { get; set; }
	public Int32 attack_ranged_action_frame { get; set; }
	public LensValue<int> attack_ranged_frames_between { get; set; }
	public float attack_ranged_offset_x { get; set; }
	public float attack_ranged_offset_y { get; set; }
	public bool attack_ranged_use_message { get; set; }
	public bool attack_ranged_predict { get; set; }
	public string attack_ranged_entity_file { get; set; }
	public Int32 attack_ranged_entity_count_min { get; set; }
	public Int32 attack_ranged_entity_count_max { get; set; }
	public bool attack_ranged_use_laser_sight { get; set; }
	public bool attack_ranged_laser_sight_beam_kind { get; set; }
	public bool attack_ranged_aim_rotation_enabled { get; set; }
	public float attack_ranged_aim_rotation_speed { get; set; }
	public float attack_ranged_aim_rotation_shooting_ok_angle_deg { get; set; }
	public Int32 attack_ranged_state_duration_frames { get; set; }
	public bool hide_from_prey { get; set; }
	public float hide_from_prey_target_distance { get; set; }
	public Int32 hide_from_prey_time { get; set; }
	public Int32 food_material { get; set; }
	public Int32 food_particle_effect_material { get; set; }
	public bool food_eating_create_particles { get; set; }
	public Int32 eating_area_radius_x { get; set; }
	public Int32 eating_area_radius_y { get; set; }
	public Int32 mouth_offset_x { get; set; }
	public Int32 mouth_offset_y { get; set; }
	public bool defecates_and_pees { get; set; }
	public Int32 butt_offset_x { get; set; }
	public Int32 butt_offset_y { get; set; }
	public float pee_velocity_x { get; set; }
	public float pee_velocity_y { get; set; }
	public bool needs_food { get; set; }
	public bool sense_creatures { get; set; }
	public bool sense_creatures_through_walls { get; set; }
	public bool can_fly { get; set; }
	public bool can_walk { get; set; }
	public Int32 path_distance_to_target_node_to_turn_around { get; set; }
	public float path_cleanup_explosion_radius { get; set; }
	public float max_distance_to_move_from_home { get; set; }
	public LensValue<float> mAggression { get; set; }

    public void Load(NoitaStream s){
		ai_state = s.ReadBeInt32();
		ai_state_timer = s.ReadBeInt32();
		keep_state_alive_when_enabled = s.ReadBool();
		preferred_job = s.ReadBeString();
		escape_if_damaged_probability = s.ReadBeInt32();
		attack_if_damaged_probability = s.ReadBeInt32();
		eye_offset_x = s.ReadBeInt32();
		eye_offset_y = s.ReadBeInt32();
		attack_only_if_attacked = s.ReadBool();
		dont_counter_attack_own_herd = s.ReadBool();
		creature_detection_range_x = s.ReadBeFloat();
		creature_detection_range_y = s.ReadBeFloat();
		creature_detection_angular_range_deg = s.ReadBeFloat();
		creature_detection_check_every_x_frames = s.ReadBeInt32();
		max_distance_to_cam_to_start_hunting = s.ReadBeFloat();
		pathfinding_max_depth_no_target = s.ReadBeInt32();
		pathfinding_max_depth_has_target = s.ReadBeInt32();
		aggressiveness_min = s.ReadBeFloat();
		aggressiveness_max = s.ReadBeFloat();
		tries_to_ranged_attack_friends = s.ReadBool();
		attack_melee_enabled = s.ReadBool();
		attack_dash_enabled = s.ReadBool();
		attack_landing_ranged_enabled = s.ReadBool();
		attack_ranged_enabled = s.ReadBool();
		attack_knockback_multiplier = s.ReadBeFloat();
		is_static_turret = s.ReadBool();
		attack_melee_max_distance = s.ReadBeInt32();
		attack_melee_action_frame = s.ReadBeInt32();
		attack_melee_frames_between = s.ReadBeInt32();
		attack_melee_damage_min = s.ReadBeFloat();
		attack_melee_damage_max = s.ReadBeFloat();
		attack_melee_impulse_vector_x = s.ReadBeFloat();
		attack_melee_impulse_vector_y = s.ReadBeFloat();
		attack_melee_impulse_multiplier = s.ReadBeFloat();
		attack_melee_offset_x = s.ReadBeFloat();
		attack_melee_offset_y = s.ReadBeFloat();
		attack_melee_finish_enabled = s.ReadBool();
		attack_melee_finish_config_explosion.Load(s);
		attack_melee_finish_action_frame = s.ReadBeInt32();
		attack_dash_distance = s.ReadBeFloat();
		attack_dash_frames_between = s.ReadBeInt32();
		attack_dash_damage = s.ReadBeFloat();
		attack_dash_speed = s.ReadBeFloat();
		attack_dash_lob = s.ReadBeFloat();
		attack_ranged_min_distance = s.ReadBeFloat();
		attack_ranged_max_distance = s.ReadBeFloat();
		attack_ranged_action_frame = s.ReadBeInt32();
		attack_ranged_frames_between.Load(s);
		attack_ranged_offset_x = s.ReadBeFloat();
		attack_ranged_offset_y = s.ReadBeFloat();
		attack_ranged_use_message = s.ReadBool();
		attack_ranged_predict = s.ReadBool();
		attack_ranged_entity_file = s.ReadBeString();
		attack_ranged_entity_count_min = s.ReadBeInt32();
		attack_ranged_entity_count_max = s.ReadBeInt32();
		attack_ranged_use_laser_sight = s.ReadBool();
		attack_ranged_laser_sight_beam_kind = s.ReadBool();
		attack_ranged_aim_rotation_enabled = s.ReadBool();
		attack_ranged_aim_rotation_speed = s.ReadBeFloat();
		attack_ranged_aim_rotation_shooting_ok_angle_deg = s.ReadBeFloat();
		attack_ranged_state_duration_frames = s.ReadBeInt32();
		hide_from_prey = s.ReadBool();
		hide_from_prey_target_distance = s.ReadBeFloat();
		hide_from_prey_time = s.ReadBeInt32();
		food_material = s.ReadBeInt32();
		food_particle_effect_material = s.ReadBeInt32();
		food_eating_create_particles = s.ReadBool();
		eating_area_radius_x = s.ReadBeInt32();
		eating_area_radius_y = s.ReadBeInt32();
		mouth_offset_x = s.ReadBeInt32();
		mouth_offset_y = s.ReadBeInt32();
		defecates_and_pees = s.ReadBool();
		butt_offset_x = s.ReadBeInt32();
		butt_offset_y = s.ReadBeInt32();
		pee_velocity_x = s.ReadBeFloat();
		pee_velocity_y = s.ReadBeFloat();
		needs_food = s.ReadBool();
		sense_creatures = s.ReadBool();
		sense_creatures_through_walls = s.ReadBool();
		can_fly = s.ReadBool();
		can_walk = s.ReadBool();
		path_distance_to_target_node_to_turn_around = s.ReadBeInt32();
		path_cleanup_explosion_radius = s.ReadBeFloat();
		max_distance_to_move_from_home = s.ReadBeFloat();
		mAggression.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(ai_state);
		s.WriteBeInt32(ai_state_timer);
		s.WriteBool(keep_state_alive_when_enabled);
		s.WriteBeString(preferred_job);
		s.WriteBeInt32(escape_if_damaged_probability);
		s.WriteBeInt32(attack_if_damaged_probability);
		s.WriteBeInt32(eye_offset_x);
		s.WriteBeInt32(eye_offset_y);
		s.WriteBool(attack_only_if_attacked);
		s.WriteBool(dont_counter_attack_own_herd);
		s.WriteBeFloat(creature_detection_range_x);
		s.WriteBeFloat(creature_detection_range_y);
		s.WriteBeFloat(creature_detection_angular_range_deg);
		s.WriteBeInt32(creature_detection_check_every_x_frames);
		s.WriteBeFloat(max_distance_to_cam_to_start_hunting);
		s.WriteBeInt32(pathfinding_max_depth_no_target);
		s.WriteBeInt32(pathfinding_max_depth_has_target);
		s.WriteBeFloat(aggressiveness_min);
		s.WriteBeFloat(aggressiveness_max);
		s.WriteBool(tries_to_ranged_attack_friends);
		s.WriteBool(attack_melee_enabled);
		s.WriteBool(attack_dash_enabled);
		s.WriteBool(attack_landing_ranged_enabled);
		s.WriteBool(attack_ranged_enabled);
		s.WriteBeFloat(attack_knockback_multiplier);
		s.WriteBool(is_static_turret);
		s.WriteBeInt32(attack_melee_max_distance);
		s.WriteBeInt32(attack_melee_action_frame);
		s.WriteBeInt32(attack_melee_frames_between);
		s.WriteBeFloat(attack_melee_damage_min);
		s.WriteBeFloat(attack_melee_damage_max);
		s.WriteBeFloat(attack_melee_impulse_vector_x);
		s.WriteBeFloat(attack_melee_impulse_vector_y);
		s.WriteBeFloat(attack_melee_impulse_multiplier);
		s.WriteBeFloat(attack_melee_offset_x);
		s.WriteBeFloat(attack_melee_offset_y);
		s.WriteBool(attack_melee_finish_enabled);
		attack_melee_finish_config_explosion.Write(s);
		s.WriteBeInt32(attack_melee_finish_action_frame);
		s.WriteBeFloat(attack_dash_distance);
		s.WriteBeInt32(attack_dash_frames_between);
		s.WriteBeFloat(attack_dash_damage);
		s.WriteBeFloat(attack_dash_speed);
		s.WriteBeFloat(attack_dash_lob);
		s.WriteBeFloat(attack_ranged_min_distance);
		s.WriteBeFloat(attack_ranged_max_distance);
		s.WriteBeInt32(attack_ranged_action_frame);
		attack_ranged_frames_between.Write(s);
		s.WriteBeFloat(attack_ranged_offset_x);
		s.WriteBeFloat(attack_ranged_offset_y);
		s.WriteBool(attack_ranged_use_message);
		s.WriteBool(attack_ranged_predict);
		s.WriteBeString(attack_ranged_entity_file);
		s.WriteBeInt32(attack_ranged_entity_count_min);
		s.WriteBeInt32(attack_ranged_entity_count_max);
		s.WriteBool(attack_ranged_use_laser_sight);
		s.WriteBool(attack_ranged_laser_sight_beam_kind);
		s.WriteBool(attack_ranged_aim_rotation_enabled);
		s.WriteBeFloat(attack_ranged_aim_rotation_speed);
		s.WriteBeFloat(attack_ranged_aim_rotation_shooting_ok_angle_deg);
		s.WriteBeInt32(attack_ranged_state_duration_frames);
		s.WriteBool(hide_from_prey);
		s.WriteBeFloat(hide_from_prey_target_distance);
		s.WriteBeInt32(hide_from_prey_time);
		s.WriteBeInt32(food_material);
		s.WriteBeInt32(food_particle_effect_material);
		s.WriteBool(food_eating_create_particles);
		s.WriteBeInt32(eating_area_radius_x);
		s.WriteBeInt32(eating_area_radius_y);
		s.WriteBeInt32(mouth_offset_x);
		s.WriteBeInt32(mouth_offset_y);
		s.WriteBool(defecates_and_pees);
		s.WriteBeInt32(butt_offset_x);
		s.WriteBeInt32(butt_offset_y);
		s.WriteBeFloat(pee_velocity_x);
		s.WriteBeFloat(pee_velocity_y);
		s.WriteBool(needs_food);
		s.WriteBool(sense_creatures);
		s.WriteBool(sense_creatures_through_walls);
		s.WriteBool(can_fly);
		s.WriteBool(can_walk);
		s.WriteBeInt32(path_distance_to_target_node_to_turn_around);
		s.WriteBeFloat(path_cleanup_explosion_radius);
		s.WriteBeFloat(max_distance_to_move_from_home);
		mAggression.Write(s);

    }
}