namespace GeneratedNoitaClasses;
public class InheritTransformComponent {
	public bool use_root_parent { get; set; }
	public bool only_position { get; set; }
	public string parent_hotspot_tag { get; set; }
	public Int32 parent_sprite_id { get; set; }
	public bool always_use_immediate_parent_rotation { get; set; }
	public bool rotate_based_on_x_scale { get; set; }
	public CXForm<float> Transform { get; set; }

    public void Load(NoitaStream s){
		use_root_parent = s.ReadBool();
		only_position = s.ReadBool();
		parent_hotspot_tag = s.ReadBeString();
		parent_sprite_id = s.ReadBeInt32();
		always_use_immediate_parent_rotation = s.ReadBool();
		rotate_based_on_x_scale = s.ReadBool();
		Transform.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBool(use_root_parent);
		s.WriteBool(only_position);
		s.WriteBeString(parent_hotspot_tag);
		s.WriteBeInt32(parent_sprite_id);
		s.WriteBool(always_use_immediate_parent_rotation);
		s.WriteBool(rotate_based_on_x_scale);
		Transform.Write(s);

    }
}