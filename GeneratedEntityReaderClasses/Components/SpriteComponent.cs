namespace GeneratedNoitaClasses;
public class SpriteComponent{
	public string image_file{ get; set; }
	public bool ui_is_parent{ get; set; }
	public bool is_text_sprite{ get; set; }
	public float offset_x{ get; set; }
	public float offset_y{ get; set; }
	public List<float> transform_offset{ get; set; }
	public List<float> offset_animator_offset{ get; set; }
	public float alpha{ get; set; }
	public bool visible{ get; set; }
	public bool emissive{ get; set; }
	public bool additive{ get; set; }
	public bool fog_of_war_hole{ get; set; }
	public bool smooth_filtering{ get; set; }
	public string rect_animation{ get; set; }
	public string next_rect_animation{ get; set; }
	public string text{ get; set; }
	public float z_index{ get; set; }
	public bool update_transform{ get; set; }
	public bool update_transform_rotation{ get; set; }
	public bool kill_entity_after_finished{ get; set; }
	public bool has_special_scale{ get; set; }
	public float special_scale_x{ get; set; }
	public float special_scale_y{ get; set; }
	public bool never_ragdollify_on_death{ get; set; }

}