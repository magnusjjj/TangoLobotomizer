namespace GeneratedNoitaClasses;
public class CollisionTriggerComponent{
	public float width{ get; set; }
	public float height{ get; set; }
	public float radius{ get; set; }
	public string required_tag{ get; set; }
	public bool remove_component_when_triggered{ get; set; }
	public bool destroy_this_entity_when_triggered{ get; set; }
	public int timer_for_destruction{ get; set; }
	public bool self_trigger{ get; set; }
	public int skip_self_frames{ get; set; }

}