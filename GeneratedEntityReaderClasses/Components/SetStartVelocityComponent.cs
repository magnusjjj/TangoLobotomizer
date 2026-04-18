namespace GeneratedNoitaClasses;
public class SetStartVelocityComponent : NoitaComponentBase,  iNoitaType<SetStartVelocityComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCVector2<NoitaFloat> velocity { get; set; } = new();
	public ValueRange randomize_angle { get; set; } = new();
	public ValueRange randomize_speed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		velocity.Read(s);
		randomize_angle.Read(s);
		randomize_speed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		velocity.Write(s);
		randomize_angle.Write(s);
		randomize_speed.Write(s);

    }
}