namespace GeneratedNoitaClasses;
public class PhysicsBodyCollisionDamageComponent : NoitaComponentBase,  iNoitaType<PhysicsBodyCollisionDamageComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat speed_threshold { get; set; } = new();
	public NoitaFloat damage_multiplier { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		speed_threshold.Read(s);
		damage_multiplier.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		speed_threshold.Write(s);
		damage_multiplier.Write(s);

    }
}