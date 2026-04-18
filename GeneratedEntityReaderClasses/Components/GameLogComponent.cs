namespace GeneratedNoitaClasses;
public class GameLogComponent : NoitaComponentBase,  iNoitaType<GameLogComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool report_death { get; set; } = new();
	public NoitaBool report_damage { get; set; } = new();
	public NoitaBool report_new_biomes { get; set; } = new();
	public NoitaVector<NoitaString> mVisitiedBiomes { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		report_death.Read(s);
		report_damage.Read(s);
		report_new_biomes.Read(s);
		mVisitiedBiomes.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		report_death.Write(s);
		report_damage.Write(s);
		report_new_biomes.Write(s);
		mVisitiedBiomes.Write(s);

    }
}