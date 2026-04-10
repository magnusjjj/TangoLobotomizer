namespace GeneratedNoitaClasses;
public class TorchComponent {
	public Int32 probability_of_ignition_attempt { get; set; }
	public float suffocation_check_offset_y { get; set; }
	public Int32 frames_suffocated_to_extinguish { get; set; }
	public bool extinguishable { get; set; }
	public float fire_audio_weight { get; set; }

    public void Load(NoitaStream s){
		probability_of_ignition_attempt = s.ReadBeInt32();
		suffocation_check_offset_y = s.ReadBeFloat();
		frames_suffocated_to_extinguish = s.ReadBeInt32();
		extinguishable = s.ReadBool();
		fire_audio_weight = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(probability_of_ignition_attempt);
		s.WriteBeFloat(suffocation_check_offset_y);
		s.WriteBeInt32(frames_suffocated_to_extinguish);
		s.WriteBool(extinguishable);
		s.WriteBeFloat(fire_audio_weight);

    }
}