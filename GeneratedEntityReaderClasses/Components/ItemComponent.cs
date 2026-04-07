namespace GeneratedNoitaClasses;
public class ItemComponent{
	public string item_name{ get; set; }
	public bool is_stackable{ get; set; }
	public bool is_consumable{ get; set; }
	public bool stats_count_as_item_pick_up{ get; set; }
	public bool auto_pickup{ get; set; }
	public bool permanently_attached{ get; set; }
	public int uses_remaining{ get; set; }
	public bool is_identified{ get; set; }
	public bool is_frozen{ get; set; }
	public bool collect_nondefault_actions{ get; set; }
	public bool remove_on_death{ get; set; }
	public bool remove_on_death_if_empty{ get; set; }
	public bool remove_default_child_actions_on_death{ get; set; }
	public bool play_hover_animation{ get; set; }
	public bool play_spinning_animation{ get; set; }
	public bool is_equipable_forced{ get; set; }
	public bool play_pick_sound{ get; set; }
	public bool drinkable{ get; set; }
	public List<float> spawn_pos{ get; set; }
	public int max_child_items{ get; set; }
	public string ui_sprite{ get; set; }
	public string ui_description{ get; set; }
	public INVENTORY_KIND preferred_inventory{ get; set; }
	public bool enable_orb_hacks{ get; set; }
	public bool is_all_spells_book{ get; set; }
	public bool always_use_item_name_in_ui{ get; set; }
	public string custom_pickup_string{ get; set; }
	public bool ui_display_description_on_pick_up_hint{ get; set; }
	public List<int> inventory_slot{ get; set; }
	public int next_frame_pickable{ get; set; }
	public int npc_next_frame_pickable{ get; set; }
	public bool is_pickable{ get; set; }
	public bool is_hittable_always{ get; set; }
	public float item_pickup_radius{ get; set; }
	public float camera_max_distance{ get; set; }
	public float camera_smooth_speed_multiplier{ get; set; }
	public bool has_been_picked_by_player{ get; set; }
	public int mFramePickedUp{ get; set; }

}