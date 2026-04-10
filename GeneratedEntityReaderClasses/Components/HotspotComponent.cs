namespace GeneratedNoitaClasses;
public class HotspotComponent {
	public CVector2<float> offset { get; set; }
	public bool transform_with_scale { get; set; }
	public string sprite_hotspot_name { get; set; }

    public void Load(NoitaStream s){
		offset.Load(s);
		transform_with_scale = s.ReadBool();
		sprite_hotspot_name = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		offset.Write(s);
		s.WriteBool(transform_with_scale);
		s.WriteBeString(sprite_hotspot_name);

    }
}