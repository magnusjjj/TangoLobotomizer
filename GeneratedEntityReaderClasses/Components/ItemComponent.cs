namespace GeneratedNoitaClasses;
public class ItemComponent {
	public string item_name { get; set; }
	public bool is_stackable { get; set; }
	public bool is_consumable { get; set; }
	public bool stats_count_as_item_pick_up { get; set; }
	public bool auto_pickup { get; set; }
	public bool permanently_attached { get; set; }
	public Int32 uses_remaining { get; set; }
	public bool is_identified { get; set; }
	public bool is_frozen { get; set; }
	public bool collect_nondefault_actions { get; set; }
	public bool remove_on_death { get; set; }
	public bool remove_on_death_if_empty { get; set; }
	public bool remove_default_child_actions_on_death { get; set; }
	public bool play_hover_animation { get; set; }
	public bool play_spinning_animation { get; set; }
	public bool is_equipable_forced { get; set; }
	public bool play_pick_sound { get; set; }
	public bool drinkable { get; set; }
	public CVector2<float> spawn_pos { get; set; }
	public Int32 max_child_items { get; set; }
	public string ui_sprite { get; set; }
	public string ui_description { get; set; }
	public UInt32 preferred_inventory { get; set; }
	public bool enable_orb_hacks { get; set; }
	public bool is_all_spells_book { get; set; }
	public bool always_use_item_name_in_ui { get; set; }
	public string custom_pickup_string { get; set; }
	public bool ui_display_description_on_pick_up_hint { get; set; }
	public CVector2<int> inventory_slot { get; set; }
	public Int32 next_frame_pickable { get; set; }
	public Int32 npc_next_frame_pickable { get; set; }
	public bool is_pickable { get; set; }
	public bool is_hittable_always { get; set; }
	public float item_pickup_radius { get; set; }
	public float camera_max_distance { get; set; }
	public float camera_smooth_speed_multiplier { get; set; }
	public bool has_been_picked_by_player { get; set; }
	public Int32 mFramePickedUp { get; set; }

    public void Load(NoitaStream s){
		item_name = s.ReadBeString();
		is_stackable = s.ReadBool();
		is_consumable = s.ReadBool();
		stats_count_as_item_pick_up = s.ReadBool();
		auto_pickup = s.ReadBool();
		permanently_attached = s.ReadBool();
		uses_remaining = s.ReadBeInt32();
		is_identified = s.ReadBool();
		is_frozen = s.ReadBool();
		collect_nondefault_actions = s.ReadBool();
		remove_on_death = s.ReadBool();
		remove_on_death_if_empty = s.ReadBool();
		remove_default_child_actions_on_death = s.ReadBool();
		play_hover_animation = s.ReadBool();
		play_spinning_animation = s.ReadBool();
		is_equipable_forced = s.ReadBool();
		play_pick_sound = s.ReadBool();
		drinkable = s.ReadBool();
		spawn_pos.Load(s);
		max_child_items = s.ReadBeInt32();
		ui_sprite = s.ReadBeString();
		ui_description = s.ReadBeString();
		preferred_inventory = s.ReadBeUInt32();
		enable_orb_hacks = s.ReadBool();
		is_all_spells_book = s.ReadBool();
		always_use_item_name_in_ui = s.ReadBool();
		custom_pickup_string = s.ReadBeString();
		ui_display_description_on_pick_up_hint = s.ReadBool();
		inventory_slot.Load(s);
		next_frame_pickable = s.ReadBeInt32();
		npc_next_frame_pickable = s.ReadBeInt32();
		is_pickable = s.ReadBool();
		is_hittable_always = s.ReadBool();
		item_pickup_radius = s.ReadBeFloat();
		camera_max_distance = s.ReadBeFloat();
		camera_smooth_speed_multiplier = s.ReadBeFloat();
		has_been_picked_by_player = s.ReadBool();
		mFramePickedUp = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(item_name);
		s.WriteBool(is_stackable);
		s.WriteBool(is_consumable);
		s.WriteBool(stats_count_as_item_pick_up);
		s.WriteBool(auto_pickup);
		s.WriteBool(permanently_attached);
		s.WriteBeInt32(uses_remaining);
		s.WriteBool(is_identified);
		s.WriteBool(is_frozen);
		s.WriteBool(collect_nondefault_actions);
		s.WriteBool(remove_on_death);
		s.WriteBool(remove_on_death_if_empty);
		s.WriteBool(remove_default_child_actions_on_death);
		s.WriteBool(play_hover_animation);
		s.WriteBool(play_spinning_animation);
		s.WriteBool(is_equipable_forced);
		s.WriteBool(play_pick_sound);
		s.WriteBool(drinkable);
		spawn_pos.Write(s);
		s.WriteBeInt32(max_child_items);
		s.WriteBeString(ui_sprite);
		s.WriteBeString(ui_description);
		s.WriteBeUInt32(preferred_inventory);
		s.WriteBool(enable_orb_hacks);
		s.WriteBool(is_all_spells_book);
		s.WriteBool(always_use_item_name_in_ui);
		s.WriteBeString(custom_pickup_string);
		s.WriteBool(ui_display_description_on_pick_up_hint);
		inventory_slot.Write(s);
		s.WriteBeInt32(next_frame_pickable);
		s.WriteBeInt32(npc_next_frame_pickable);
		s.WriteBool(is_pickable);
		s.WriteBool(is_hittable_always);
		s.WriteBeFloat(item_pickup_radius);
		s.WriteBeFloat(camera_max_distance);
		s.WriteBeFloat(camera_smooth_speed_multiplier);
		s.WriteBool(has_been_picked_by_player);
		s.WriteBeInt32(mFramePickedUp);

    }
}