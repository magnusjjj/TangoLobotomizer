namespace GeneratedNoitaClasses;
public class HotspotComponent : NoitaComponentBase,  iNoitaType<HotspotComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCVector2<NoitaFloat> offset { get; set; } = new();
	public NoitaBool transform_with_scale { get; set; } = new();
	public NoitaString sprite_hotspot_name { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		offset.Read(s);
		transform_with_scale.Read(s);
		sprite_hotspot_name.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		offset.Write(s);
		transform_with_scale.Write(s);
		sprite_hotspot_name.Write(s);

    }
}