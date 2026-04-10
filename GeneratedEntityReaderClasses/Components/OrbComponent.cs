namespace GeneratedNoitaClasses;
public class OrbComponent {
	public Int32 orb_id { get; set; }

    public void Load(NoitaStream s){
		orb_id = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(orb_id);

    }
}