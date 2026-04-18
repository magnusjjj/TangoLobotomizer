namespace GeneratedNoitaClasses;
public class IKLimbAttackerComponent : NoitaComponentBase,  iNoitaType<IKLimbAttackerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat leg_velocity_coeff { get; set; } = new();
	public NoitaFloat targeting_radius { get; set; } = new();
	public NoitaBool targeting_raytrace { get; set; } = new();
	public NoitaString target_entities_with_tag { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mTarget { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		leg_velocity_coeff.Read(s);
		targeting_radius.Read(s);
		targeting_raytrace.Read(s);
		target_entities_with_tag.Read(s);
		mTarget.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		leg_velocity_coeff.Write(s);
		targeting_radius.Write(s);
		targeting_raytrace.Write(s);
		target_entities_with_tag.Write(s);
		mTarget.Write(s);

    }
}