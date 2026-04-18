namespace GeneratedNoitaClasses;
public class IKLimbComponent : NoitaComponentBase,  iNoitaType<IKLimbComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat length { get; set; } = new();
	public NoitaFloat thigh_extra_lenght { get; set; } = new();
	public NoitaCVector2<NoitaFloat> end_position { get; set; } = new();
	public NoitaFloat mJointSideInterpolation { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mJointWorldPos { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mEndPrevPos { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		length.Read(s);
		thigh_extra_lenght.Read(s);
		end_position.Read(s);
		mJointSideInterpolation.Read(s);
		mJointWorldPos.Read(s);
		mEndPrevPos.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		length.Write(s);
		thigh_extra_lenght.Write(s);
		end_position.Write(s);
		mJointSideInterpolation.Write(s);
		mJointWorldPos.Write(s);
		mEndPrevPos.Write(s);

    }
}