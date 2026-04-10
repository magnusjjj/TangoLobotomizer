namespace GeneratedNoitaClasses;
public class CutThroughWorldDoneHereComponent {
	public UInt32 id_of_done_cut { get; set; }

    public void Load(NoitaStream s){
		id_of_done_cut = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(id_of_done_cut);

    }
}