namespace GeneratedNoitaClasses;
public class IKLimbAttackerComponent {
	public float radius { get; set; }
	public float leg_velocity_coeff { get; set; }
	public float targeting_radius { get; set; }
	public bool targeting_raytrace { get; set; }
	public string target_entities_with_tag { get; set; }
	public CVector2<float> mTarget { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		leg_velocity_coeff = s.ReadBeFloat();
		targeting_radius = s.ReadBeFloat();
		targeting_raytrace = s.ReadBool();
		target_entities_with_tag = s.ReadBeString();
		mTarget.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeFloat(leg_velocity_coeff);
		s.WriteBeFloat(targeting_radius);
		s.WriteBool(targeting_raytrace);
		s.WriteBeString(target_entities_with_tag);
		mTarget.Write(s);

    }
}