namespace GeneratedNoitaClasses;
public class VelocityComponent {
	public float gravity_x { get; set; }
	public float gravity_y { get; set; }
	public float mass { get; set; }
	public float air_friction { get; set; }
	public float terminal_velocity { get; set; }
	public bool apply_terminal_velocity { get; set; }
	public bool updates_velocity { get; set; }
	public bool displace_liquid { get; set; }
	public bool affect_physics_bodies { get; set; }
	public bool limit_to_max_velocity { get; set; }
	public Int32 liquid_death_threshold { get; set; }
	public float liquid_drag { get; set; }
	public CVector2<float> mVelocity { get; set; }

    public void Load(NoitaStream s){
		gravity_x = s.ReadBeFloat();
		gravity_y = s.ReadBeFloat();
		mass = s.ReadBeFloat();
		air_friction = s.ReadBeFloat();
		terminal_velocity = s.ReadBeFloat();
		apply_terminal_velocity = s.ReadBool();
		updates_velocity = s.ReadBool();
		displace_liquid = s.ReadBool();
		affect_physics_bodies = s.ReadBool();
		limit_to_max_velocity = s.ReadBool();
		liquid_death_threshold = s.ReadBeInt32();
		liquid_drag = s.ReadBeFloat();
		mVelocity.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(gravity_x);
		s.WriteBeFloat(gravity_y);
		s.WriteBeFloat(mass);
		s.WriteBeFloat(air_friction);
		s.WriteBeFloat(terminal_velocity);
		s.WriteBool(apply_terminal_velocity);
		s.WriteBool(updates_velocity);
		s.WriteBool(displace_liquid);
		s.WriteBool(affect_physics_bodies);
		s.WriteBool(limit_to_max_velocity);
		s.WriteBeInt32(liquid_death_threshold);
		s.WriteBeFloat(liquid_drag);
		mVelocity.Write(s);

    }
}