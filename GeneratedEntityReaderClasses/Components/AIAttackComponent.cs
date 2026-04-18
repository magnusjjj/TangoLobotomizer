namespace GeneratedNoitaClasses;
public class AIAttackComponent : NoitaComponentBase,  iNoitaType<AIAttackComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt use_probability { get; set; } = new();
	public NoitaFloat min_distance { get; set; } = new();
	public NoitaFloat max_distance { get; set; } = new();
	public NoitaFloat angular_range_deg { get; set; } = new();
	public NoitaInt state_duration_frames { get; set; } = new();
	public NoitaInt frames_between { get; set; } = new();
	public NoitaInt frames_between_global { get; set; } = new();
	public NoitaString animation_name { get; set; } = new();
	public NoitaBool attack_landing_ranged_enabled { get; set; } = new();
	public NoitaInt attack_ranged_action_frame { get; set; } = new();
	public NoitaFloat attack_ranged_offset_x { get; set; } = new();
	public NoitaFloat attack_ranged_offset_y { get; set; } = new();
	public NoitaFloat attack_ranged_root_offset_x { get; set; } = new();
	public NoitaFloat attack_ranged_root_offset_y { get; set; } = new();
	public NoitaBool attack_ranged_use_message { get; set; } = new();
	public NoitaBool attack_ranged_predict { get; set; } = new();
	public NoitaString attack_ranged_entity_file { get; set; } = new();
	public NoitaInt attack_ranged_entity_count_min { get; set; } = new();
	public NoitaInt attack_ranged_entity_count_max { get; set; } = new();
	public NoitaBool attack_ranged_use_laser_sight { get; set; } = new();
	public NoitaBool attack_ranged_aim_rotation_enabled { get; set; } = new();
	public NoitaFloat attack_ranged_aim_rotation_speed { get; set; } = new();
	public NoitaFloat attack_ranged_aim_rotation_shooting_ok_angle_deg { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		use_probability.Read(s);
		min_distance.Read(s);
		max_distance.Read(s);
		angular_range_deg.Read(s);
		state_duration_frames.Read(s);
		frames_between.Read(s);
		frames_between_global.Read(s);
		animation_name.Read(s);
		attack_landing_ranged_enabled.Read(s);
		attack_ranged_action_frame.Read(s);
		attack_ranged_offset_x.Read(s);
		attack_ranged_offset_y.Read(s);
		attack_ranged_root_offset_x.Read(s);
		attack_ranged_root_offset_y.Read(s);
		attack_ranged_use_message.Read(s);
		attack_ranged_predict.Read(s);
		attack_ranged_entity_file.Read(s);
		attack_ranged_entity_count_min.Read(s);
		attack_ranged_entity_count_max.Read(s);
		attack_ranged_use_laser_sight.Read(s);
		attack_ranged_aim_rotation_enabled.Read(s);
		attack_ranged_aim_rotation_speed.Read(s);
		attack_ranged_aim_rotation_shooting_ok_angle_deg.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		use_probability.Write(s);
		min_distance.Write(s);
		max_distance.Write(s);
		angular_range_deg.Write(s);
		state_duration_frames.Write(s);
		frames_between.Write(s);
		frames_between_global.Write(s);
		animation_name.Write(s);
		attack_landing_ranged_enabled.Write(s);
		attack_ranged_action_frame.Write(s);
		attack_ranged_offset_x.Write(s);
		attack_ranged_offset_y.Write(s);
		attack_ranged_root_offset_x.Write(s);
		attack_ranged_root_offset_y.Write(s);
		attack_ranged_use_message.Write(s);
		attack_ranged_predict.Write(s);
		attack_ranged_entity_file.Write(s);
		attack_ranged_entity_count_min.Write(s);
		attack_ranged_entity_count_max.Write(s);
		attack_ranged_use_laser_sight.Write(s);
		attack_ranged_aim_rotation_enabled.Write(s);
		attack_ranged_aim_rotation_speed.Write(s);
		attack_ranged_aim_rotation_shooting_ok_angle_deg.Write(s);

    }
}