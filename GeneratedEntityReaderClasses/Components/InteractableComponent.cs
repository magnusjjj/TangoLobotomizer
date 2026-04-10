namespace GeneratedNoitaClasses;
public class InteractableComponent {
	public float radius { get; set; }
	public string ui_text { get; set; }
	public string name { get; set; }
	public Int32 exclusivity_group { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		ui_text = s.ReadBeString();
		name = s.ReadBeString();
		exclusivity_group = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeString(ui_text);
		s.WriteBeString(name);
		s.WriteBeInt32(exclusivity_group);

    }
}