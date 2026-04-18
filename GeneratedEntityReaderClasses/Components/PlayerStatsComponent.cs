namespace GeneratedNoitaClasses;
public class PlayerStatsComponent : NoitaComponentBase,  iNoitaType<PlayerStatsComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt lives { get; set; } = new();
	public NoitaFloat max_hp { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		lives.Read(s);
		max_hp.Read(s);
		speed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		lives.Write(s);
		max_hp.Write(s);
		speed.Write(s);

    }
}