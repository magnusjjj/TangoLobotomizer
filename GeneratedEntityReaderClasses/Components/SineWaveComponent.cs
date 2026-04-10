namespace GeneratedNoitaClasses;
public class SineWaveComponent {
	public float sinewave_freq { get; set; }
	public float sinewave_m { get; set; }
	public Int32 lifetime { get; set; }

    public void Load(NoitaStream s){
		sinewave_freq = s.ReadBeFloat();
		sinewave_m = s.ReadBeFloat();
		lifetime = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(sinewave_freq);
		s.WriteBeFloat(sinewave_m);
		s.WriteBeInt32(lifetime);

    }
}