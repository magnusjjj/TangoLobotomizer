namespace GeneratedNoitaClasses;
public class ConsumableTeleportComponent {
	public bool create_other_end { get; set; }
	public bool is_at_home { get; set; }
	public float collision_radius { get; set; }
	public CVector2<float> target_location { get; set; }
	public UInt32 target_id { get; set; }
	public UInt32 id { get; set; }
	public Int32 mNextUsableFrame { get; set; }
	public bool mHasOtherEnd { get; set; }

    public void Load(NoitaStream s){
		create_other_end = s.ReadBool();
		is_at_home = s.ReadBool();
		collision_radius = s.ReadBeFloat();
		target_location.Load(s);
		target_id = s.ReadBeUInt32();
		id = s.ReadBeUInt32();
		mNextUsableFrame = s.ReadBeInt32();
		mHasOtherEnd = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(create_other_end);
		s.WriteBool(is_at_home);
		s.WriteBeFloat(collision_radius);
		target_location.Write(s);
		s.WriteBeUInt32(target_id);
		s.WriteBeUInt32(id);
		s.WriteBeInt32(mNextUsableFrame);
		s.WriteBool(mHasOtherEnd);

    }
}