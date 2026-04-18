namespace GeneratedNoitaClasses;
public class PhysicsAIComponent : NoitaComponentBase,  iNoitaType<PhysicsAIComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat target_vec_max_len { get; set; } = new();
	public NoitaFloat force_coeff { get; set; } = new();
	public NoitaFloat force_balancing_coeff { get; set; } = new();
	public NoitaFloat force_max { get; set; } = new();
	public NoitaFloat torque_coeff { get; set; } = new();
	public NoitaFloat torque_balancing_coeff { get; set; } = new();
	public NoitaFloat torque_max { get; set; } = new();
	public NoitaFloat torque_damaged_max { get; set; } = new();
	public NoitaFloat torque_jump_random { get; set; } = new();
	public NoitaInt damage_deactivation_probability { get; set; } = new();
	public NoitaInt damage_deactivation_time_min { get; set; } = new();
	public NoitaInt damage_deactivation_time_max { get; set; } = new();
	public NoitaFloat die_on_remaining_mass_percentage { get; set; } = new();
	public NoitaBool levitate { get; set; } = new();
	public NoitaBool v0_jump_logic { get; set; } = new();
	public NoitaBool v0_swim_logic { get; set; } = new();
	public NoitaBool v0_body_id_logic { get; set; } = new();
	public NoitaInt swim_check_y_min { get; set; } = new();
	public NoitaInt swim_check_y_max { get; set; } = new();
	public NoitaInt swim_check_side_x { get; set; } = new();
	public NoitaInt swim_check_side_y { get; set; } = new();
	public NoitaBool keep_inside_world { get; set; } = new();
	public NoitaBool free_if_static { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		target_vec_max_len.Read(s);
		force_coeff.Read(s);
		force_balancing_coeff.Read(s);
		force_max.Read(s);
		torque_coeff.Read(s);
		torque_balancing_coeff.Read(s);
		torque_max.Read(s);
		torque_damaged_max.Read(s);
		torque_jump_random.Read(s);
		damage_deactivation_probability.Read(s);
		damage_deactivation_time_min.Read(s);
		damage_deactivation_time_max.Read(s);
		die_on_remaining_mass_percentage.Read(s);
		levitate.Read(s);
		v0_jump_logic.Read(s);
		v0_swim_logic.Read(s);
		v0_body_id_logic.Read(s);
		swim_check_y_min.Read(s);
		swim_check_y_max.Read(s);
		swim_check_side_x.Read(s);
		swim_check_side_y.Read(s);
		keep_inside_world.Read(s);
		free_if_static.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		target_vec_max_len.Write(s);
		force_coeff.Write(s);
		force_balancing_coeff.Write(s);
		force_max.Write(s);
		torque_coeff.Write(s);
		torque_balancing_coeff.Write(s);
		torque_max.Write(s);
		torque_damaged_max.Write(s);
		torque_jump_random.Write(s);
		damage_deactivation_probability.Write(s);
		damage_deactivation_time_min.Write(s);
		damage_deactivation_time_max.Write(s);
		die_on_remaining_mass_percentage.Write(s);
		levitate.Write(s);
		v0_jump_logic.Write(s);
		v0_swim_logic.Write(s);
		v0_body_id_logic.Write(s);
		swim_check_y_min.Write(s);
		swim_check_y_max.Write(s);
		swim_check_side_x.Write(s);
		swim_check_side_y.Write(s);
		keep_inside_world.Write(s);
		free_if_static.Write(s);

    }
}