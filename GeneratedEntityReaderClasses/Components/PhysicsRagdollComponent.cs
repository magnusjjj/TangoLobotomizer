namespace GeneratedNoitaClasses;
public class PhysicsRagdollComponent {
	public string filename { get; set; }
	public string filenames { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }

    public void Load(NoitaStream s){
		filename = s.ReadBeString();
		filenames = s.ReadBeString();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(filename);
		s.WriteBeString(filenames);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);

    }
}