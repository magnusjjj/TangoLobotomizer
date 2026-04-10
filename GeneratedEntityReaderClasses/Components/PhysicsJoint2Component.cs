namespace GeneratedNoitaClasses;
public class PhysicsJoint2Component {
	public UInt16 joint_id { get; set; }
	public float break_force { get; set; }
	public float break_distance { get; set; }
	public bool break_on_body_modified { get; set; }
	public float break_on_shear_angle_deg { get; set; }
	public UInt32 type { get; set; }
	public Int32 body1_id { get; set; }
	public Int32 body2_id { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }
	public float ray_x { get; set; }
	public float ray_y { get; set; }
	public float surface_attachment_offset_x { get; set; }
	public float surface_attachment_offset_y { get; set; }

    public void Load(NoitaStream s){
		joint_id = s.ReadBeUInt16();
		break_force = s.ReadBeFloat();
		break_distance = s.ReadBeFloat();
		break_on_body_modified = s.ReadBool();
		break_on_shear_angle_deg = s.ReadBeFloat();
		type = s.ReadBeUInt32();
		body1_id = s.ReadBeInt32();
		body2_id = s.ReadBeInt32();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();
		ray_x = s.ReadBeFloat();
		ray_y = s.ReadBeFloat();
		surface_attachment_offset_x = s.ReadBeFloat();
		surface_attachment_offset_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt16(joint_id);
		s.WriteBeFloat(break_force);
		s.WriteBeFloat(break_distance);
		s.WriteBool(break_on_body_modified);
		s.WriteBeFloat(break_on_shear_angle_deg);
		s.WriteBeUInt32(type);
		s.WriteBeInt32(body1_id);
		s.WriteBeInt32(body2_id);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);
		s.WriteBeFloat(ray_x);
		s.WriteBeFloat(ray_y);
		s.WriteBeFloat(surface_attachment_offset_x);
		s.WriteBeFloat(surface_attachment_offset_y);

    }
}