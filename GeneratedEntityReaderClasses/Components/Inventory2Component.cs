namespace GeneratedNoitaClasses;
public class Inventory2Component {
	public Int32 quick_inventory_slots { get; set; }
	public Int32 full_inventory_slots_x { get; set; }
	public Int32 full_inventory_slots_y { get; set; }
	public UInt32 mSavedActiveItemIndex { get; set; }

    public void Load(NoitaStream s){
		quick_inventory_slots = s.ReadBeInt32();
		full_inventory_slots_x = s.ReadBeInt32();
		full_inventory_slots_y = s.ReadBeInt32();
		mSavedActiveItemIndex = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(quick_inventory_slots);
		s.WriteBeInt32(full_inventory_slots_x);
		s.WriteBeInt32(full_inventory_slots_y);
		s.WriteBeUInt32(mSavedActiveItemIndex);

    }
}