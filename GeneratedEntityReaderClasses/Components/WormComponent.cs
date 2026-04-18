namespace GeneratedNoitaClasses;
public class WormComponent : NoitaComponentBase,  iNoitaType<WormComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();
	public NoitaFloat acceleration { get; set; } = new();
	public NoitaLensValue<NoitaFloat> ground_decceleration { get; set; } = new();
	public NoitaFloat gravity { get; set; } = new();
	public NoitaFloat tail_gravity { get; set; } = new();
	public NoitaFloat part_distance { get; set; } = new();
	public NoitaInt ground_check_offset { get; set; } = new();
	public NoitaFloat hitbox_radius { get; set; } = new();
	public NoitaFloat bite_damage { get; set; } = new();
	public NoitaFloat target_kill_radius { get; set; } = new();
	public NoitaFloat target_kill_ragdoll_force { get; set; } = new();
	public NoitaFloat jump_cam_shake { get; set; } = new();
	public NoitaFloat jump_cam_shake_distance { get; set; } = new();
	public NoitaFloat eat_anim_wait_mult { get; set; } = new();
	public NoitaString ragdoll_filename { get; set; } = new();
	public NoitaBool is_water_worm { get; set; } = new();
	public NoitaFloat max_speed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		speed.Read(s);
		acceleration.Read(s);
		ground_decceleration.Read(s);
		gravity.Read(s);
		tail_gravity.Read(s);
		part_distance.Read(s);
		ground_check_offset.Read(s);
		hitbox_radius.Read(s);
		bite_damage.Read(s);
		target_kill_radius.Read(s);
		target_kill_ragdoll_force.Read(s);
		jump_cam_shake.Read(s);
		jump_cam_shake_distance.Read(s);
		eat_anim_wait_mult.Read(s);
		ragdoll_filename.Read(s);
		is_water_worm.Read(s);
		max_speed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		speed.Write(s);
		acceleration.Write(s);
		ground_decceleration.Write(s);
		gravity.Write(s);
		tail_gravity.Write(s);
		part_distance.Write(s);
		ground_check_offset.Write(s);
		hitbox_radius.Write(s);
		bite_damage.Write(s);
		target_kill_radius.Write(s);
		target_kill_ragdoll_force.Write(s);
		jump_cam_shake.Write(s);
		jump_cam_shake_distance.Write(s);
		eat_anim_wait_mult.Write(s);
		ragdoll_filename.Write(s);
		is_water_worm.Write(s);
		max_speed.Write(s);

    }
}