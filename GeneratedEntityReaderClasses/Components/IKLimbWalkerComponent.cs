namespace GeneratedNoitaClasses;
public class IKLimbWalkerComponent{
	public float ground_attachment_min_spread{ get; set; }
	public int ground_attachment_max_tries{ get; set; }
	public float ground_attachment_max_angle{ get; set; }
	public float ground_attachment_ray_length_coeff{ get; set; }
	public float leg_velocity_coeff{ get; set; }
	public bool affect_flying{ get; set; }
	public int ray_skip_material{ get; set; }
	public List<float> mTarget{ get; set; }
	public List<float> mPrevTarget{ get; set; }
	public List<float> mPrevCenterPosition{ get; set; }
	public int mState{ get; set; }

}