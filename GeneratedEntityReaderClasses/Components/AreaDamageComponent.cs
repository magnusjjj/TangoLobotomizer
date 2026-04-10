namespace GeneratedNoitaClasses;
public class AreaDamageComponent {
	public CVector2<float> aabb_min { get; set; }
	public CVector2<float> aabb_max { get; set; }
	public float circle_radius { get; set; }
	public UInt32 damage_type { get; set; }
	public float damage_per_frame { get; set; }
	public Int32 update_every_n_frame { get; set; }
	public UInt32 entity_responsible { get; set; }
	public string death_cause { get; set; }
	public string entities_with_tag { get; set; }

    public void Load(NoitaStream s){
		aabb_min.Load(s);
		aabb_max.Load(s);
		circle_radius = s.ReadBeFloat();
		damage_type = s.ReadBeUInt32();
		damage_per_frame = s.ReadBeFloat();
		update_every_n_frame = s.ReadBeInt32();
		entity_responsible = s.ReadBeUInt32();
		death_cause = s.ReadBeString();
		entities_with_tag = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		aabb_min.Write(s);
		aabb_max.Write(s);
		s.WriteBeFloat(circle_radius);
		s.WriteBeUInt32(damage_type);
		s.WriteBeFloat(damage_per_frame);
		s.WriteBeInt32(update_every_n_frame);
		s.WriteBeUInt32(entity_responsible);
		s.WriteBeString(death_cause);
		s.WriteBeString(entities_with_tag);

    }
}