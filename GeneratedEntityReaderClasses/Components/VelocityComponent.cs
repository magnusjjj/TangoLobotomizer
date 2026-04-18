namespace GeneratedNoitaClasses;
public class VelocityComponent : NoitaComponentBase,  iNoitaType<VelocityComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat gravity_x { get; set; } = new();
	public NoitaFloat gravity_y { get; set; } = new();
	public NoitaFloat mass { get; set; } = new();
	public NoitaFloat air_friction { get; set; } = new();
	public NoitaFloat terminal_velocity { get; set; } = new();
	public NoitaBool apply_terminal_velocity { get; set; } = new();
	public NoitaBool updates_velocity { get; set; } = new();
	public NoitaBool displace_liquid { get; set; } = new();
	public NoitaBool affect_physics_bodies { get; set; } = new();
	public NoitaBool limit_to_max_velocity { get; set; } = new();
	public NoitaInt liquid_death_threshold { get; set; } = new();
	public NoitaFloat liquid_drag { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mVelocity { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		gravity_x.Read(s);
		gravity_y.Read(s);
		mass.Read(s);
		air_friction.Read(s);
		terminal_velocity.Read(s);
		apply_terminal_velocity.Read(s);
		updates_velocity.Read(s);
		displace_liquid.Read(s);
		affect_physics_bodies.Read(s);
		limit_to_max_velocity.Read(s);
		liquid_death_threshold.Read(s);
		liquid_drag.Read(s);
		mVelocity.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		gravity_x.Write(s);
		gravity_y.Write(s);
		mass.Write(s);
		air_friction.Write(s);
		terminal_velocity.Write(s);
		apply_terminal_velocity.Write(s);
		updates_velocity.Write(s);
		displace_liquid.Write(s);
		affect_physics_bodies.Write(s);
		limit_to_max_velocity.Write(s);
		liquid_death_threshold.Write(s);
		liquid_drag.Write(s);
		mVelocity.Write(s);

    }
}