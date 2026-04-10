namespace GeneratedNoitaClasses;
public class ElectricityReceiverComponent {
	public Int32 offset_x { get; set; }
	public Int32 offset_y { get; set; }
	public Int32 radius { get; set; }
	public Int32 active_time_frames { get; set; }
	public Int32 switch_on_msg_interval_frames { get; set; }
	public Int32 electrified_msg_interval_frames { get; set; }

    public void Load(NoitaStream s){
		offset_x = s.ReadBeInt32();
		offset_y = s.ReadBeInt32();
		radius = s.ReadBeInt32();
		active_time_frames = s.ReadBeInt32();
		switch_on_msg_interval_frames = s.ReadBeInt32();
		electrified_msg_interval_frames = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(offset_x);
		s.WriteBeInt32(offset_y);
		s.WriteBeInt32(radius);
		s.WriteBeInt32(active_time_frames);
		s.WriteBeInt32(switch_on_msg_interval_frames);
		s.WriteBeInt32(electrified_msg_interval_frames);

    }
}