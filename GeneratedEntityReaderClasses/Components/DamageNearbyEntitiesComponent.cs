namespace GeneratedNoitaClasses;
public class DamageNearbyEntitiesComponent{
	public float radius{ get; set; }
	public float damage_min{ get; set; }
	public float damage_max{ get; set; }
	public float target_vec_max_len{ get; set; }
	public float knockback_multiplier{ get; set; }
	public int time_between_damaging{ get; set; }
	public DAMAGE_TYPES damage_type{ get; set; }
	public string damage_description{ get; set; }
	public string target_tag{ get; set; }
	public RAGDOLL_FX ragdoll_fx{ get; set; }

}