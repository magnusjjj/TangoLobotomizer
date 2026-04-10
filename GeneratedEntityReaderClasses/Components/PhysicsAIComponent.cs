namespace GeneratedNoitaClasses;
public class PhysicsAIComponent {
	public float target_vec_max_len { get; set; }
	public float force_coeff { get; set; }
	public float force_balancing_coeff { get; set; }
	public float force_max { get; set; }
	public float torque_coeff { get; set; }
	public float torque_balancing_coeff { get; set; }
	public float torque_max { get; set; }
	public float torque_damaged_max { get; set; }
	public float torque_jump_random { get; set; }
	public Int32 damage_deactivation_probability { get; set; }
	public Int32 damage_deactivation_time_min { get; set; }
	public Int32 damage_deactivation_time_max { get; set; }
	public float die_on_remaining_mass_percentage { get; set; }
	public bool levitate { get; set; }
	public bool v0_jump_logic { get; set; }
	public bool v0_swim_logic { get; set; }
	public bool v0_body_id_logic { get; set; }
	public Int32 swim_check_y_min { get; set; }
	public Int32 swim_check_y_max { get; set; }
	public Int32 swim_check_side_x { get; set; }
	public Int32 swim_check_side_y { get; set; }
	public bool keep_inside_world { get; set; }
	public bool free_if_static { get; set; }

    public void Load(NoitaStream s){
		target_vec_max_len = s.ReadBeFloat();
		force_coeff = s.ReadBeFloat();
		force_balancing_coeff = s.ReadBeFloat();
		force_max = s.ReadBeFloat();
		torque_coeff = s.ReadBeFloat();
		torque_balancing_coeff = s.ReadBeFloat();
		torque_max = s.ReadBeFloat();
		torque_damaged_max = s.ReadBeFloat();
		torque_jump_random = s.ReadBeFloat();
		damage_deactivation_probability = s.ReadBeInt32();
		damage_deactivation_time_min = s.ReadBeInt32();
		damage_deactivation_time_max = s.ReadBeInt32();
		die_on_remaining_mass_percentage = s.ReadBeFloat();
		levitate = s.ReadBool();
		v0_jump_logic = s.ReadBool();
		v0_swim_logic = s.ReadBool();
		v0_body_id_logic = s.ReadBool();
		swim_check_y_min = s.ReadBeInt32();
		swim_check_y_max = s.ReadBeInt32();
		swim_check_side_x = s.ReadBeInt32();
		swim_check_side_y = s.ReadBeInt32();
		keep_inside_world = s.ReadBool();
		free_if_static = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(target_vec_max_len);
		s.WriteBeFloat(force_coeff);
		s.WriteBeFloat(force_balancing_coeff);
		s.WriteBeFloat(force_max);
		s.WriteBeFloat(torque_coeff);
		s.WriteBeFloat(torque_balancing_coeff);
		s.WriteBeFloat(torque_max);
		s.WriteBeFloat(torque_damaged_max);
		s.WriteBeFloat(torque_jump_random);
		s.WriteBeInt32(damage_deactivation_probability);
		s.WriteBeInt32(damage_deactivation_time_min);
		s.WriteBeInt32(damage_deactivation_time_max);
		s.WriteBeFloat(die_on_remaining_mass_percentage);
		s.WriteBool(levitate);
		s.WriteBool(v0_jump_logic);
		s.WriteBool(v0_swim_logic);
		s.WriteBool(v0_body_id_logic);
		s.WriteBeInt32(swim_check_y_min);
		s.WriteBeInt32(swim_check_y_max);
		s.WriteBeInt32(swim_check_side_x);
		s.WriteBeInt32(swim_check_side_y);
		s.WriteBool(keep_inside_world);
		s.WriteBool(free_if_static);

    }
}