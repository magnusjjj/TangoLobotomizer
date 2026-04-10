namespace GeneratedNoitaClasses;
public class WormAttractorComponent {
	public Int32 direction { get; set; }
	public float radius { get; set; }

    public void Load(NoitaStream s){
		direction = s.ReadBeInt32();
		radius = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(direction);
		s.WriteBeFloat(radius);

    }
}