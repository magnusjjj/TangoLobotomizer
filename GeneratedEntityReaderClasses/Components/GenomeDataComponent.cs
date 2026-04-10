namespace GeneratedNoitaClasses;
public class GenomeDataComponent {
	public LensValue<int> herd_id { get; set; }
	public bool is_predator { get; set; }
	public float food_chain_rank { get; set; }
	public bool berserk_dont_attack_friends { get; set; }

    public void Load(NoitaStream s){
		herd_id.Load(s);
		is_predator = s.ReadBool();
		food_chain_rank = s.ReadBeFloat();
		berserk_dont_attack_friends = s.ReadBool();

    }
    public void Save(NoitaStream s){
		herd_id.Write(s);
		s.WriteBool(is_predator);
		s.WriteBeFloat(food_chain_rank);
		s.WriteBool(berserk_dont_attack_friends);

    }
}