namespace GeneratedNoitaClasses;
public class AreaDamageComponent : NoitaComponentBase,  iNoitaType<AreaDamageComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_min { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_max { get; set; } = new();
	public NoitaFloat circle_radius { get; set; } = new();
	public NoitaUInt damage_type { get; set; } = new();
	public NoitaFloat damage_per_frame { get; set; } = new();
	public NoitaInt update_every_n_frame { get; set; } = new();
	public NoitaUInt entity_responsible { get; set; } = new();
	public NoitaString death_cause { get; set; } = new();
	public NoitaString entities_with_tag { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		aabb_min.Read(s);
		aabb_max.Read(s);
		circle_radius.Read(s);
		damage_type.Read(s);
		damage_per_frame.Read(s);
		update_every_n_frame.Read(s);
		entity_responsible.Read(s);
		death_cause.Read(s);
		entities_with_tag.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		aabb_min.Write(s);
		aabb_max.Write(s);
		circle_radius.Write(s);
		damage_type.Write(s);
		damage_per_frame.Write(s);
		update_every_n_frame.Write(s);
		entity_responsible.Write(s);
		death_cause.Write(s);
		entities_with_tag.Write(s);

    }
}