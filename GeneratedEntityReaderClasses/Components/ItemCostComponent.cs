namespace GeneratedNoitaClasses;
public class ItemCostComponent : NoitaComponentBase,  iNoitaType<ItemCostComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt64 cost { get; set; } = new();
	public NoitaBool stealable { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		cost.Read(s);
		stealable.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		cost.Write(s);
		stealable.Write(s);

    }
}