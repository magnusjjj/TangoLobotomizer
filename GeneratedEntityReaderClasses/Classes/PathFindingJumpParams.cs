namespace GeneratedNoitaClasses;
public class PathFindingJumpParams {
	public float x { get; set; }
	public float y { get; set; }
	public float lob { get; set; }

    public void Load(NoitaStream s){
		x = s.ReadBeFloat();
		y = s.ReadBeFloat();
		lob = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(x);
		s.WriteBeFloat(y);
		s.WriteBeFloat(lob);

    }
}