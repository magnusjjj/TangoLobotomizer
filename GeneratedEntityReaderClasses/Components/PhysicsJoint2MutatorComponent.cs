namespace GeneratedNoitaClasses;
public class PhysicsJoint2MutatorComponent {
	public UInt16 joint_id { get; set; }
	public bool destroy { get; set; }
	public float motor_speed { get; set; }
	public float motor_max_torque { get; set; }
	public UInt64 mBox2DJointId { get; set; }

    public void Load(NoitaStream s){
		joint_id = s.ReadBeUInt16();
		destroy = s.ReadBool();
		motor_speed = s.ReadBeFloat();
		motor_max_torque = s.ReadBeFloat();
		mBox2DJointId = s.ReadBeUInt64();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt16(joint_id);
		s.WriteBool(destroy);
		s.WriteBeFloat(motor_speed);
		s.WriteBeFloat(motor_max_torque);
		s.WriteBeUInt64(mBox2DJointId);

    }
}