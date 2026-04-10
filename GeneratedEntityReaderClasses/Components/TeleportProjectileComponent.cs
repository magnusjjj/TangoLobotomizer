namespace GeneratedNoitaClasses;
public class TeleportProjectileComponent {
	public float min_distance_from_wall { get; set; }
	public Int32 actionable_lifetime { get; set; }
	public bool reset_shooter_y_vel { get; set; }

    public void Load(NoitaStream s){
		min_distance_from_wall = s.ReadBeFloat();
		actionable_lifetime = s.ReadBeInt32();
		reset_shooter_y_vel = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(min_distance_from_wall);
		s.WriteBeInt32(actionable_lifetime);
		s.WriteBool(reset_shooter_y_vel);

    }
}