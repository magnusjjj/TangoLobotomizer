namespace GeneratedNoitaClasses;
public class AreaDamageComponent{
	public List<float> aabb_min{ get; set; }
	public List<float> aabb_max{ get; set; }
	public float circle_radius{ get; set; }
	public DAMAGE_TYPES damage_type{ get; set; }
	public float damage_per_frame{ get; set; }
	public int update_every_n_frame{ get; set; }
	public UInt32 entity_responsible{ get; set; }
	public string death_cause{ get; set; }
	public string entities_with_tag{ get; set; }

}