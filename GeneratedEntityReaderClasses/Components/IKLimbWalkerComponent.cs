namespace GeneratedNoitaClasses;
public class IKLimbWalkerComponent {
	public float ground_attachment_min_spread { get; set; }
	public Int32 ground_attachment_max_tries { get; set; }
	public float ground_attachment_max_angle { get; set; }
	public float ground_attachment_ray_length_coeff { get; set; }
	public float leg_velocity_coeff { get; set; }
	public bool affect_flying { get; set; }
	public Int32 ray_skip_material { get; set; }
	public CVector2<float> mTarget { get; set; }
	public CVector2<float> mPrevTarget { get; set; }
	public CVector2<float> mPrevCenterPosition { get; set; }
	public Int32 mState { get; set; }

    public void Load(NoitaStream s){
		ground_attachment_min_spread = s.ReadBeFloat();
		ground_attachment_max_tries = s.ReadBeInt32();
		ground_attachment_max_angle = s.ReadBeFloat();
		ground_attachment_ray_length_coeff = s.ReadBeFloat();
		leg_velocity_coeff = s.ReadBeFloat();
		affect_flying = s.ReadBool();
		ray_skip_material = s.ReadBeInt32();
		mTarget.Load(s);
		mPrevTarget.Load(s);
		mPrevCenterPosition.Load(s);
		mState = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(ground_attachment_min_spread);
		s.WriteBeInt32(ground_attachment_max_tries);
		s.WriteBeFloat(ground_attachment_max_angle);
		s.WriteBeFloat(ground_attachment_ray_length_coeff);
		s.WriteBeFloat(leg_velocity_coeff);
		s.WriteBool(affect_flying);
		s.WriteBeInt32(ray_skip_material);
		mTarget.Write(s);
		mPrevTarget.Write(s);
		mPrevCenterPosition.Write(s);
		s.WriteBeInt32(mState);

    }
}