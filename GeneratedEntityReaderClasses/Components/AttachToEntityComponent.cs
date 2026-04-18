namespace GeneratedNoitaClasses;
public class AttachToEntityComponent : NoitaComponentBase,  iNoitaType<AttachToEntityComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool only_position { get; set; } = new();
	public NoitaString target_hotspot_tag { get; set; } = new();
	public NoitaInt target_sprite_id { get; set; } = new();
	public NoitaBool rotate_based_on_x_scale { get; set; } = new();
	public NoitaBool destroy_component_when_target_is_gone { get; set; } = new();
	public NoitaCXForm<NoitaFloat> Transform { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		only_position.Read(s);
		target_hotspot_tag.Read(s);
		target_sprite_id.Read(s);
		rotate_based_on_x_scale.Read(s);
		destroy_component_when_target_is_gone.Read(s);
		Transform.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		only_position.Write(s);
		target_hotspot_tag.Write(s);
		target_sprite_id.Write(s);
		rotate_based_on_x_scale.Write(s);
		destroy_component_when_target_is_gone.Write(s);
		Transform.Write(s);

    }
}