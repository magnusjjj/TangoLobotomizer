namespace GeneratedNoitaClasses;
public class PhysicsBodyCollisionDamageComponent {
	public float speed_threshold { get; set; }
	public float damage_multiplier { get; set; }

    public void Load(NoitaStream s){
		speed_threshold = s.ReadBeFloat();
		damage_multiplier = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(speed_threshold);
		s.WriteBeFloat(damage_multiplier);

    }
}