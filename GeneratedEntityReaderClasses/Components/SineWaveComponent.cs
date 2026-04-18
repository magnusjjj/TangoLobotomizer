namespace GeneratedNoitaClasses;
public class SineWaveComponent : NoitaComponentBase,  iNoitaType<SineWaveComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat sinewave_freq { get; set; } = new();
	public NoitaFloat sinewave_m { get; set; } = new();
	public NoitaInt lifetime { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		sinewave_freq.Read(s);
		sinewave_m.Read(s);
		lifetime.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		sinewave_freq.Write(s);
		sinewave_m.Write(s);
		lifetime.Write(s);

    }
}