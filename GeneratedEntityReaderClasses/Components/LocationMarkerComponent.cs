namespace GeneratedNoitaClasses;
public class LocationMarkerComponent {
	public Int32 id { get; set; }

    public void Load(NoitaStream s){
		id = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(id);

    }
}