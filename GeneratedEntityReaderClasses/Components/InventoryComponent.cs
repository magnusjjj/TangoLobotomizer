namespace GeneratedNoitaClasses;
public class InventoryComponent : NoitaComponentBase,  iNoitaType<InventoryComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt ui_container_type { get; set; } = new();
	public NoitaCVector2<NoitaInt> ui_container_size { get; set; } = new();
	public NoitaCVector2<NoitaInt> ui_element_size { get; set; } = new();
	public NoitaCVector2<NoitaInt> ui_position_on_screen { get; set; } = new();
	public NoitaString ui_element_sprite { get; set; } = new();
	public NoitaString actions { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		ui_container_type.Read(s);
		ui_container_size.Read(s);
		ui_element_size.Read(s);
		ui_position_on_screen.Read(s);
		ui_element_sprite.Read(s);
		actions.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		ui_container_type.Write(s);
		ui_container_size.Write(s);
		ui_element_size.Write(s);
		ui_position_on_screen.Write(s);
		ui_element_sprite.Write(s);
		actions.Write(s);

    }
}