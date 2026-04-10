namespace GeneratedNoitaClasses;
public class AttachToEntityComponent {
	public bool only_position { get; set; }
	public string target_hotspot_tag { get; set; }
	public Int32 target_sprite_id { get; set; }
	public bool rotate_based_on_x_scale { get; set; }
	public bool destroy_component_when_target_is_gone { get; set; }
	public CXForm<float> Transform { get; set; }

    public void Load(NoitaStream s){
		only_position = s.ReadBool();
		target_hotspot_tag = s.ReadBeString();
		target_sprite_id = s.ReadBeInt32();
		rotate_based_on_x_scale = s.ReadBool();
		destroy_component_when_target_is_gone = s.ReadBool();
		Transform.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBool(only_position);
		s.WriteBeString(target_hotspot_tag);
		s.WriteBeInt32(target_sprite_id);
		s.WriteBool(rotate_based_on_x_scale);
		s.WriteBool(destroy_component_when_target_is_gone);
		Transform.Write(s);

    }
}