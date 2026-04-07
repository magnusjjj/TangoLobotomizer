namespace GeneratedNoitaClasses;
public class LuaComponent{
	public string script_source_file{ get; set; }
	public LUA_VM_TYPE vm_type{ get; set; }
	public bool execute_on_added{ get; set; }
	public bool execute_on_removed{ get; set; }
	public int execute_every_n_frame{ get; set; }
	public int execute_times{ get; set; }
	public int limit_how_many_times_per_frame{ get; set; }
	public int limit_to_every_n_frame{ get; set; }
	public bool limit_all_callbacks{ get; set; }
	public bool remove_after_executed{ get; set; }
	public bool enable_coroutines{ get; set; }
	public bool call_init_function{ get; set; }
	public string script_enabled_changed{ get; set; }
	public string script_damage_received{ get; set; }
	public string script_damage_about_to_be_received{ get; set; }
	public string script_item_picked_up{ get; set; }
	public string script_shot{ get; set; }
	public string script_collision_trigger_hit{ get; set; }
	public string script_collision_trigger_timer_finished{ get; set; }
	public string script_physics_body_modified{ get; set; }
	public string script_pressure_plate_change{ get; set; }
	public string script_inhaled_material{ get; set; }
	public string script_death{ get; set; }
	public string script_throw_item{ get; set; }
	public string script_material_area_checker_failed{ get; set; }
	public string script_material_area_checker_success{ get; set; }
	public string script_electricity_receiver_switched{ get; set; }
	public string script_electricity_receiver_electrified{ get; set; }
	public string script_kick{ get; set; }
	public string script_interacting{ get; set; }
	public string script_audio_event_dead{ get; set; }
	public string script_wand_fired{ get; set; }
	public string script_teleported{ get; set; }
	public string script_portal_teleport_used{ get; set; }
	public string script_polymorphing_to{ get; set; }
	public string script_biome_entered{ get; set; }
	public int mLastExecutionFrame{ get; set; }
	public int mTimesExecutedThisFrame{ get; set; }
	public bool mModAppendsDone{ get; set; }

}