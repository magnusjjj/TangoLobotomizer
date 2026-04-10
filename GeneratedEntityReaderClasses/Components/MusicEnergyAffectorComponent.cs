namespace GeneratedNoitaClasses;
public class MusicEnergyAffectorComponent {
	public float energy_target { get; set; }
	public float fade_range { get; set; }
	public bool trigger_danger_music { get; set; }
	public Int32 fog_of_war_threshold { get; set; }
	public bool is_enemy { get; set; }
	public float energy_lerp_up_speed_multiplier { get; set; }

    public void Load(NoitaStream s){
		energy_target = s.ReadBeFloat();
		fade_range = s.ReadBeFloat();
		trigger_danger_music = s.ReadBool();
		fog_of_war_threshold = s.ReadBeInt32();
		is_enemy = s.ReadBool();
		energy_lerp_up_speed_multiplier = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(energy_target);
		s.WriteBeFloat(fade_range);
		s.WriteBool(trigger_danger_music);
		s.WriteBeInt32(fog_of_war_threshold);
		s.WriteBool(is_enemy);
		s.WriteBeFloat(energy_lerp_up_speed_multiplier);

    }
}