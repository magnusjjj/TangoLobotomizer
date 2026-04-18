namespace GeneratedNoitaClasses;
public class ItemChestComponent : NoitaComponentBase,  iNoitaType<ItemChestComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt item_count_min { get; set; } = new();
	public NoitaInt item_count_max { get; set; } = new();
	public NoitaInt level { get; set; } = new();
	public NoitaBool enemy_drop { get; set; } = new();
	public NoitaString actions { get; set; } = new();
	public NoitaString action_uses_remaining { get; set; } = new();
	public NoitaString other_entities_to_spawn { get; set; } = new();
	public NoitaUInt mSeed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		item_count_min.Read(s);
		item_count_max.Read(s);
		level.Read(s);
		enemy_drop.Read(s);
		actions.Read(s);
		action_uses_remaining.Read(s);
		other_entities_to_spawn.Read(s);
		mSeed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		item_count_min.Write(s);
		item_count_max.Write(s);
		level.Write(s);
		enemy_drop.Write(s);
		actions.Write(s);
		action_uses_remaining.Write(s);
		other_entities_to_spawn.Write(s);
		mSeed.Write(s);

    }
}