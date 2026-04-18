namespace GeneratedNoitaClasses;
public class GenomeDataComponent : NoitaComponentBase,  iNoitaType<GenomeDataComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaLensValue<NoitaInt> herd_id { get; set; } = new();
	public NoitaBool is_predator { get; set; } = new();
	public NoitaFloat food_chain_rank { get; set; } = new();
	public NoitaBool berserk_dont_attack_friends { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		herd_id.Read(s);
		is_predator.Read(s);
		food_chain_rank.Read(s);
		berserk_dont_attack_friends.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		herd_id.Write(s);
		is_predator.Write(s);
		food_chain_rank.Write(s);
		berserk_dont_attack_friends.Write(s);

    }
}