namespace GeneratedNoitaClasses;
public class GasBubbleComponent {
	public float acceleration { get; set; }
	public float max_speed { get; set; }

    public void Load(NoitaStream s){
		acceleration = s.ReadBeFloat();
		max_speed = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(acceleration);
		s.WriteBeFloat(max_speed);

    }
}