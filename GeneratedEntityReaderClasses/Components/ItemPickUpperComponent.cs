namespace GeneratedNoitaClasses;
public class ItemPickUpperComponent : NoitaComponentBase,  iNoitaType<ItemPickUpperComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool is_in_npc { get; set; } = new();
	public NoitaBool pick_up_any_item_buggy { get; set; } = new();
	public NoitaBool is_immune_to_kicks { get; set; } = new();
	public NoitaUInt only_pick_this_entity { get; set; } = new();
	public NoitaBool drop_items_on_death { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mLatestItemOverlapInfoBoxPosition { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		is_in_npc.Read(s);
		pick_up_any_item_buggy.Read(s);
		is_immune_to_kicks.Read(s);
		only_pick_this_entity.Read(s);
		drop_items_on_death.Read(s);
		mLatestItemOverlapInfoBoxPosition.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		is_in_npc.Write(s);
		pick_up_any_item_buggy.Write(s);
		is_immune_to_kicks.Write(s);
		only_pick_this_entity.Write(s);
		drop_items_on_death.Write(s);
		mLatestItemOverlapInfoBoxPosition.Write(s);

    }
}