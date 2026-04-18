namespace GeneratedNoitaClasses;
public class InheritTransformComponent : NoitaComponentBase,  iNoitaType<InheritTransformComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool use_root_parent { get; set; } = new();
	public NoitaBool only_position { get; set; } = new();
	public NoitaString parent_hotspot_tag { get; set; } = new();
	public NoitaInt parent_sprite_id { get; set; } = new();
	public NoitaBool always_use_immediate_parent_rotation { get; set; } = new();
	public NoitaBool rotate_based_on_x_scale { get; set; } = new();
	public NoitaCXForm<NoitaFloat> Transform { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		use_root_parent.Read(s);
		only_position.Read(s);
		parent_hotspot_tag.Read(s);
		parent_sprite_id.Read(s);
		always_use_immediate_parent_rotation.Read(s);
		rotate_based_on_x_scale.Read(s);
		Transform.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		use_root_parent.Write(s);
		only_position.Write(s);
		parent_hotspot_tag.Write(s);
		parent_sprite_id.Write(s);
		always_use_immediate_parent_rotation.Write(s);
		rotate_based_on_x_scale.Write(s);
		Transform.Write(s);

    }
}