namespace GeneratedNoitaClasses;
public class InheritTransformComponent{
	public bool use_root_parent{ get; set; }
	public bool only_position{ get; set; }
	public string parent_hotspot_tag{ get; set; }
	public int parent_sprite_id{ get; set; }
	public bool always_use_immediate_parent_rotation{ get; set; }
	public bool rotate_based_on_x_scale{ get; set; }
	public CXForm<float> Transform{ get; set; }

}