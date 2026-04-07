namespace GeneratedNoitaClasses;
public class VelocityComponent{
	public float gravity_x{ get; set; }
	public float gravity_y{ get; set; }
	public float mass{ get; set; }
	public float air_friction{ get; set; }
	public float terminal_velocity{ get; set; }
	public bool apply_terminal_velocity{ get; set; }
	public bool updates_velocity{ get; set; }
	public bool displace_liquid{ get; set; }
	public bool affect_physics_bodies{ get; set; }
	public bool limit_to_max_velocity{ get; set; }
	public int liquid_death_threshold{ get; set; }
	public float liquid_drag{ get; set; }
	public List<float> mVelocity{ get; set; }

}