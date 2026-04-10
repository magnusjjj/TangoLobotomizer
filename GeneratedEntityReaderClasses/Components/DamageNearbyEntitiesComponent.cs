namespace GeneratedNoitaClasses;
public class DamageNearbyEntitiesComponent {
	public float radius { get; set; }
	public float damage_min { get; set; }
	public float damage_max { get; set; }
	public float target_vec_max_len { get; set; }
	public float knockback_multiplier { get; set; }
	public Int32 time_between_damaging { get; set; }
	public UInt32 damage_type { get; set; }
	public string damage_description { get; set; }
	public string target_tag { get; set; }
	public UInt32 ragdoll_fx { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		damage_min = s.ReadBeFloat();
		damage_max = s.ReadBeFloat();
		target_vec_max_len = s.ReadBeFloat();
		knockback_multiplier = s.ReadBeFloat();
		time_between_damaging = s.ReadBeInt32();
		damage_type = s.ReadBeUInt32();
		damage_description = s.ReadBeString();
		target_tag = s.ReadBeString();
		ragdoll_fx = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeFloat(damage_min);
		s.WriteBeFloat(damage_max);
		s.WriteBeFloat(target_vec_max_len);
		s.WriteBeFloat(knockback_multiplier);
		s.WriteBeInt32(time_between_damaging);
		s.WriteBeUInt32(damage_type);
		s.WriteBeString(damage_description);
		s.WriteBeString(target_tag);
		s.WriteBeUInt32(ragdoll_fx);

    }
}