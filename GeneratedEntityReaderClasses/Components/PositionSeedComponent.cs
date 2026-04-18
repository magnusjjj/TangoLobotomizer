namespace GeneratedNoitaClasses;
public class PositionSeedComponent : NoitaComponentBase,  iNoitaType<PositionSeedComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat pos_x { get; set; } = new();
	public NoitaFloat pos_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		pos_x.Read(s);
		pos_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		pos_x.Write(s);
		pos_y.Write(s);

    }
}