namespace GeneratedNoitaClasses;
public class GameStatsComponent {
	public string name { get; set; }
	public string stats_filename { get; set; }
	public bool is_player { get; set; }
	public string extra_death_msg { get; set; }
	public bool dont_do_logplayerkill { get; set; }
	public Int32 player_polymorph_count { get; set; }

    public void Load(NoitaStream s){
		name = s.ReadBeString();
		stats_filename = s.ReadBeString();
		is_player = s.ReadBool();
		extra_death_msg = s.ReadBeString();
		dont_do_logplayerkill = s.ReadBool();
		player_polymorph_count = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(name);
		s.WriteBeString(stats_filename);
		s.WriteBool(is_player);
		s.WriteBeString(extra_death_msg);
		s.WriteBool(dont_do_logplayerkill);
		s.WriteBeInt32(player_polymorph_count);

    }
}