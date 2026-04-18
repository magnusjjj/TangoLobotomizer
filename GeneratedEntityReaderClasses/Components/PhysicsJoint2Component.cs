namespace GeneratedNoitaClasses;
public class PhysicsJoint2Component : NoitaComponentBase,  iNoitaType<PhysicsJoint2Component>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUShort joint_id { get; set; } = new();
	public NoitaFloat break_force { get; set; } = new();
	public NoitaFloat break_distance { get; set; } = new();
	public NoitaBool break_on_body_modified { get; set; } = new();
	public NoitaFloat break_on_shear_angle_deg { get; set; } = new();
	public NoitaUInt type { get; set; } = new();
	public NoitaInt body1_id { get; set; } = new();
	public NoitaInt body2_id { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();
	public NoitaFloat ray_x { get; set; } = new();
	public NoitaFloat ray_y { get; set; } = new();
	public NoitaFloat surface_attachment_offset_x { get; set; } = new();
	public NoitaFloat surface_attachment_offset_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		joint_id.Read(s);
		break_force.Read(s);
		break_distance.Read(s);
		break_on_body_modified.Read(s);
		break_on_shear_angle_deg.Read(s);
		type.Read(s);
		body1_id.Read(s);
		body2_id.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		ray_x.Read(s);
		ray_y.Read(s);
		surface_attachment_offset_x.Read(s);
		surface_attachment_offset_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		joint_id.Write(s);
		break_force.Write(s);
		break_distance.Write(s);
		break_on_body_modified.Write(s);
		break_on_shear_angle_deg.Write(s);
		type.Write(s);
		body1_id.Write(s);
		body2_id.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		ray_x.Write(s);
		ray_y.Write(s);
		surface_attachment_offset_x.Write(s);
		surface_attachment_offset_y.Write(s);

    }
}