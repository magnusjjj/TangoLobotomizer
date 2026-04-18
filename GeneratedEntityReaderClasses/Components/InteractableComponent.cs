namespace GeneratedNoitaClasses;
public class InteractableComponent : NoitaComponentBase,  iNoitaType<InteractableComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaString ui_text { get; set; } = new();
	public NoitaString name { get; set; } = new();
	public NoitaInt exclusivity_group { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		ui_text.Read(s);
		name.Read(s);
		exclusivity_group.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		ui_text.Write(s);
		name.Write(s);
		exclusivity_group.Write(s);

    }
}