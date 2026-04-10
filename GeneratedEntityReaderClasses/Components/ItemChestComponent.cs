namespace GeneratedNoitaClasses;
public class ItemChestComponent {
	public Int32 item_count_min { get; set; }
	public Int32 item_count_max { get; set; }
	public Int32 level { get; set; }
	public bool enemy_drop { get; set; }
	public string actions { get; set; }
	public string action_uses_remaining { get; set; }
	public string other_entities_to_spawn { get; set; }
	public UInt32 mSeed { get; set; }

    public void Load(NoitaStream s){
		item_count_min = s.ReadBeInt32();
		item_count_max = s.ReadBeInt32();
		level = s.ReadBeInt32();
		enemy_drop = s.ReadBool();
		actions = s.ReadBeString();
		action_uses_remaining = s.ReadBeString();
		other_entities_to_spawn = s.ReadBeString();
		mSeed = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(item_count_min);
		s.WriteBeInt32(item_count_max);
		s.WriteBeInt32(level);
		s.WriteBool(enemy_drop);
		s.WriteBeString(actions);
		s.WriteBeString(action_uses_remaining);
		s.WriteBeString(other_entities_to_spawn);
		s.WriteBeUInt32(mSeed);

    }
}