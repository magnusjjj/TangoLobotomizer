namespace GeneratedNoitaClasses;
public class CollisionTriggerComponent {
	public float width { get; set; }
	public float height { get; set; }
	public float radius { get; set; }
	public string required_tag { get; set; }
	public bool remove_component_when_triggered { get; set; }
	public bool destroy_this_entity_when_triggered { get; set; }
	public Int32 timer_for_destruction { get; set; }
	public bool self_trigger { get; set; }
	public Int32 skip_self_frames { get; set; }

    public void Load(NoitaStream s){
		width = s.ReadBeFloat();
		height = s.ReadBeFloat();
		radius = s.ReadBeFloat();
		required_tag = s.ReadBeString();
		remove_component_when_triggered = s.ReadBool();
		destroy_this_entity_when_triggered = s.ReadBool();
		timer_for_destruction = s.ReadBeInt32();
		self_trigger = s.ReadBool();
		skip_self_frames = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(width);
		s.WriteBeFloat(height);
		s.WriteBeFloat(radius);
		s.WriteBeString(required_tag);
		s.WriteBool(remove_component_when_triggered);
		s.WriteBool(destroy_this_entity_when_triggered);
		s.WriteBeInt32(timer_for_destruction);
		s.WriteBool(self_trigger);
		s.WriteBeInt32(skip_self_frames);

    }
}