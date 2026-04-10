namespace GeneratedNoitaClasses;
public class LiquidDisplacerComponent {
	public Int32 radius { get; set; }
	public float velocity_x { get; set; }
	public float velocity_y { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeInt32();
		velocity_x = s.ReadBeFloat();
		velocity_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(radius);
		s.WriteBeFloat(velocity_x);
		s.WriteBeFloat(velocity_y);

    }
}