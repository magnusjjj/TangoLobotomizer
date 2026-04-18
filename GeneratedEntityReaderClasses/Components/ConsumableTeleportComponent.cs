namespace GeneratedNoitaClasses;
public class ConsumableTeleportComponent : NoitaComponentBase,  iNoitaType<ConsumableTeleportComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool create_other_end { get; set; } = new();
	public NoitaBool is_at_home { get; set; } = new();
	public NoitaFloat collision_radius { get; set; } = new();
	public NoitaCVector2<NoitaFloat> target_location { get; set; } = new();
	public NoitaUInt target_id { get; set; } = new();
	public NoitaUInt id { get; set; } = new();
	public NoitaInt mNextUsableFrame { get; set; } = new();
	public NoitaBool mHasOtherEnd { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		create_other_end.Read(s);
		is_at_home.Read(s);
		collision_radius.Read(s);
		target_location.Read(s);
		target_id.Read(s);
		id.Read(s);
		mNextUsableFrame.Read(s);
		mHasOtherEnd.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		create_other_end.Write(s);
		is_at_home.Write(s);
		collision_radius.Write(s);
		target_location.Write(s);
		target_id.Write(s);
		id.Write(s);
		mNextUsableFrame.Write(s);
		mHasOtherEnd.Write(s);

    }
}