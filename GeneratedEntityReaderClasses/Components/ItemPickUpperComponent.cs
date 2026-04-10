namespace GeneratedNoitaClasses;
public class ItemPickUpperComponent {
	public bool is_in_npc { get; set; }
	public bool pick_up_any_item_buggy { get; set; }
	public bool is_immune_to_kicks { get; set; }
	public UInt32 only_pick_this_entity { get; set; }
	public bool drop_items_on_death { get; set; }
	public CVector2<float> mLatestItemOverlapInfoBoxPosition { get; set; }

    public void Load(NoitaStream s){
		is_in_npc = s.ReadBool();
		pick_up_any_item_buggy = s.ReadBool();
		is_immune_to_kicks = s.ReadBool();
		only_pick_this_entity = s.ReadBeUInt32();
		drop_items_on_death = s.ReadBool();
		mLatestItemOverlapInfoBoxPosition.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_in_npc);
		s.WriteBool(pick_up_any_item_buggy);
		s.WriteBool(is_immune_to_kicks);
		s.WriteBeUInt32(only_pick_this_entity);
		s.WriteBool(drop_items_on_death);
		mLatestItemOverlapInfoBoxPosition.Write(s);

    }
}