namespace GeneratedNoitaClasses;
public class PhysicsJointComponent {
	public bool nail_to_wall { get; set; }
	public bool grid_joint { get; set; }
	public bool breakable { get; set; }
	public UInt32 type { get; set; }
	public Int32 body1_id { get; set; }
	public Int32 body2_id { get; set; }
	public float pos_x { get; set; }
	public float pos_y { get; set; }
	public float delta_x { get; set; }
	public float delta_y { get; set; }
	public bool mMotorEnabled { get; set; }
	public float mMotorSpeed { get; set; }
	public float mMaxMotorTorque { get; set; }

    public void Load(NoitaStream s){
		nail_to_wall = s.ReadBool();
		grid_joint = s.ReadBool();
		breakable = s.ReadBool();
		type = s.ReadBeUInt32();
		body1_id = s.ReadBeInt32();
		body2_id = s.ReadBeInt32();
		pos_x = s.ReadBeFloat();
		pos_y = s.ReadBeFloat();
		delta_x = s.ReadBeFloat();
		delta_y = s.ReadBeFloat();
		mMotorEnabled = s.ReadBool();
		mMotorSpeed = s.ReadBeFloat();
		mMaxMotorTorque = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(nail_to_wall);
		s.WriteBool(grid_joint);
		s.WriteBool(breakable);
		s.WriteBeUInt32(type);
		s.WriteBeInt32(body1_id);
		s.WriteBeInt32(body2_id);
		s.WriteBeFloat(pos_x);
		s.WriteBeFloat(pos_y);
		s.WriteBeFloat(delta_x);
		s.WriteBeFloat(delta_y);
		s.WriteBool(mMotorEnabled);
		s.WriteBeFloat(mMotorSpeed);
		s.WriteBeFloat(mMaxMotorTorque);

    }
}