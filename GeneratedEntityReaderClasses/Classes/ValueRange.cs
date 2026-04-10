namespace GeneratedNoitaClasses;
public class ValueRange {
	public float min { get; set; }
	public float max { get; set; }

    public void Load(NoitaStream s){
		min = s.ReadBeFloat();
		max = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(min);
		s.WriteBeFloat(max);

    }
}