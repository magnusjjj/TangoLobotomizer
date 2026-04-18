namespace GeneratedNoitaClasses;
public class PhysicsJointComponent : NoitaComponentBase,  iNoitaType<PhysicsJointComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool nail_to_wall { get; set; } = new();
	public NoitaBool grid_joint { get; set; } = new();
	public NoitaBool breakable { get; set; } = new();
	public NoitaUInt type { get; set; } = new();
	public NoitaInt body1_id { get; set; } = new();
	public NoitaInt body2_id { get; set; } = new();
	public NoitaFloat pos_x { get; set; } = new();
	public NoitaFloat pos_y { get; set; } = new();
	public NoitaFloat delta_x { get; set; } = new();
	public NoitaFloat delta_y { get; set; } = new();
	public NoitaBool mMotorEnabled { get; set; } = new();
	public NoitaFloat mMotorSpeed { get; set; } = new();
	public NoitaFloat mMaxMotorTorque { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		nail_to_wall.Read(s);
		grid_joint.Read(s);
		breakable.Read(s);
		type.Read(s);
		body1_id.Read(s);
		body2_id.Read(s);
		pos_x.Read(s);
		pos_y.Read(s);
		delta_x.Read(s);
		delta_y.Read(s);
		mMotorEnabled.Read(s);
		mMotorSpeed.Read(s);
		mMaxMotorTorque.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		nail_to_wall.Write(s);
		grid_joint.Write(s);
		breakable.Write(s);
		type.Write(s);
		body1_id.Write(s);
		body2_id.Write(s);
		pos_x.Write(s);
		pos_y.Write(s);
		delta_x.Write(s);
		delta_y.Write(s);
		mMotorEnabled.Write(s);
		mMotorSpeed.Write(s);
		mMaxMotorTorque.Write(s);

    }
}