namespace GeneratedNoitaClasses;
public class PositionSeedComponent {
	public float pos_x { get; set; }
	public float pos_y { get; set; }

    public void Load(NoitaStream s){
		pos_x = s.ReadBeFloat();
		pos_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(pos_x);
		s.WriteBeFloat(pos_y);

    }
}