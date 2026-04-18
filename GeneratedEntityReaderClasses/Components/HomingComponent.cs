namespace GeneratedNoitaClasses;
public class HomingComponent : NoitaComponentBase,  iNoitaType<HomingComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString target_tag { get; set; } = new();
	public NoitaBool target_who_shot { get; set; } = new();
	public NoitaFloat detect_distance { get; set; } = new();
	public NoitaFloat homing_velocity_multiplier { get; set; } = new();
	public NoitaFloat homing_targeting_coeff { get; set; } = new();
	public NoitaBool just_rotate_towards_target { get; set; } = new();
	public NoitaFloat max_turn_rate { get; set; } = new();
	public NoitaUInt predefined_target { get; set; } = new();
	public NoitaBool look_for_root_entities_only { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		target_tag.Read(s);
		target_who_shot.Read(s);
		detect_distance.Read(s);
		homing_velocity_multiplier.Read(s);
		homing_targeting_coeff.Read(s);
		just_rotate_towards_target.Read(s);
		max_turn_rate.Read(s);
		predefined_target.Read(s);
		look_for_root_entities_only.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		target_tag.Write(s);
		target_who_shot.Write(s);
		detect_distance.Write(s);
		homing_velocity_multiplier.Write(s);
		homing_targeting_coeff.Write(s);
		just_rotate_towards_target.Write(s);
		max_turn_rate.Write(s);
		predefined_target.Write(s);
		look_for_root_entities_only.Write(s);

    }
}