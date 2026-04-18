namespace GeneratedNoitaClasses;
public class WormAttractorComponent : NoitaComponentBase,  iNoitaType<WormAttractorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt direction { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		direction.Read(s);
		radius.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		direction.Write(s);
		radius.Write(s);

    }
}