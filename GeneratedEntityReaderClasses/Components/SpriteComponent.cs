namespace GeneratedNoitaClasses;
public class SpriteComponent : NoitaComponentBase,  iNoitaType<SpriteComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString image_file { get; set; } = new();
	public NoitaBool ui_is_parent { get; set; } = new();
	public NoitaBool is_text_sprite { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();
	public NoitaCVector2<NoitaFloat> transform_offset { get; set; } = new();
	public NoitaCVector2<NoitaFloat> offset_animator_offset { get; set; } = new();
	public NoitaFloat alpha { get; set; } = new();
	public NoitaBool visible { get; set; } = new();
	public NoitaBool emissive { get; set; } = new();
	public NoitaBool additive { get; set; } = new();
	public NoitaBool fog_of_war_hole { get; set; } = new();
	public NoitaBool smooth_filtering { get; set; } = new();
	public NoitaString rect_animation { get; set; } = new();
	public NoitaString next_rect_animation { get; set; } = new();
	public NoitaString text { get; set; } = new();
	public NoitaFloat z_index { get; set; } = new();
	public NoitaBool update_transform { get; set; } = new();
	public NoitaBool update_transform_rotation { get; set; } = new();
	public NoitaBool kill_entity_after_finished { get; set; } = new();
	public NoitaBool has_special_scale { get; set; } = new();
	public NoitaFloat special_scale_x { get; set; } = new();
	public NoitaFloat special_scale_y { get; set; } = new();
	public NoitaBool never_ragdollify_on_death { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		image_file.Read(s);
		ui_is_parent.Read(s);
		is_text_sprite.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		transform_offset.Read(s);
		offset_animator_offset.Read(s);
		alpha.Read(s);
		visible.Read(s);
		emissive.Read(s);
		additive.Read(s);
		fog_of_war_hole.Read(s);
		smooth_filtering.Read(s);
		rect_animation.Read(s);
		next_rect_animation.Read(s);
		text.Read(s);
		z_index.Read(s);
		update_transform.Read(s);
		update_transform_rotation.Read(s);
		kill_entity_after_finished.Read(s);
		has_special_scale.Read(s);
		special_scale_x.Read(s);
		special_scale_y.Read(s);
		never_ragdollify_on_death.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		image_file.Write(s);
		ui_is_parent.Write(s);
		is_text_sprite.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		transform_offset.Write(s);
		offset_animator_offset.Write(s);
		alpha.Write(s);
		visible.Write(s);
		emissive.Write(s);
		additive.Write(s);
		fog_of_war_hole.Write(s);
		smooth_filtering.Write(s);
		rect_animation.Write(s);
		next_rect_animation.Write(s);
		text.Write(s);
		z_index.Write(s);
		update_transform.Write(s);
		update_transform_rotation.Write(s);
		kill_entity_after_finished.Write(s);
		has_special_scale.Write(s);
		special_scale_x.Write(s);
		special_scale_y.Write(s);
		never_ragdollify_on_death.Write(s);

    }
}