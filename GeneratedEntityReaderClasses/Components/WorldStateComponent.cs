namespace GeneratedNoitaClasses;
public class WorldStateComponent {
	public bool is_initialized { get; set; }
	public float time { get; set; }
	public float time_total { get; set; }
	public float time_dt { get; set; }
	public Int32 day_count { get; set; }
	public float rain { get; set; }
	public float rain_target { get; set; }
	public float fog { get; set; }
	public float fog_target { get; set; }
	public bool intro_weather { get; set; }
	public float wind { get; set; }
	public float wind_speed { get; set; }
	public float wind_speed_sin_t { get; set; }
	public float wind_speed_sin { get; set; }
	public float clouds_01_target { get; set; }
	public float clouds_02_target { get; set; }
	public float gradient_sky_alpha_target { get; set; }
	public float sky_sunset_alpha_target { get; set; }
	public Int32 lightning_count { get; set; }
	public CVector2<float> player_spawn_location { get; set; }
	
	public List<MissingClassConfigPendingPortal> pending_portals { get; set; }
	public UInt32 next_portal_id { get; set; }
	public List<int> apparitions_per_level { get; set; }
	public List<MissingClassConfigNpcParty> npc_parties { get; set; }
	public string session_stat_file { get; set; }
	public List<int> orbs_found_thisrun { get; set; }
	public List<string> flags { get; set; }
	public List<string> changed_materials { get; set; }
	public Int32 player_polymorph_count { get; set; }
	public Int32 player_polymorph_random_count { get; set; }
	public Int32 player_did_infinite_spell_count { get; set; }
	public Int32 player_did_damage_over_1milj { get; set; }
	public Int32 player_living_with_minus_hp { get; set; }
	public float global_genome_relations_modifier { get; set; }
	public bool mods_have_been_active_during_this_run { get; set; }
	public bool twitch_has_been_active_during_this_run { get; set; }
	public UInt32 next_cut_through_world_id { get; set; }
	public List<MissingClassConfigCutThroughWorld> cuts_through_world { get; set; }
	public LensValue<int> gore_multiplier { get; set; }
	public LensValue<int> trick_kill_gold_multiplier { get; set; }
	public LensValue<float> damage_flash_multiplier { get; set; }
	public LensValue<bool> open_fog_of_war_everywhere { get; set; }
	public LensValue<bool> consume_actions { get; set; }
	public bool perk_infinite_spells { get; set; }
	public bool perk_trick_kills_blood_money { get; set; }
	public Int32 perk_hp_drop_chance { get; set; }
	public bool perk_gold_is_forever { get; set; }
	public bool perk_rats_player_friendly { get; set; }
	public bool EVERYTHING_TO_GOLD { get; set; }
	public string material_everything_to_gold { get; set; }
	public string material_everything_to_gold_static { get; set; }
	public bool INFINITE_GOLD_HAPPENING { get; set; }
	public bool ENDING_HAPPINESS_HAPPENING { get; set; }
	public Int32 ENDING_HAPPINESS_FRAMES { get; set; }
	public bool ENDING_HAPPINESS { get; set; }
	public float mFlashAlpha { get; set; }
	public Int32 DEBUG_LOADED_FROM_AUTOSAVE { get; set; }
	public Int32 DEBUG_LOADED_FROM_OLD_VERSION { get; set; }

    public void Load(NoitaStream s){
		is_initialized = s.ReadBool();
		time = s.ReadBeFloat();
		time_total = s.ReadBeFloat();
		time_dt = s.ReadBeFloat();
		day_count = s.ReadBeInt32();
		rain = s.ReadBeFloat();
		rain_target = s.ReadBeFloat();
		fog = s.ReadBeFloat();
		fog_target = s.ReadBeFloat();
		intro_weather = s.ReadBool();
		wind = s.ReadBeFloat();
		wind_speed = s.ReadBeFloat();
		wind_speed_sin_t = s.ReadBeFloat();
		wind_speed_sin = s.ReadBeFloat();
		clouds_01_target = s.ReadBeFloat();
		clouds_02_target = s.ReadBeFloat();
		gradient_sky_alpha_target = s.ReadBeFloat();
		sky_sunset_alpha_target = s.ReadBeFloat();
		lightning_count = s.ReadBeInt32();
		player_spawn_location.Load(s);
		
		pending_portals = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 pending_portals.Add(MissingClassConfigPendingPortal.Load(s));
}
		next_portal_id = s.ReadBeUInt32();
		apparitions_per_level = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 apparitions_per_level.Add(int.Load(s));
}
		npc_parties = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 npc_parties.Add(MissingClassConfigNpcParty.Load(s));
}
		session_stat_file = s.ReadBeString();
		orbs_found_thisrun = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 orbs_found_thisrun.Add(int.Load(s));
}
		flags = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 flags.Add(string.Load(s));
}
		changed_materials = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 changed_materials.Add(string.Load(s));
}
		player_polymorph_count = s.ReadBeInt32();
		player_polymorph_random_count = s.ReadBeInt32();
		player_did_infinite_spell_count = s.ReadBeInt32();
		player_did_damage_over_1milj = s.ReadBeInt32();
		player_living_with_minus_hp = s.ReadBeInt32();
		global_genome_relations_modifier = s.ReadBeFloat();
		mods_have_been_active_during_this_run = s.ReadBool();
		twitch_has_been_active_during_this_run = s.ReadBool();
		next_cut_through_world_id = s.ReadBeUInt32();
		cuts_through_world = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 cuts_through_world.Add(MissingClassConfigCutThroughWorld.Load(s));
}
		gore_multiplier.Load(s);
		trick_kill_gold_multiplier.Load(s);
		damage_flash_multiplier.Load(s);
		open_fog_of_war_everywhere.Load(s);
		consume_actions.Load(s);
		perk_infinite_spells = s.ReadBool();
		perk_trick_kills_blood_money = s.ReadBool();
		perk_hp_drop_chance = s.ReadBeInt32();
		perk_gold_is_forever = s.ReadBool();
		perk_rats_player_friendly = s.ReadBool();
		EVERYTHING_TO_GOLD = s.ReadBool();
		material_everything_to_gold = s.ReadBeString();
		material_everything_to_gold_static = s.ReadBeString();
		INFINITE_GOLD_HAPPENING = s.ReadBool();
		ENDING_HAPPINESS_HAPPENING = s.ReadBool();
		ENDING_HAPPINESS_FRAMES = s.ReadBeInt32();
		ENDING_HAPPINESS = s.ReadBool();
		mFlashAlpha = s.ReadBeFloat();
		DEBUG_LOADED_FROM_AUTOSAVE = s.ReadBeInt32();
		DEBUG_LOADED_FROM_OLD_VERSION = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_initialized);
		s.WriteBeFloat(time);
		s.WriteBeFloat(time_total);
		s.WriteBeFloat(time_dt);
		s.WriteBeInt32(day_count);
		s.WriteBeFloat(rain);
		s.WriteBeFloat(rain_target);
		s.WriteBeFloat(fog);
		s.WriteBeFloat(fog_target);
		s.WriteBool(intro_weather);
		s.WriteBeFloat(wind);
		s.WriteBeFloat(wind_speed);
		s.WriteBeFloat(wind_speed_sin_t);
		s.WriteBeFloat(wind_speed_sin);
		s.WriteBeFloat(clouds_01_target);
		s.WriteBeFloat(clouds_02_target);
		s.WriteBeFloat(gradient_sky_alpha_target);
		s.WriteBeFloat(sky_sunset_alpha_target);
		s.WriteBeInt32(lightning_count);
		player_spawn_location.Write(s);
		
		s.WriteBeUInt32(pending_portals.Length);
foreach(var item in pending_portals){ pending_portals.Write(s);
}
		s.WriteBeUInt32(next_portal_id);
		s.WriteBeUInt32(apparitions_per_level.Length);
foreach(var item in apparitions_per_level){ apparitions_per_level.Write(s);
}
		s.WriteBeUInt32(npc_parties.Length);
foreach(var item in npc_parties){ npc_parties.Write(s);
}
		s.WriteBeString(session_stat_file);
		s.WriteBeUInt32(orbs_found_thisrun.Length);
foreach(var item in orbs_found_thisrun){ orbs_found_thisrun.Write(s);
}
		s.WriteBeUInt32(flags.Length);
foreach(var item in flags){ flags.Write(s);
}
		s.WriteBeUInt32(changed_materials.Length);
foreach(var item in changed_materials){ changed_materials.Write(s);
}
		s.WriteBeInt32(player_polymorph_count);
		s.WriteBeInt32(player_polymorph_random_count);
		s.WriteBeInt32(player_did_infinite_spell_count);
		s.WriteBeInt32(player_did_damage_over_1milj);
		s.WriteBeInt32(player_living_with_minus_hp);
		s.WriteBeFloat(global_genome_relations_modifier);
		s.WriteBool(mods_have_been_active_during_this_run);
		s.WriteBool(twitch_has_been_active_during_this_run);
		s.WriteBeUInt32(next_cut_through_world_id);
		s.WriteBeUInt32(cuts_through_world.Length);
foreach(var item in cuts_through_world){ cuts_through_world.Write(s);
}
		gore_multiplier.Write(s);
		trick_kill_gold_multiplier.Write(s);
		damage_flash_multiplier.Write(s);
		open_fog_of_war_everywhere.Write(s);
		consume_actions.Write(s);
		s.WriteBool(perk_infinite_spells);
		s.WriteBool(perk_trick_kills_blood_money);
		s.WriteBeInt32(perk_hp_drop_chance);
		s.WriteBool(perk_gold_is_forever);
		s.WriteBool(perk_rats_player_friendly);
		s.WriteBool(EVERYTHING_TO_GOLD);
		s.WriteBeString(material_everything_to_gold);
		s.WriteBeString(material_everything_to_gold_static);
		s.WriteBool(INFINITE_GOLD_HAPPENING);
		s.WriteBool(ENDING_HAPPINESS_HAPPENING);
		s.WriteBeInt32(ENDING_HAPPINESS_FRAMES);
		s.WriteBool(ENDING_HAPPINESS);
		s.WriteBeFloat(mFlashAlpha);
		s.WriteBeInt32(DEBUG_LOADED_FROM_AUTOSAVE);
		s.WriteBeInt32(DEBUG_LOADED_FROM_OLD_VERSION);

    }
}