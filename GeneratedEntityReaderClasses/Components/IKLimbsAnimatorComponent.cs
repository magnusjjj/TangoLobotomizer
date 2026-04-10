namespace GeneratedNoitaClasses;
public class IKLimbsAnimatorComponent {
	public Int32 future_state_samples { get; set; }
	public float ground_attachment_ray_length_coeff { get; set; }
	public float leg_velocity_coeff { get; set; }
	public bool affect_flying { get; set; }
	public float large_movement_penalty_coeff { get; set; }
	public float no_ground_attachment_penalty_coeff { get; set; }
	public Int32 ray_skip_material { get; set; }
	public bool is_limp { get; set; }
	public CVector2<float> mPrevBodyPosition { get; set; }

    public void Load(NoitaStream s){
		future_state_samples = s.ReadBeInt32();
		ground_attachment_ray_length_coeff = s.ReadBeFloat();
		leg_velocity_coeff = s.ReadBeFloat();
		affect_flying = s.ReadBool();
		large_movement_penalty_coeff = s.ReadBeFloat();
		no_ground_attachment_penalty_coeff = s.ReadBeFloat();
		ray_skip_material = s.ReadBeInt32();
		is_limp = s.ReadBool();
		mPrevBodyPosition.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(future_state_samples);
		s.WriteBeFloat(ground_attachment_ray_length_coeff);
		s.WriteBeFloat(leg_velocity_coeff);
		s.WriteBool(affect_flying);
		s.WriteBeFloat(large_movement_penalty_coeff);
		s.WriteBeFloat(no_ground_attachment_penalty_coeff);
		s.WriteBeInt32(ray_skip_material);
		s.WriteBool(is_limp);
		mPrevBodyPosition.Write(s);

    }
}