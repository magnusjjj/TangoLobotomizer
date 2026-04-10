namespace GeneratedNoitaClasses;
public class ItemCostComponent {
	public Int64 cost { get; set; }
	public bool stealable { get; set; }

    public void Load(NoitaStream s){
		cost = s.ReadBeInt64();
		stealable = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt64(cost);
		s.WriteBool(stealable);

    }
}