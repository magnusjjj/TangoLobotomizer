namespace GeneratedNoitaClasses;
public class TelekinesisComponent : NoitaComponentBase,  iNoitaType<TelekinesisComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt min_size { get; set; } = new();
	public NoitaUInt max_size { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat throw_speed { get; set; } = new();
	public NoitaFloat target_distance { get; set; } = new();
	public NoitaBool kick_to_use { get; set; } = new();
	public NoitaInt mState { get; set; } = new();
	public NoitaUInt64 mBodyID { get; set; } = new();
	public NoitaFloat mStartBodyMaxExtent { get; set; } = new();
	public NoitaFloat mStartAimAngle { get; set; } = new();
	public NoitaFloat mStartBodyAngle { get; set; } = new();
	public NoitaFloat mStartBodyDistance { get; set; } = new();
	public NoitaFloat mStartTime { get; set; } = new();
	public NoitaFloat mMinBodyDistance { get; set; } = new();
	public NoitaBool mInteract { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		min_size.Read(s);
		max_size.Read(s);
		radius.Read(s);
		throw_speed.Read(s);
		target_distance.Read(s);
		kick_to_use.Read(s);
		mState.Read(s);
		mBodyID.Read(s);
		mStartBodyMaxExtent.Read(s);
		mStartAimAngle.Read(s);
		mStartBodyAngle.Read(s);
		mStartBodyDistance.Read(s);
		mStartTime.Read(s);
		mMinBodyDistance.Read(s);
		mInteract.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		min_size.Write(s);
		max_size.Write(s);
		radius.Write(s);
		throw_speed.Write(s);
		target_distance.Write(s);
		kick_to_use.Write(s);
		mState.Write(s);
		mBodyID.Write(s);
		mStartBodyMaxExtent.Write(s);
		mStartAimAngle.Write(s);
		mStartBodyAngle.Write(s);
		mStartBodyDistance.Write(s);
		mStartTime.Write(s);
		mMinBodyDistance.Write(s);
		mInteract.Write(s);

    }
}