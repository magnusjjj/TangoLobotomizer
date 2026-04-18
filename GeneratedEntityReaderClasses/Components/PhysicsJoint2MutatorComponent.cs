namespace GeneratedNoitaClasses;
public class PhysicsJoint2MutatorComponent : NoitaComponentBase,  iNoitaType<PhysicsJoint2MutatorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUShort joint_id { get; set; } = new();
	public NoitaBool destroy { get; set; } = new();
	public NoitaFloat motor_speed { get; set; } = new();
	public NoitaFloat motor_max_torque { get; set; } = new();
	public NoitaUInt64 mBox2DJointId { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		joint_id.Read(s);
		destroy.Read(s);
		motor_speed.Read(s);
		motor_max_torque.Read(s);
		mBox2DJointId.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		joint_id.Write(s);
		destroy.Write(s);
		motor_speed.Write(s);
		motor_max_torque.Write(s);
		mBox2DJointId.Write(s);

    }
}