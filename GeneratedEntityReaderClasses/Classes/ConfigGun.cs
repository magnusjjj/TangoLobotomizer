namespace GeneratedNoitaClasses;
public class ConfigGun :  iNoitaType<ConfigGun>{
	public NoitaInt actions_per_round { get; set; } = new();
	public NoitaBool shuffle_deck_when_empty { get; set; } = new();
	public NoitaInt reload_time { get; set; } = new();
	public NoitaInt deck_capacity { get; set; } = new();

    public void Read(NoitaStream s){
		actions_per_round.Read(s);
		shuffle_deck_when_empty.Read(s);
		reload_time.Read(s);
		deck_capacity.Read(s);

    }
    public void Write(NoitaStream s){
		actions_per_round.Write(s);
		shuffle_deck_when_empty.Write(s);
		reload_time.Write(s);
		deck_capacity.Write(s);

    }
}