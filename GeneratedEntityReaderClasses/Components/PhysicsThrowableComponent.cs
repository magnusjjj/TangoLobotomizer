namespace GeneratedNoitaClasses;
public class PhysicsThrowableComponent : NoitaComponentBase,  iNoitaType<PhysicsThrowableComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat throw_force_coeff { get; set; } = new();
	public NoitaFloat max_throw_speed { get; set; } = new();
	public NoitaFloat min_torque { get; set; } = new();
	public NoitaFloat max_torque { get; set; } = new();
	public NoitaFloat tip_check_offset_min { get; set; } = new();
	public NoitaFloat tip_check_offset_max { get; set; } = new();
	public NoitaFloat tip_check_random_rotation_deg { get; set; } = new();
	public NoitaFloat attach_min_speed { get; set; } = new();
	public NoitaBool attach_to_surfaces_knife_style { get; set; } = new();
	public NoitaInt hp { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		throw_force_coeff.Read(s);
		max_throw_speed.Read(s);
		min_torque.Read(s);
		max_torque.Read(s);
		tip_check_offset_min.Read(s);
		tip_check_offset_max.Read(s);
		tip_check_random_rotation_deg.Read(s);
		attach_min_speed.Read(s);
		attach_to_surfaces_knife_style.Read(s);
		hp.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		throw_force_coeff.Write(s);
		max_throw_speed.Write(s);
		min_torque.Write(s);
		max_torque.Write(s);
		tip_check_offset_min.Write(s);
		tip_check_offset_max.Write(s);
		tip_check_random_rotation_deg.Write(s);
		attach_min_speed.Write(s);
		attach_to_surfaces_knife_style.Write(s);
		hp.Write(s);

    }
}