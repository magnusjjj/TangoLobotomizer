namespace GeneratedNoitaClasses;
public class BiomeTrackerComponent : NoitaComponentBase,  iNoitaType<BiomeTrackerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt limit_to_every_n_frame { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		limit_to_every_n_frame.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		limit_to_every_n_frame.Write(s);

    }
}