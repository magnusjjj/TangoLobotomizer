namespace GeneratedNoitaClasses;
public class SetLightAlphaFromVelocityComponent {
	public float max_velocity { get; set; }

    public void Load(NoitaStream s){
		max_velocity = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(max_velocity);

    }
}