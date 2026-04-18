namespace GeneratedNoitaClasses;
public class PhysicsRagdollComponent : NoitaComponentBase,  iNoitaType<PhysicsRagdollComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString filename { get; set; } = new();
	public NoitaString filenames { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		filename.Read(s);
		filenames.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		filename.Write(s);
		filenames.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);

    }
}