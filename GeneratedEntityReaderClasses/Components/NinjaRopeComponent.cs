namespace GeneratedNoitaClasses;
public class NinjaRopeComponent {
	public float max_length { get; set; }
	public float mLength { get; set; }

    public void Load(NoitaStream s){
		max_length = s.ReadBeFloat();
		mLength = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(max_length);
		s.WriteBeFloat(mLength);

    }
}