namespace GeneratedNoitaClasses;
public class DamageNearbyEntitiesComponent : NoitaComponentBase,  iNoitaType<DamageNearbyEntitiesComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat damage_min { get; set; } = new();
	public NoitaFloat damage_max { get; set; } = new();
	public NoitaFloat target_vec_max_len { get; set; } = new();
	public NoitaFloat knockback_multiplier { get; set; } = new();
	public NoitaInt time_between_damaging { get; set; } = new();
	public NoitaUInt damage_type { get; set; } = new();
	public NoitaString damage_description { get; set; } = new();
	public NoitaString target_tag { get; set; } = new();
	public NoitaUInt ragdoll_fx { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		damage_min.Read(s);
		damage_max.Read(s);
		target_vec_max_len.Read(s);
		knockback_multiplier.Read(s);
		time_between_damaging.Read(s);
		damage_type.Read(s);
		damage_description.Read(s);
		target_tag.Read(s);
		ragdoll_fx.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		damage_min.Write(s);
		damage_max.Write(s);
		target_vec_max_len.Write(s);
		knockback_multiplier.Write(s);
		time_between_damaging.Write(s);
		damage_type.Write(s);
		damage_description.Write(s);
		target_tag.Write(s);
		ragdoll_fx.Write(s);

    }
}