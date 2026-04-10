namespace GeneratedNoitaClasses;
public class ShotEffectComponent {
	public UInt32 condition_effect { get; set; }
	public UInt32 condition_status { get; set; }
	public string extra_modifier { get; set; }

    public void Load(NoitaStream s){
		condition_effect = s.ReadBeUInt32();
		condition_status = s.ReadBeUInt32();
		extra_modifier = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(condition_effect);
		s.WriteBeUInt32(condition_status);
		s.WriteBeString(extra_modifier);

    }
}