namespace GeneratedNoitaClasses;
public class PhysicsThrowableComponent {
	public float throw_force_coeff { get; set; }
	public float max_throw_speed { get; set; }
	public float min_torque { get; set; }
	public float max_torque { get; set; }
	public float tip_check_offset_min { get; set; }
	public float tip_check_offset_max { get; set; }
	public float tip_check_random_rotation_deg { get; set; }
	public float attach_min_speed { get; set; }
	public bool attach_to_surfaces_knife_style { get; set; }
	public Int32 hp { get; set; }

    public void Load(NoitaStream s){
		throw_force_coeff = s.ReadBeFloat();
		max_throw_speed = s.ReadBeFloat();
		min_torque = s.ReadBeFloat();
		max_torque = s.ReadBeFloat();
		tip_check_offset_min = s.ReadBeFloat();
		tip_check_offset_max = s.ReadBeFloat();
		tip_check_random_rotation_deg = s.ReadBeFloat();
		attach_min_speed = s.ReadBeFloat();
		attach_to_surfaces_knife_style = s.ReadBool();
		hp = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(throw_force_coeff);
		s.WriteBeFloat(max_throw_speed);
		s.WriteBeFloat(min_torque);
		s.WriteBeFloat(max_torque);
		s.WriteBeFloat(tip_check_offset_min);
		s.WriteBeFloat(tip_check_offset_max);
		s.WriteBeFloat(tip_check_random_rotation_deg);
		s.WriteBeFloat(attach_min_speed);
		s.WriteBool(attach_to_surfaces_knife_style);
		s.WriteBeInt32(hp);

    }
}