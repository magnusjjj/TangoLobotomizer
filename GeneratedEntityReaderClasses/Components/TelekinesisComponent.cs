namespace GeneratedNoitaClasses;
public class TelekinesisComponent {
	public UInt32 min_size { get; set; }
	public UInt32 max_size { get; set; }
	public float radius { get; set; }
	public float throw_speed { get; set; }
	public float target_distance { get; set; }
	public bool kick_to_use { get; set; }
	public Int32 mState { get; set; }
	public UInt64 mBodyID { get; set; }
	public float mStartBodyMaxExtent { get; set; }
	public float mStartAimAngle { get; set; }
	public float mStartBodyAngle { get; set; }
	public float mStartBodyDistance { get; set; }
	public float mStartTime { get; set; }
	public float mMinBodyDistance { get; set; }
	public bool mInteract { get; set; }

    public void Load(NoitaStream s){
		min_size = s.ReadBeUInt32();
		max_size = s.ReadBeUInt32();
		radius = s.ReadBeFloat();
		throw_speed = s.ReadBeFloat();
		target_distance = s.ReadBeFloat();
		kick_to_use = s.ReadBool();
		mState = s.ReadBeInt32();
		mBodyID = s.ReadBeUInt64();
		mStartBodyMaxExtent = s.ReadBeFloat();
		mStartAimAngle = s.ReadBeFloat();
		mStartBodyAngle = s.ReadBeFloat();
		mStartBodyDistance = s.ReadBeFloat();
		mStartTime = s.ReadBeFloat();
		mMinBodyDistance = s.ReadBeFloat();
		mInteract = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(min_size);
		s.WriteBeUInt32(max_size);
		s.WriteBeFloat(radius);
		s.WriteBeFloat(throw_speed);
		s.WriteBeFloat(target_distance);
		s.WriteBool(kick_to_use);
		s.WriteBeInt32(mState);
		s.WriteBeUInt64(mBodyID);
		s.WriteBeFloat(mStartBodyMaxExtent);
		s.WriteBeFloat(mStartAimAngle);
		s.WriteBeFloat(mStartBodyAngle);
		s.WriteBeFloat(mStartBodyDistance);
		s.WriteBeFloat(mStartTime);
		s.WriteBeFloat(mMinBodyDistance);
		s.WriteBool(mInteract);

    }
}