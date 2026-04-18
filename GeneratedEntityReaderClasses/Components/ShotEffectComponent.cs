namespace GeneratedNoitaClasses;
public class ShotEffectComponent : NoitaComponentBase,  iNoitaType<ShotEffectComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt condition_effect { get; set; } = new();
	public NoitaUInt condition_status { get; set; } = new();
	public NoitaString extra_modifier { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		condition_effect.Read(s);
		condition_status.Read(s);
		extra_modifier.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		condition_effect.Write(s);
		condition_status.Write(s);
		extra_modifier.Write(s);

    }
}