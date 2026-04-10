namespace GeneratedNoitaClasses;
public class BiomeTrackerComponent {
	public Int32 limit_to_every_n_frame { get; set; }

    public void Load(NoitaStream s){
		limit_to_every_n_frame = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(limit_to_every_n_frame);

    }
}