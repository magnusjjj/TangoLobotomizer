namespace GeneratedNoitaClasses;
public class InventoryComponent {
	public Int32 ui_container_type { get; set; }
	public CVector2<int> ui_container_size { get; set; }
	public CVector2<int> ui_element_size { get; set; }
	public CVector2<int> ui_position_on_screen { get; set; }
	public string ui_element_sprite { get; set; }
	public string actions { get; set; }

    public void Load(NoitaStream s){
		ui_container_type = s.ReadBeInt32();
		ui_container_size.Load(s);
		ui_element_size.Load(s);
		ui_position_on_screen.Load(s);
		ui_element_sprite = s.ReadBeString();
		actions = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(ui_container_type);
		ui_container_size.Write(s);
		ui_element_size.Write(s);
		ui_position_on_screen.Write(s);
		s.WriteBeString(ui_element_sprite);
		s.WriteBeString(actions);

    }
}