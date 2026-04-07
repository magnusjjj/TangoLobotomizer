namespace GeneratedNoitaClasses;
public class PhysicsJointComponent{
	public bool nail_to_wall{ get; set; }
	public bool grid_joint{ get; set; }
	public bool breakable{ get; set; }
	public JOINT_TYPE type{ get; set; }
	public int body1_id{ get; set; }
	public int body2_id{ get; set; }
	public float pos_x{ get; set; }
	public float pos_y{ get; set; }
	public float delta_x{ get; set; }
	public float delta_y{ get; set; }
	public bool mMotorEnabled{ get; set; }
	public float mMotorSpeed{ get; set; }
	public float mMaxMotorTorque{ get; set; }

}