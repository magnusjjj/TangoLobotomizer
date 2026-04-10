namespace GeneratedNoitaClasses;
public class HomingComponent {
	public string target_tag { get; set; }
	public bool target_who_shot { get; set; }
	public float detect_distance { get; set; }
	public float homing_velocity_multiplier { get; set; }
	public float homing_targeting_coeff { get; set; }
	public bool just_rotate_towards_target { get; set; }
	public float max_turn_rate { get; set; }
	public UInt32 predefined_target { get; set; }
	public bool look_for_root_entities_only { get; set; }

    public void Load(NoitaStream s){
		target_tag = s.ReadBeString();
		target_who_shot = s.ReadBool();
		detect_distance = s.ReadBeFloat();
		homing_velocity_multiplier = s.ReadBeFloat();
		homing_targeting_coeff = s.ReadBeFloat();
		just_rotate_towards_target = s.ReadBool();
		max_turn_rate = s.ReadBeFloat();
		predefined_target = s.ReadBeUInt32();
		look_for_root_entities_only = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(target_tag);
		s.WriteBool(target_who_shot);
		s.WriteBeFloat(detect_distance);
		s.WriteBeFloat(homing_velocity_multiplier);
		s.WriteBeFloat(homing_targeting_coeff);
		s.WriteBool(just_rotate_towards_target);
		s.WriteBeFloat(max_turn_rate);
		s.WriteBeUInt32(predefined_target);
		s.WriteBool(look_for_root_entities_only);

    }
}