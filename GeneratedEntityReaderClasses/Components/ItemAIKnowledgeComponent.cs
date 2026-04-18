namespace GeneratedNoitaClasses;
public class ItemAIKnowledgeComponent : NoitaComponentBase,  iNoitaType<ItemAIKnowledgeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool is_ranged_weapon { get; set; } = new();
	public NoitaBool is_throwable_weapon { get; set; } = new();
	public NoitaBool is_melee_weapon { get; set; } = new();
	public NoitaBool is_self_healing { get; set; } = new();
	public NoitaBool is_other_healing { get; set; } = new();
	public NoitaBool is_self_buffing { get; set; } = new();
	public NoitaBool is_other_buffing { get; set; } = new();
	public NoitaBool is_weapon { get; set; } = new();
	public NoitaBool is_known { get; set; } = new();
	public NoitaBool is_safe { get; set; } = new();
	public NoitaBool is_consumed { get; set; } = new();
	public NoitaBool never_use { get; set; } = new();
	public NoitaFloat ranged_min_distance { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		is_ranged_weapon.Read(s);
		is_throwable_weapon.Read(s);
		is_melee_weapon.Read(s);
		is_self_healing.Read(s);
		is_other_healing.Read(s);
		is_self_buffing.Read(s);
		is_other_buffing.Read(s);
		is_weapon.Read(s);
		is_known.Read(s);
		is_safe.Read(s);
		is_consumed.Read(s);
		never_use.Read(s);
		ranged_min_distance.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		is_ranged_weapon.Write(s);
		is_throwable_weapon.Write(s);
		is_melee_weapon.Write(s);
		is_self_healing.Write(s);
		is_other_healing.Write(s);
		is_self_buffing.Write(s);
		is_other_buffing.Write(s);
		is_weapon.Write(s);
		is_known.Write(s);
		is_safe.Write(s);
		is_consumed.Write(s);
		never_use.Write(s);
		ranged_min_distance.Write(s);

    }
}