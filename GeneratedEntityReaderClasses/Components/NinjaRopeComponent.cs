namespace GeneratedNoitaClasses;
public class NinjaRopeComponent : NoitaComponentBase,  iNoitaType<NinjaRopeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat max_length { get; set; } = new();
	public NoitaFloat mLength { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		max_length.Read(s);
		mLength.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		max_length.Write(s);
		mLength.Write(s);

    }
}