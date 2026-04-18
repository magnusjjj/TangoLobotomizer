namespace GeneratedNoitaClasses;
public class ArcComponent : NoitaComponentBase,  iNoitaType<ArcComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt type { get; set; } = new();
	public NoitaInt material { get; set; } = new();
	public NoitaInt lifetime { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		type.Read(s);
		material.Read(s);
		lifetime.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		type.Write(s);
		material.Write(s);
		lifetime.Write(s);

    }
}