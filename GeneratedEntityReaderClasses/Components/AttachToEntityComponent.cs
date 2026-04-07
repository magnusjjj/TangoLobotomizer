namespace GeneratedNoitaClasses;
public class AttachToEntityComponent{
	public bool only_position{ get; set; }
	public string target_hotspot_tag{ get; set; }
	public int target_sprite_id{ get; set; }
	public bool rotate_based_on_x_scale{ get; set; }
	public bool destroy_component_when_target_is_gone{ get; set; }
	public CXForm<float> Transform{ get; set; }

}