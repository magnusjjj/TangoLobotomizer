namespace GeneratedNoitaClasses;
public class LiquidDisplacerComponent : NoitaComponentBase,  iNoitaType<LiquidDisplacerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt radius { get; set; } = new();
	public NoitaFloat velocity_x { get; set; } = new();
	public NoitaFloat velocity_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		velocity_x.Read(s);
		velocity_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		velocity_x.Write(s);
		velocity_y.Write(s);

    }
}