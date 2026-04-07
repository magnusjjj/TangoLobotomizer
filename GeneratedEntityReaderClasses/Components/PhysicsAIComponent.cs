namespace GeneratedNoitaClasses;
public class PhysicsAIComponent{
	public float target_vec_max_len{ get; set; }
	public float force_coeff{ get; set; }
	public float force_balancing_coeff{ get; set; }
	public float force_max{ get; set; }
	public float torque_coeff{ get; set; }
	public float torque_balancing_coeff{ get; set; }
	public float torque_max{ get; set; }
	public float torque_damaged_max{ get; set; }
	public float torque_jump_random{ get; set; }
	public int damage_deactivation_probability{ get; set; }
	public int damage_deactivation_time_min{ get; set; }
	public int damage_deactivation_time_max{ get; set; }
	public float die_on_remaining_mass_percentage{ get; set; }
	public bool levitate{ get; set; }
	public bool v0_jump_logic{ get; set; }
	public bool v0_swim_logic{ get; set; }
	public bool v0_body_id_logic{ get; set; }
	public int swim_check_y_min{ get; set; }
	public int swim_check_y_max{ get; set; }
	public int swim_check_side_x{ get; set; }
	public int swim_check_side_y{ get; set; }
	public bool keep_inside_world{ get; set; }
	public bool free_if_static{ get; set; }

}