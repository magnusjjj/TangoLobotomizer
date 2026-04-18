namespace GeneratedNoitaClasses;
public class SetLightAlphaFromVelocityComponent : NoitaComponentBase,  iNoitaType<SetLightAlphaFromVelocityComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat max_velocity { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		max_velocity.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		max_velocity.Write(s);

    }
}