namespace GeneratedNoitaClasses;
public class CollisionTriggerComponent : NoitaComponentBase,  iNoitaType<CollisionTriggerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat width { get; set; } = new();
	public NoitaFloat height { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaString required_tag { get; set; } = new();
	public NoitaBool remove_component_when_triggered { get; set; } = new();
	public NoitaBool destroy_this_entity_when_triggered { get; set; } = new();
	public NoitaInt timer_for_destruction { get; set; } = new();
	public NoitaBool self_trigger { get; set; } = new();
	public NoitaInt skip_self_frames { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		width.Read(s);
		height.Read(s);
		radius.Read(s);
		required_tag.Read(s);
		remove_component_when_triggered.Read(s);
		destroy_this_entity_when_triggered.Read(s);
		timer_for_destruction.Read(s);
		self_trigger.Read(s);
		skip_self_frames.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		width.Write(s);
		height.Write(s);
		radius.Write(s);
		required_tag.Write(s);
		remove_component_when_triggered.Write(s);
		destroy_this_entity_when_triggered.Write(s);
		timer_for_destruction.Write(s);
		self_trigger.Write(s);
		skip_self_frames.Write(s);

    }
}