namespace GeneratedNoitaClasses;
public class AIAttackComponent {
	public Int32 use_probability { get; set; }
	public float min_distance { get; set; }
	public float max_distance { get; set; }
	public float angular_range_deg { get; set; }
	public Int32 state_duration_frames { get; set; }
	public Int32 frames_between { get; set; }
	public Int32 frames_between_global { get; set; }
	public string animation_name { get; set; }
	public bool attack_landing_ranged_enabled { get; set; }
	public Int32 attack_ranged_action_frame { get; set; }
	public float attack_ranged_offset_x { get; set; }
	public float attack_ranged_offset_y { get; set; }
	public float attack_ranged_root_offset_x { get; set; }
	public float attack_ranged_root_offset_y { get; set; }
	public bool attack_ranged_use_message { get; set; }
	public bool attack_ranged_predict { get; set; }
	public string attack_ranged_entity_file { get; set; }
	public Int32 attack_ranged_entity_count_min { get; set; }
	public Int32 attack_ranged_entity_count_max { get; set; }
	public bool attack_ranged_use_laser_sight { get; set; }
	public bool attack_ranged_aim_rotation_enabled { get; set; }
	public float attack_ranged_aim_rotation_speed { get; set; }
	public float attack_ranged_aim_rotation_shooting_ok_angle_deg { get; set; }

    public void Load(NoitaStream s){
		use_probability = s.ReadBeInt32();
		min_distance = s.ReadBeFloat();
		max_distance = s.ReadBeFloat();
		angular_range_deg = s.ReadBeFloat();
		state_duration_frames = s.ReadBeInt32();
		frames_between = s.ReadBeInt32();
		frames_between_global = s.ReadBeInt32();
		animation_name = s.ReadBeString();
		attack_landing_ranged_enabled = s.ReadBool();
		attack_ranged_action_frame = s.ReadBeInt32();
		attack_ranged_offset_x = s.ReadBeFloat();
		attack_ranged_offset_y = s.ReadBeFloat();
		attack_ranged_root_offset_x = s.ReadBeFloat();
		attack_ranged_root_offset_y = s.ReadBeFloat();
		attack_ranged_use_message = s.ReadBool();
		attack_ranged_predict = s.ReadBool();
		attack_ranged_entity_file = s.ReadBeString();
		attack_ranged_entity_count_min = s.ReadBeInt32();
		attack_ranged_entity_count_max = s.ReadBeInt32();
		attack_ranged_use_laser_sight = s.ReadBool();
		attack_ranged_aim_rotation_enabled = s.ReadBool();
		attack_ranged_aim_rotation_speed = s.ReadBeFloat();
		attack_ranged_aim_rotation_shooting_ok_angle_deg = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(use_probability);
		s.WriteBeFloat(min_distance);
		s.WriteBeFloat(max_distance);
		s.WriteBeFloat(angular_range_deg);
		s.WriteBeInt32(state_duration_frames);
		s.WriteBeInt32(frames_between);
		s.WriteBeInt32(frames_between_global);
		s.WriteBeString(animation_name);
		s.WriteBool(attack_landing_ranged_enabled);
		s.WriteBeInt32(attack_ranged_action_frame);
		s.WriteBeFloat(attack_ranged_offset_x);
		s.WriteBeFloat(attack_ranged_offset_y);
		s.WriteBeFloat(attack_ranged_root_offset_x);
		s.WriteBeFloat(attack_ranged_root_offset_y);
		s.WriteBool(attack_ranged_use_message);
		s.WriteBool(attack_ranged_predict);
		s.WriteBeString(attack_ranged_entity_file);
		s.WriteBeInt32(attack_ranged_entity_count_min);
		s.WriteBeInt32(attack_ranged_entity_count_max);
		s.WriteBool(attack_ranged_use_laser_sight);
		s.WriteBool(attack_ranged_aim_rotation_enabled);
		s.WriteBeFloat(attack_ranged_aim_rotation_speed);
		s.WriteBeFloat(attack_ranged_aim_rotation_shooting_ok_angle_deg);

    }
}