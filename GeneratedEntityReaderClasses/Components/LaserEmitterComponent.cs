namespace GeneratedNoitaClasses;
public class LaserEmitterComponent : NoitaComponentBase,  iNoitaType<LaserEmitterComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public ConfigLaser laser { get; set; } = new();
	public NoitaBool is_emitting { get; set; } = new();
	public NoitaInt emit_until_frame { get; set; } = new();
	public NoitaFloat laser_angle_add_rad { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		laser.Read(s);
		is_emitting.Read(s);
		emit_until_frame.Read(s);
		laser_angle_add_rad.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		laser.Write(s);
		is_emitting.Write(s);
		emit_until_frame.Write(s);
		laser_angle_add_rad.Write(s);

    }
}