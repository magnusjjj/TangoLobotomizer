namespace GeneratedNoitaClasses;
public class LimbBossComponent {
	public Int32 state { get; set; }

    public void Load(NoitaStream s){
		state = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(state);

    }
}