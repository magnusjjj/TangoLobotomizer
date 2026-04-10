namespace GeneratedNoitaClasses;
public class ExplosionComponent {
	public UInt32 trigger { get; set; }
	public ConfigExplosion config_explosion { get; set; }
	public Int32 timeout_frames { get; set; }
	public Int32 timeout_frames_random { get; set; }
	public bool kill_entity { get; set; }
	public Int32 mTimerTriggerFrame { get; set; }

    public void Load(NoitaStream s){
		trigger = s.ReadBeUInt32();
		config_explosion.Load(s);
		timeout_frames = s.ReadBeInt32();
		timeout_frames_random = s.ReadBeInt32();
		kill_entity = s.ReadBool();
		mTimerTriggerFrame = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(trigger);
		config_explosion.Write(s);
		s.WriteBeInt32(timeout_frames);
		s.WriteBeInt32(timeout_frames_random);
		s.WriteBool(kill_entity);
		s.WriteBeInt32(mTimerTriggerFrame);

    }
}