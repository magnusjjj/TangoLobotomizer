namespace GeneratedNoitaClasses;
public class LaserEmitterComponent {
	public ConfigLaser laser { get; set; }
	public bool is_emitting { get; set; }
	public Int32 emit_until_frame { get; set; }
	public float laser_angle_add_rad { get; set; }

    public void Load(NoitaStream s){
		laser.Load(s);
		is_emitting = s.ReadBool();
		emit_until_frame = s.ReadBeInt32();
		laser_angle_add_rad = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		laser.Write(s);
		s.WriteBool(is_emitting);
		s.WriteBeInt32(emit_until_frame);
		s.WriteBeFloat(laser_angle_add_rad);

    }
}