namespace GeneratedNoitaClasses;
public class GodInfoComponent : NoitaComponentBase,  iNoitaType<GodInfoComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat mana_current { get; set; } = new();
	public NoitaFloat mana_max { get; set; } = new();
	public NoitaFloat gold { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		mana_current.Read(s);
		mana_max.Read(s);
		gold.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		mana_current.Write(s);
		mana_max.Write(s);
		gold.Write(s);

    }
}