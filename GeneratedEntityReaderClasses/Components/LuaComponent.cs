namespace GeneratedNoitaClasses;
public class LuaComponent {
	public string script_source_file { get; set; }
	public UInt32 vm_type { get; set; }
	public bool execute_on_added { get; set; }
	public bool execute_on_removed { get; set; }
	public Int32 execute_every_n_frame { get; set; }
	public Int32 execute_times { get; set; }
	public Int32 limit_how_many_times_per_frame { get; set; }
	public Int32 limit_to_every_n_frame { get; set; }
	public bool limit_all_callbacks { get; set; }
	public bool remove_after_executed { get; set; }
	public bool enable_coroutines { get; set; }
	public bool call_init_function { get; set; }
	public string script_enabled_changed { get; set; }
	public string script_damage_received { get; set; }
	public string script_damage_about_to_be_received { get; set; }
	public string script_item_picked_up { get; set; }
	public string script_shot { get; set; }
	public string script_collision_trigger_hit { get; set; }
	public string script_collision_trigger_timer_finished { get; set; }
	public string script_physics_body_modified { get; set; }
	public string script_pressure_plate_change { get; set; }
	public string script_inhaled_material { get; set; }
	public string script_death { get; set; }
	public string script_throw_item { get; set; }
	public string script_material_area_checker_failed { get; set; }
	public string script_material_area_checker_success { get; set; }
	public string script_electricity_receiver_switched { get; set; }
	public string script_electricity_receiver_electrified { get; set; }
	public string script_kick { get; set; }
	public string script_interacting { get; set; }
	public string script_audio_event_dead { get; set; }
	public string script_wand_fired { get; set; }
	public string script_teleported { get; set; }
	public string script_portal_teleport_used { get; set; }
	public string script_polymorphing_to { get; set; }
	public string script_biome_entered { get; set; }
	public Int32 mLastExecutionFrame { get; set; }
	public Int32 mTimesExecutedThisFrame { get; set; }
	public bool mModAppendsDone { get; set; }

    public void Load(NoitaStream s){
		script_source_file = s.ReadBeString();
		vm_type = s.ReadBeUInt32();
		execute_on_added = s.ReadBool();
		execute_on_removed = s.ReadBool();
		execute_every_n_frame = s.ReadBeInt32();
		execute_times = s.ReadBeInt32();
		limit_how_many_times_per_frame = s.ReadBeInt32();
		limit_to_every_n_frame = s.ReadBeInt32();
		limit_all_callbacks = s.ReadBool();
		remove_after_executed = s.ReadBool();
		enable_coroutines = s.ReadBool();
		call_init_function = s.ReadBool();
		script_enabled_changed = s.ReadBeString();
		script_damage_received = s.ReadBeString();
		script_damage_about_to_be_received = s.ReadBeString();
		script_item_picked_up = s.ReadBeString();
		script_shot = s.ReadBeString();
		script_collision_trigger_hit = s.ReadBeString();
		script_collision_trigger_timer_finished = s.ReadBeString();
		script_physics_body_modified = s.ReadBeString();
		script_pressure_plate_change = s.ReadBeString();
		script_inhaled_material = s.ReadBeString();
		script_death = s.ReadBeString();
		script_throw_item = s.ReadBeString();
		script_material_area_checker_failed = s.ReadBeString();
		script_material_area_checker_success = s.ReadBeString();
		script_electricity_receiver_switched = s.ReadBeString();
		script_electricity_receiver_electrified = s.ReadBeString();
		script_kick = s.ReadBeString();
		script_interacting = s.ReadBeString();
		script_audio_event_dead = s.ReadBeString();
		script_wand_fired = s.ReadBeString();
		script_teleported = s.ReadBeString();
		script_portal_teleport_used = s.ReadBeString();
		script_polymorphing_to = s.ReadBeString();
		script_biome_entered = s.ReadBeString();
		mLastExecutionFrame = s.ReadBeInt32();
		mTimesExecutedThisFrame = s.ReadBeInt32();
		mModAppendsDone = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(script_source_file);
		s.WriteBeUInt32(vm_type);
		s.WriteBool(execute_on_added);
		s.WriteBool(execute_on_removed);
		s.WriteBeInt32(execute_every_n_frame);
		s.WriteBeInt32(execute_times);
		s.WriteBeInt32(limit_how_many_times_per_frame);
		s.WriteBeInt32(limit_to_every_n_frame);
		s.WriteBool(limit_all_callbacks);
		s.WriteBool(remove_after_executed);
		s.WriteBool(enable_coroutines);
		s.WriteBool(call_init_function);
		s.WriteBeString(script_enabled_changed);
		s.WriteBeString(script_damage_received);
		s.WriteBeString(script_damage_about_to_be_received);
		s.WriteBeString(script_item_picked_up);
		s.WriteBeString(script_shot);
		s.WriteBeString(script_collision_trigger_hit);
		s.WriteBeString(script_collision_trigger_timer_finished);
		s.WriteBeString(script_physics_body_modified);
		s.WriteBeString(script_pressure_plate_change);
		s.WriteBeString(script_inhaled_material);
		s.WriteBeString(script_death);
		s.WriteBeString(script_throw_item);
		s.WriteBeString(script_material_area_checker_failed);
		s.WriteBeString(script_material_area_checker_success);
		s.WriteBeString(script_electricity_receiver_switched);
		s.WriteBeString(script_electricity_receiver_electrified);
		s.WriteBeString(script_kick);
		s.WriteBeString(script_interacting);
		s.WriteBeString(script_audio_event_dead);
		s.WriteBeString(script_wand_fired);
		s.WriteBeString(script_teleported);
		s.WriteBeString(script_portal_teleport_used);
		s.WriteBeString(script_polymorphing_to);
		s.WriteBeString(script_biome_entered);
		s.WriteBeInt32(mLastExecutionFrame);
		s.WriteBeInt32(mTimesExecutedThisFrame);
		s.WriteBool(mModAppendsDone);

    }
}