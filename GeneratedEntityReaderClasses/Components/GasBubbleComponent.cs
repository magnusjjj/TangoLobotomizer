namespace GeneratedNoitaClasses;
public class GasBubbleComponent : NoitaComponentBase,  iNoitaType<GasBubbleComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat acceleration { get; set; } = new();
	public NoitaFloat max_speed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		acceleration.Read(s);
		max_speed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		acceleration.Write(s);
		max_speed.Write(s);

    }
}