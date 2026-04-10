namespace GeneratedNoitaClasses;
public class FogOfWarRemoverComponent {
	public float radius { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);

    }
}