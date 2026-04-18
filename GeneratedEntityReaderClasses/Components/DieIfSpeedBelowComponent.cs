namespace GeneratedNoitaClasses;
public class DieIfSpeedBelowComponent : NoitaComponentBase,  iNoitaType<DieIfSpeedBelowComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat min_speed { get; set; } = new();
	public NoitaFloat mMinSpeedSquared { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		min_speed.Read(s);
		mMinSpeedSquared.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		min_speed.Write(s);
		mMinSpeedSquared.Write(s);

    }
}