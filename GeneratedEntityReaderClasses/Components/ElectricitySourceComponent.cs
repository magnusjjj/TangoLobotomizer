namespace GeneratedNoitaClasses;
public class ElectricitySourceComponent : NoitaComponentBase,  iNoitaType<ElectricitySourceComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt radius { get; set; } = new();
	public NoitaInt emission_interval_frames { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		emission_interval_frames.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		emission_interval_frames.Write(s);

    }
}