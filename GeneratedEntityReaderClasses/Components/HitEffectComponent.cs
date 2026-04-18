namespace GeneratedNoitaClasses;
public class HitEffectComponent : NoitaComponentBase,  iNoitaType<HitEffectComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt condition_effect { get; set; } = new();
	public NoitaUInt condition_status { get; set; } = new();
	public NoitaUInt effect_hit { get; set; } = new();
	public NoitaInt value { get; set; } = new();
	public NoitaString value_string { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		condition_effect.Read(s);
		condition_status.Read(s);
		effect_hit.Read(s);
		value.Read(s);
		value_string.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		condition_effect.Write(s);
		condition_status.Write(s);
		effect_hit.Write(s);
		value.Write(s);
		value_string.Write(s);

    }
}