namespace GeneratedNoitaClasses;
public class MagicXRayComponent : NoitaComponentBase,  iNoitaType<MagicXRayComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt radius { get; set; } = new();
	public NoitaInt steps_per_frame { get; set; } = new();
	public NoitaInt mStep { get; set; } = new();
	public NoitaInt mRadius { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		steps_per_frame.Read(s);
		mStep.Read(s);
		mRadius.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		steps_per_frame.Write(s);
		mStep.Write(s);
		mRadius.Write(s);

    }
}