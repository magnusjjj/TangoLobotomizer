namespace GeneratedNoitaClasses;
public class SpriteComponent {
	public string image_file { get; set; }
	public bool ui_is_parent { get; set; }
	public bool is_text_sprite { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }
	public CVector2<float> transform_offset { get; set; }
	public CVector2<float> offset_animator_offset { get; set; }
	public float alpha { get; set; }
	public bool visible { get; set; }
	public bool emissive { get; set; }
	public bool additive { get; set; }
	public bool fog_of_war_hole { get; set; }
	public bool smooth_filtering { get; set; }
	public string rect_animation { get; set; }
	public string next_rect_animation { get; set; }
	public string text { get; set; }
	public float z_index { get; set; }
	public bool update_transform { get; set; }
	public bool update_transform_rotation { get; set; }
	public bool kill_entity_after_finished { get; set; }
	public bool has_special_scale { get; set; }
	public float special_scale_x { get; set; }
	public float special_scale_y { get; set; }
	public bool never_ragdollify_on_death { get; set; }

    public void Load(NoitaStream s){
		image_file = s.ReadBeString();
		ui_is_parent = s.ReadBool();
		is_text_sprite = s.ReadBool();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();
		transform_offset.Load(s);
		offset_animator_offset.Load(s);
		alpha = s.ReadBeFloat();
		visible = s.ReadBool();
		emissive = s.ReadBool();
		additive = s.ReadBool();
		fog_of_war_hole = s.ReadBool();
		smooth_filtering = s.ReadBool();
		rect_animation = s.ReadBeString();
		next_rect_animation = s.ReadBeString();
		text = s.ReadBeString();
		z_index = s.ReadBeFloat();
		update_transform = s.ReadBool();
		update_transform_rotation = s.ReadBool();
		kill_entity_after_finished = s.ReadBool();
		has_special_scale = s.ReadBool();
		special_scale_x = s.ReadBeFloat();
		special_scale_y = s.ReadBeFloat();
		never_ragdollify_on_death = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(image_file);
		s.WriteBool(ui_is_parent);
		s.WriteBool(is_text_sprite);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);
		transform_offset.Write(s);
		offset_animator_offset.Write(s);
		s.WriteBeFloat(alpha);
		s.WriteBool(visible);
		s.WriteBool(emissive);
		s.WriteBool(additive);
		s.WriteBool(fog_of_war_hole);
		s.WriteBool(smooth_filtering);
		s.WriteBeString(rect_animation);
		s.WriteBeString(next_rect_animation);
		s.WriteBeString(text);
		s.WriteBeFloat(z_index);
		s.WriteBool(update_transform);
		s.WriteBool(update_transform_rotation);
		s.WriteBool(kill_entity_after_finished);
		s.WriteBool(has_special_scale);
		s.WriteBeFloat(special_scale_x);
		s.WriteBeFloat(special_scale_y);
		s.WriteBool(never_ragdollify_on_death);

    }
}