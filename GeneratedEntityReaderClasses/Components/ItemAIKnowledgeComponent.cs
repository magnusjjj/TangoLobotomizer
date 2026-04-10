namespace GeneratedNoitaClasses;
public class ItemAIKnowledgeComponent {
	public bool is_ranged_weapon { get; set; }
	public bool is_throwable_weapon { get; set; }
	public bool is_melee_weapon { get; set; }
	public bool is_self_healing { get; set; }
	public bool is_other_healing { get; set; }
	public bool is_self_buffing { get; set; }
	public bool is_other_buffing { get; set; }
	public bool is_weapon { get; set; }
	public bool is_known { get; set; }
	public bool is_safe { get; set; }
	public bool is_consumed { get; set; }
	public bool never_use { get; set; }
	public float ranged_min_distance { get; set; }

    public void Load(NoitaStream s){
		is_ranged_weapon = s.ReadBool();
		is_throwable_weapon = s.ReadBool();
		is_melee_weapon = s.ReadBool();
		is_self_healing = s.ReadBool();
		is_other_healing = s.ReadBool();
		is_self_buffing = s.ReadBool();
		is_other_buffing = s.ReadBool();
		is_weapon = s.ReadBool();
		is_known = s.ReadBool();
		is_safe = s.ReadBool();
		is_consumed = s.ReadBool();
		never_use = s.ReadBool();
		ranged_min_distance = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_ranged_weapon);
		s.WriteBool(is_throwable_weapon);
		s.WriteBool(is_melee_weapon);
		s.WriteBool(is_self_healing);
		s.WriteBool(is_other_healing);
		s.WriteBool(is_self_buffing);
		s.WriteBool(is_other_buffing);
		s.WriteBool(is_weapon);
		s.WriteBool(is_known);
		s.WriteBool(is_safe);
		s.WriteBool(is_consumed);
		s.WriteBool(never_use);
		s.WriteBeFloat(ranged_min_distance);

    }
}