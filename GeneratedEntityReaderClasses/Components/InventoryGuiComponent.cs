namespace GeneratedNoitaClasses;
public class InventoryGuiComponent : NoitaComponentBase,  iNoitaType<InventoryGuiComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool has_opened_inventory_edit { get; set; } = new();
	public NoitaInt wallet_money_target { get; set; } = new();
	public NoitaBool mDisplayFireRateWaitBar { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		has_opened_inventory_edit.Read(s);
		wallet_money_target.Read(s);
		mDisplayFireRateWaitBar.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		has_opened_inventory_edit.Write(s);
		wallet_money_target.Write(s);
		mDisplayFireRateWaitBar.Write(s);

    }
}