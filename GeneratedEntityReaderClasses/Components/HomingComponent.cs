namespace GeneratedNoitaClasses;
public class HomingComponent{
	public string target_tag{ get; set; }
	public bool target_who_shot{ get; set; }
	public float detect_distance{ get; set; }
	public float homing_velocity_multiplier{ get; set; }
	public float homing_targeting_coeff{ get; set; }
	public bool just_rotate_towards_target{ get; set; }
	public float max_turn_rate{ get; set; }
	public UInt32 predefined_target{ get; set; }
	public bool look_for_root_entities_only{ get; set; }

}