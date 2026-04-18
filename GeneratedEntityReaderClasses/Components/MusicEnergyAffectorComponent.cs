namespace GeneratedNoitaClasses;
public class MusicEnergyAffectorComponent : NoitaComponentBase,  iNoitaType<MusicEnergyAffectorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat energy_target { get; set; } = new();
	public NoitaFloat fade_range { get; set; } = new();
	public NoitaBool trigger_danger_music { get; set; } = new();
	public NoitaInt fog_of_war_threshold { get; set; } = new();
	public NoitaBool is_enemy { get; set; } = new();
	public NoitaFloat energy_lerp_up_speed_multiplier { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		energy_target.Read(s);
		fade_range.Read(s);
		trigger_danger_music.Read(s);
		fog_of_war_threshold.Read(s);
		is_enemy.Read(s);
		energy_lerp_up_speed_multiplier.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		energy_target.Write(s);
		fade_range.Write(s);
		trigger_danger_music.Write(s);
		fog_of_war_threshold.Write(s);
		is_enemy.Write(s);
		energy_lerp_up_speed_multiplier.Write(s);

    }
}