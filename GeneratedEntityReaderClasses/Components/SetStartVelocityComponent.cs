namespace GeneratedNoitaClasses;
public class SetStartVelocityComponent {
	public CVector2<float> velocity { get; set; }
	public ValueRange randomize_angle { get; set; }
	public ValueRange randomize_speed { get; set; }

    public void Load(NoitaStream s){
		velocity.Load(s);
		randomize_angle.Load(s);
		randomize_speed.Load(s);

    }
    public void Save(NoitaStream s){
		velocity.Write(s);
		randomize_angle.Write(s);
		randomize_speed.Write(s);

    }
}