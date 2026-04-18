namespace GeneratedNoitaClasses;
public class IKLimbsAnimatorComponent : NoitaComponentBase,  iNoitaType<IKLimbsAnimatorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt future_state_samples { get; set; } = new();
	public NoitaFloat ground_attachment_ray_length_coeff { get; set; } = new();
	public NoitaFloat leg_velocity_coeff { get; set; } = new();
	public NoitaBool affect_flying { get; set; } = new();
	public NoitaFloat large_movement_penalty_coeff { get; set; } = new();
	public NoitaFloat no_ground_attachment_penalty_coeff { get; set; } = new();
	public NoitaInt ray_skip_material { get; set; } = new();
	public NoitaBool is_limp { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mPrevBodyPosition { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		future_state_samples.Read(s);
		ground_attachment_ray_length_coeff.Read(s);
		leg_velocity_coeff.Read(s);
		affect_flying.Read(s);
		large_movement_penalty_coeff.Read(s);
		no_ground_attachment_penalty_coeff.Read(s);
		ray_skip_material.Read(s);
		is_limp.Read(s);
		mPrevBodyPosition.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		future_state_samples.Write(s);
		ground_attachment_ray_length_coeff.Write(s);
		leg_velocity_coeff.Write(s);
		affect_flying.Write(s);
		large_movement_penalty_coeff.Write(s);
		no_ground_attachment_penalty_coeff.Write(s);
		ray_skip_material.Write(s);
		is_limp.Write(s);
		mPrevBodyPosition.Write(s);

    }
}