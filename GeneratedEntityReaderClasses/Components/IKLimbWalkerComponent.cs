namespace GeneratedNoitaClasses;
public class IKLimbWalkerComponent : NoitaComponentBase,  iNoitaType<IKLimbWalkerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat ground_attachment_min_spread { get; set; } = new();
	public NoitaInt ground_attachment_max_tries { get; set; } = new();
	public NoitaFloat ground_attachment_max_angle { get; set; } = new();
	public NoitaFloat ground_attachment_ray_length_coeff { get; set; } = new();
	public NoitaFloat leg_velocity_coeff { get; set; } = new();
	public NoitaBool affect_flying { get; set; } = new();
	public NoitaInt ray_skip_material { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mTarget { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mPrevTarget { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mPrevCenterPosition { get; set; } = new();
	public NoitaInt mState { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		ground_attachment_min_spread.Read(s);
		ground_attachment_max_tries.Read(s);
		ground_attachment_max_angle.Read(s);
		ground_attachment_ray_length_coeff.Read(s);
		leg_velocity_coeff.Read(s);
		affect_flying.Read(s);
		ray_skip_material.Read(s);
		mTarget.Read(s);
		mPrevTarget.Read(s);
		mPrevCenterPosition.Read(s);
		mState.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		ground_attachment_min_spread.Write(s);
		ground_attachment_max_tries.Write(s);
		ground_attachment_max_angle.Write(s);
		ground_attachment_ray_length_coeff.Write(s);
		leg_velocity_coeff.Write(s);
		affect_flying.Write(s);
		ray_skip_material.Write(s);
		mTarget.Write(s);
		mPrevTarget.Write(s);
		mPrevCenterPosition.Write(s);
		mState.Write(s);

    }
}