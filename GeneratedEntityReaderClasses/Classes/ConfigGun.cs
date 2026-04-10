namespace GeneratedNoitaClasses;
public class ConfigGun {
	public Int32 actions_per_round { get; set; }
	public bool shuffle_deck_when_empty { get; set; }
	public Int32 reload_time { get; set; }
	public Int32 deck_capacity { get; set; }

    public void Load(NoitaStream s){
		actions_per_round = s.ReadBeInt32();
		shuffle_deck_when_empty = s.ReadBool();
		reload_time = s.ReadBeInt32();
		deck_capacity = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(actions_per_round);
		s.WriteBool(shuffle_deck_when_empty);
		s.WriteBeInt32(reload_time);
		s.WriteBeInt32(deck_capacity);

    }
}