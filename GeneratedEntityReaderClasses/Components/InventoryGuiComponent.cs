namespace GeneratedNoitaClasses;
public class InventoryGuiComponent {
	public bool has_opened_inventory_edit { get; set; }
	public Int32 wallet_money_target { get; set; }
	public bool mDisplayFireRateWaitBar { get; set; }

    public void Load(NoitaStream s){
		has_opened_inventory_edit = s.ReadBool();
		wallet_money_target = s.ReadBeInt32();
		mDisplayFireRateWaitBar = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(has_opened_inventory_edit);
		s.WriteBeInt32(wallet_money_target);
		s.WriteBool(mDisplayFireRateWaitBar);

    }
}