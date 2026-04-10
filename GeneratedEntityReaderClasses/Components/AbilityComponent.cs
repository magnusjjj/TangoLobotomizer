namespace GeneratedNoitaClasses;
public class AbilityComponent {
	public Int32 cooldown_frames { get; set; }
	public string entity_file { get; set; }
	public string sprite_file { get; set; }
	public Int32 entity_count { get; set; }
	public bool never_reload { get; set; }
	public Int32 reload_time_frames { get; set; }
	public float mana { get; set; }
	public float mana_max { get; set; }
	public float mana_charge_speed { get; set; }
	public bool rotate_in_hand { get; set; }
	public float rotate_in_hand_amount { get; set; }
	public float rotate_hand_amount { get; set; }
	public bool fast_projectile { get; set; }
	public float swim_propel_amount { get; set; }
	public Int32 max_charged_actions { get; set; }
	public Int32 charge_wait_frames { get; set; }
	public float item_recoil_recovery_speed { get; set; }
	public float item_recoil_max { get; set; }
	public float item_recoil_offset_coeff { get; set; }
	public float item_recoil_rotation_coeff { get; set; }
	public string base_item_file { get; set; }
	public bool use_entity_file_as_projectile_info_proxy { get; set; }
	public bool click_to_use { get; set; }
	public Int32 stat_times_player_has_shot { get; set; }
	public Int32 stat_times_player_has_edited { get; set; }
	public bool shooting_reduces_amount_in_inventory { get; set; }
	public bool throw_as_item { get; set; }
	public bool simulate_throw_as_item { get; set; }
	public Int32 max_amount_in_inventory { get; set; }
	public Int32 amount_in_inventory { get; set; }
	public bool drop_as_item_on_death { get; set; }
	public string ui_name { get; set; }
	public bool use_gun_script { get; set; }
	public bool is_petris_gun { get; set; }
	public ConfigGun gun_config { get; set; }
	public ConfigGunActionInfo gunaction_config { get; set; }
	public Int32 gun_level { get; set; }
	public string add_these_child_actions { get; set; }
	public Int32 current_slot_durability { get; set; }
	public string slot_consumption_function { get; set; }
	public Int32 mNextFrameUsable { get; set; }
	public Int32 mCastDelayStartFrame { get; set; }
	public Int32 mReloadFramesLeft { get; set; }
	public Int32 mReloadNextFrameUsable { get; set; }
	public Int32 mChargeCount { get; set; }
	public bool mIsInitialized { get; set; }

    public void Load(NoitaStream s){
		cooldown_frames = s.ReadBeInt32();
		entity_file = s.ReadBeString();
		sprite_file = s.ReadBeString();
		entity_count = s.ReadBeInt32();
		never_reload = s.ReadBool();
		reload_time_frames = s.ReadBeInt32();
		mana = s.ReadBeFloat();
		mana_max = s.ReadBeFloat();
		mana_charge_speed = s.ReadBeFloat();
		rotate_in_hand = s.ReadBool();
		rotate_in_hand_amount = s.ReadBeFloat();
		rotate_hand_amount = s.ReadBeFloat();
		fast_projectile = s.ReadBool();
		swim_propel_amount = s.ReadBeFloat();
		max_charged_actions = s.ReadBeInt32();
		charge_wait_frames = s.ReadBeInt32();
		item_recoil_recovery_speed = s.ReadBeFloat();
		item_recoil_max = s.ReadBeFloat();
		item_recoil_offset_coeff = s.ReadBeFloat();
		item_recoil_rotation_coeff = s.ReadBeFloat();
		base_item_file = s.ReadBeString();
		use_entity_file_as_projectile_info_proxy = s.ReadBool();
		click_to_use = s.ReadBool();
		stat_times_player_has_shot = s.ReadBeInt32();
		stat_times_player_has_edited = s.ReadBeInt32();
		shooting_reduces_amount_in_inventory = s.ReadBool();
		throw_as_item = s.ReadBool();
		simulate_throw_as_item = s.ReadBool();
		max_amount_in_inventory = s.ReadBeInt32();
		amount_in_inventory = s.ReadBeInt32();
		drop_as_item_on_death = s.ReadBool();
		ui_name = s.ReadBeString();
		use_gun_script = s.ReadBool();
		is_petris_gun = s.ReadBool();
		gun_config.Load(s);
		gunaction_config.Load(s);
		gun_level = s.ReadBeInt32();
		add_these_child_actions = s.ReadBeString();
		current_slot_durability = s.ReadBeInt32();
		slot_consumption_function = s.ReadBeString();
		mNextFrameUsable = s.ReadBeInt32();
		mCastDelayStartFrame = s.ReadBeInt32();
		mReloadFramesLeft = s.ReadBeInt32();
		mReloadNextFrameUsable = s.ReadBeInt32();
		mChargeCount = s.ReadBeInt32();
		mIsInitialized = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(cooldown_frames);
		s.WriteBeString(entity_file);
		s.WriteBeString(sprite_file);
		s.WriteBeInt32(entity_count);
		s.WriteBool(never_reload);
		s.WriteBeInt32(reload_time_frames);
		s.WriteBeFloat(mana);
		s.WriteBeFloat(mana_max);
		s.WriteBeFloat(mana_charge_speed);
		s.WriteBool(rotate_in_hand);
		s.WriteBeFloat(rotate_in_hand_amount);
		s.WriteBeFloat(rotate_hand_amount);
		s.WriteBool(fast_projectile);
		s.WriteBeFloat(swim_propel_amount);
		s.WriteBeInt32(max_charged_actions);
		s.WriteBeInt32(charge_wait_frames);
		s.WriteBeFloat(item_recoil_recovery_speed);
		s.WriteBeFloat(item_recoil_max);
		s.WriteBeFloat(item_recoil_offset_coeff);
		s.WriteBeFloat(item_recoil_rotation_coeff);
		s.WriteBeString(base_item_file);
		s.WriteBool(use_entity_file_as_projectile_info_proxy);
		s.WriteBool(click_to_use);
		s.WriteBeInt32(stat_times_player_has_shot);
		s.WriteBeInt32(stat_times_player_has_edited);
		s.WriteBool(shooting_reduces_amount_in_inventory);
		s.WriteBool(throw_as_item);
		s.WriteBool(simulate_throw_as_item);
		s.WriteBeInt32(max_amount_in_inventory);
		s.WriteBeInt32(amount_in_inventory);
		s.WriteBool(drop_as_item_on_death);
		s.WriteBeString(ui_name);
		s.WriteBool(use_gun_script);
		s.WriteBool(is_petris_gun);
		gun_config.Write(s);
		gunaction_config.Write(s);
		s.WriteBeInt32(gun_level);
		s.WriteBeString(add_these_child_actions);
		s.WriteBeInt32(current_slot_durability);
		s.WriteBeString(slot_consumption_function);
		s.WriteBeInt32(mNextFrameUsable);
		s.WriteBeInt32(mCastDelayStartFrame);
		s.WriteBeInt32(mReloadFramesLeft);
		s.WriteBeInt32(mReloadNextFrameUsable);
		s.WriteBeInt32(mChargeCount);
		s.WriteBool(mIsInitialized);

    }
}