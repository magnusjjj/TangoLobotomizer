namespace GeneratedNoitaClasses;
public class TorchComponent : NoitaComponentBase,  iNoitaType<TorchComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt probability_of_ignition_attempt { get; set; } = new();
	public NoitaFloat suffocation_check_offset_y { get; set; } = new();
	public NoitaInt frames_suffocated_to_extinguish { get; set; } = new();
	public NoitaBool extinguishable { get; set; } = new();
	public NoitaFloat fire_audio_weight { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		probability_of_ignition_attempt.Read(s);
		suffocation_check_offset_y.Read(s);
		frames_suffocated_to_extinguish.Read(s);
		extinguishable.Read(s);
		fire_audio_weight.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		probability_of_ignition_attempt.Write(s);
		suffocation_check_offset_y.Write(s);
		frames_suffocated_to_extinguish.Write(s);
		extinguishable.Write(s);
		fire_audio_weight.Write(s);

    }
}