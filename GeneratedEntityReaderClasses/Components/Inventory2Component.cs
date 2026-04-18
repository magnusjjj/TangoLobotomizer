namespace GeneratedNoitaClasses;
public class Inventory2Component : NoitaComponentBase,  iNoitaType<Inventory2Component>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt quick_inventory_slots { get; set; } = new();
	public NoitaInt full_inventory_slots_x { get; set; } = new();
	public NoitaInt full_inventory_slots_y { get; set; } = new();
	public NoitaUInt mSavedActiveItemIndex { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		quick_inventory_slots.Read(s);
		full_inventory_slots_x.Read(s);
		full_inventory_slots_y.Read(s);
		mSavedActiveItemIndex.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		quick_inventory_slots.Write(s);
		full_inventory_slots_x.Write(s);
		full_inventory_slots_y.Write(s);
		mSavedActiveItemIndex.Write(s);

    }
}