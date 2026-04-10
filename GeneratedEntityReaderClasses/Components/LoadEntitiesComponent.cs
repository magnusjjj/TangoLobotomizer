namespace GeneratedNoitaClasses;
public class LoadEntitiesComponent {
	public string entity_file { get; set; }
	public ValueRangeInt count { get; set; }
	public bool kill_entity { get; set; }
	public Int32 timeout_frames { get; set; }
	public Int32 mTimerTriggerFrame { get; set; }

    public void Load(NoitaStream s){
		entity_file = s.ReadBeString();
		count.Load(s);
		kill_entity = s.ReadBool();
		timeout_frames = s.ReadBeInt32();
		mTimerTriggerFrame = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(entity_file);
		count.Write(s);
		s.WriteBool(kill_entity);
		s.WriteBeInt32(timeout_frames);
		s.WriteBeInt32(mTimerTriggerFrame);

    }
}