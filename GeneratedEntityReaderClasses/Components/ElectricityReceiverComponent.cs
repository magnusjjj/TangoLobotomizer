namespace GeneratedNoitaClasses;
public class ElectricityReceiverComponent : NoitaComponentBase,  iNoitaType<ElectricityReceiverComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt offset_x { get; set; } = new();
	public NoitaInt offset_y { get; set; } = new();
	public NoitaInt radius { get; set; } = new();
	public NoitaInt active_time_frames { get; set; } = new();
	public NoitaInt switch_on_msg_interval_frames { get; set; } = new();
	public NoitaInt electrified_msg_interval_frames { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		radius.Read(s);
		active_time_frames.Read(s);
		switch_on_msg_interval_frames.Read(s);
		electrified_msg_interval_frames.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		radius.Write(s);
		active_time_frames.Write(s);
		switch_on_msg_interval_frames.Write(s);
		electrified_msg_interval_frames.Write(s);

    }
}