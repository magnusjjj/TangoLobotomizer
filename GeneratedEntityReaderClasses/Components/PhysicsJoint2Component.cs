namespace GeneratedNoitaClasses;
public class PhysicsJoint2Component{
	public UInt16 joint_id{ get; set; }
	public float break_force{ get; set; }
	public float break_distance{ get; set; }
	public bool break_on_body_modified{ get; set; }
	public float break_on_shear_angle_deg{ get; set; }
	public JOINT_TYPE type{ get; set; }
	public int body1_id{ get; set; }
	public int body2_id{ get; set; }
	public float offset_x{ get; set; }
	public float offset_y{ get; set; }
	public float ray_x{ get; set; }
	public float ray_y{ get; set; }
	public float surface_attachment_offset_x{ get; set; }
	public float surface_attachment_offset_y{ get; set; }

}