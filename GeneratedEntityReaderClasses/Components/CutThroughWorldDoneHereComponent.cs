namespace GeneratedNoitaClasses;
public class CutThroughWorldDoneHereComponent : NoitaComponentBase,  iNoitaType<CutThroughWorldDoneHereComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt id_of_done_cut { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		id_of_done_cut.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		id_of_done_cut.Write(s);

    }
}