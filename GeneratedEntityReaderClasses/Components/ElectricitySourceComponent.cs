namespace GeneratedNoitaClasses;
public class ElectricitySourceComponent {
	public Int32 radius { get; set; }
	public Int32 emission_interval_frames { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeInt32();
		emission_interval_frames = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(radius);
		s.WriteBeInt32(emission_interval_frames);

    }
}