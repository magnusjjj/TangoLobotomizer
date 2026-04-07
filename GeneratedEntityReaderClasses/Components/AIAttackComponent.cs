namespace GeneratedNoitaClasses;
public class AIAttackComponent{
	public int use_probability{ get; set; }
	public float min_distance{ get; set; }
	public float max_distance{ get; set; }
	public float angular_range_deg{ get; set; }
	public int state_duration_frames{ get; set; }
	public int frames_between{ get; set; }
	public int frames_between_global{ get; set; }
	public string animation_name{ get; set; }
	public bool attack_landing_ranged_enabled{ get; set; }
	public int attack_ranged_action_frame{ get; set; }
	public float attack_ranged_offset_x{ get; set; }
	public float attack_ranged_offset_y{ get; set; }
	public float attack_ranged_root_offset_x{ get; set; }
	public float attack_ranged_root_offset_y{ get; set; }
	public bool attack_ranged_use_message{ get; set; }
	public bool attack_ranged_predict{ get; set; }
	public string attack_ranged_entity_file{ get; set; }
	public int attack_ranged_entity_count_min{ get; set; }
	public int attack_ranged_entity_count_max{ get; set; }
	public bool attack_ranged_use_laser_sight{ get; set; }
	public bool attack_ranged_aim_rotation_enabled{ get; set; }
	public float attack_ranged_aim_rotation_speed{ get; set; }
	public float attack_ranged_aim_rotation_shooting_ok_angle_deg{ get; set; }

}