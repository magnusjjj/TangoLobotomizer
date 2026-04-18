namespace GeneratedNoitaClasses;
public class LoadEntitiesComponent : NoitaComponentBase,  iNoitaType<LoadEntitiesComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString entity_file { get; set; } = new();
	public ValueRangeInt count { get; set; } = new();
	public NoitaBool kill_entity { get; set; } = new();
	public NoitaInt timeout_frames { get; set; } = new();
	public NoitaInt mTimerTriggerFrame { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		entity_file.Read(s);
		count.Read(s);
		kill_entity.Read(s);
		timeout_frames.Read(s);
		mTimerTriggerFrame.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		entity_file.Write(s);
		count.Write(s);
		kill_entity.Write(s);
		timeout_frames.Write(s);
		mTimerTriggerFrame.Write(s);

    }
}