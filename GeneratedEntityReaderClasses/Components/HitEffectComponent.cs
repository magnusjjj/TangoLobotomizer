namespace GeneratedNoitaClasses;
public class HitEffectComponent {
	public UInt32 condition_effect { get; set; }
	public UInt32 condition_status { get; set; }
	public UInt32 effect_hit { get; set; }
	public Int32 value { get; set; }
	public string value_string { get; set; }

    public void Load(NoitaStream s){
		condition_effect = s.ReadBeUInt32();
		condition_status = s.ReadBeUInt32();
		effect_hit = s.ReadBeUInt32();
		value = s.ReadBeInt32();
		value_string = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(condition_effect);
		s.WriteBeUInt32(condition_status);
		s.WriteBeUInt32(effect_hit);
		s.WriteBeInt32(value);
		s.WriteBeString(value_string);

    }
}