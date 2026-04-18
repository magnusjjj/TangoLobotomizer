namespace GeneratedNoitaClasses;
public class ExplosionComponent : NoitaComponentBase,  iNoitaType<ExplosionComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt trigger { get; set; } = new();
	public ConfigExplosion config_explosion { get; set; } = new();
	public NoitaInt timeout_frames { get; set; } = new();
	public NoitaInt timeout_frames_random { get; set; } = new();
	public NoitaBool kill_entity { get; set; } = new();
	public NoitaInt mTimerTriggerFrame { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		trigger.Read(s);
		config_explosion.Read(s);
		timeout_frames.Read(s);
		timeout_frames_random.Read(s);
		kill_entity.Read(s);
		mTimerTriggerFrame.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		trigger.Write(s);
		config_explosion.Write(s);
		timeout_frames.Write(s);
		timeout_frames_random.Write(s);
		kill_entity.Write(s);
		mTimerTriggerFrame.Write(s);

    }
}