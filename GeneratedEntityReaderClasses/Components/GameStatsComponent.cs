namespace GeneratedNoitaClasses;
public class GameStatsComponent : NoitaComponentBase,  iNoitaType<GameStatsComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString name { get; set; } = new();
	public NoitaString stats_filename { get; set; } = new();
	public NoitaBool is_player { get; set; } = new();
	public NoitaString extra_death_msg { get; set; } = new();
	public NoitaBool dont_do_logplayerkill { get; set; } = new();
	public NoitaInt player_polymorph_count { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		name.Read(s);
		stats_filename.Read(s);
		is_player.Read(s);
		extra_death_msg.Read(s);
		dont_do_logplayerkill.Read(s);
		player_polymorph_count.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		name.Write(s);
		stats_filename.Write(s);
		is_player.Write(s);
		extra_death_msg.Write(s);
		dont_do_logplayerkill.Write(s);
		player_polymorph_count.Write(s);

    }
}