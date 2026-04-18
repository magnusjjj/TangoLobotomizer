namespace GeneratedNoitaClasses;
public class TeleportProjectileComponent : NoitaComponentBase,  iNoitaType<TeleportProjectileComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat min_distance_from_wall { get; set; } = new();
	public NoitaInt actionable_lifetime { get; set; } = new();
	public NoitaBool reset_shooter_y_vel { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		min_distance_from_wall.Read(s);
		actionable_lifetime.Read(s);
		reset_shooter_y_vel.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		min_distance_from_wall.Write(s);
		actionable_lifetime.Write(s);
		reset_shooter_y_vel.Write(s);

    }
}