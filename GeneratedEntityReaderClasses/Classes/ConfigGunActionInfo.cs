namespace GeneratedNoitaClasses;
public class ConfigGunActionInfo {
	public string action_id { get; set; }
	public string action_name { get; set; }
	public string action_description { get; set; }
	public string action_sprite_filename { get; set; }
	public string action_unidentified_sprite_filename { get; set; }
	public Int32 action_type { get; set; }
	public string action_spawn_level { get; set; }
	public string action_spawn_probability { get; set; }
	public string action_spawn_requires_flag { get; set; }
	public bool action_spawn_manual_unlock { get; set; }
	public Int32 action_max_uses { get; set; }
	public string custom_xml_file { get; set; }
	public float action_mana_drain { get; set; }
	public bool action_is_dangerous_blast { get; set; }
	public Int32 action_draw_many_count { get; set; }
	public bool action_ai_never_uses { get; set; }
	public bool action_never_unlimited { get; set; }
	public bool state_shuffled { get; set; }
	public Int32 state_cards_drawn { get; set; }
	public bool state_discarded_action { get; set; }
	public bool state_destroyed_action { get; set; }
	public Int32 fire_rate_wait { get; set; }
	public float speed_multiplier { get; set; }
	public float child_speed_multiplier { get; set; }
	public float dampening { get; set; }
	public float explosion_radius { get; set; }
	public float spread_degrees { get; set; }
	public float pattern_degrees { get; set; }
	public float screenshake { get; set; }
	public float recoil { get; set; }
	public float damage_melee_add { get; set; }
	public float damage_projectile_add { get; set; }
	public float damage_electricity_add { get; set; }
	public float damage_fire_add { get; set; }
	public float damage_explosion_add { get; set; }
	public float damage_ice_add { get; set; }
	public float damage_slice_add { get; set; }
	public float damage_healing_add { get; set; }
	public float damage_curse_add { get; set; }
	public float damage_drill_add { get; set; }
	public float damage_null_all { get; set; }
	public Int32 damage_critical_chance { get; set; }
	public float damage_critical_multiplier { get; set; }
	public float explosion_damage_to_materials { get; set; }
	public float knockback_force { get; set; }
	public Int32 reload_time { get; set; }
	public Int32 lightning_count { get; set; }
	public string material { get; set; }
	public Int32 material_amount { get; set; }
	public string trail_material { get; set; }
	public Int32 trail_material_amount { get; set; }
	public Int32 bounces { get; set; }
	public float gravity { get; set; }
	public float light { get; set; }
	public float blood_count_multiplier { get; set; }
	public Int32 gore_particles { get; set; }
	public Int32 ragdoll_fx { get; set; }
	public bool friendly_fire { get; set; }
	public float physics_impulse_coeff { get; set; }
	public Int32 lifetime_add { get; set; }
	public string sprite { get; set; }
	public string extra_entities { get; set; }
	public string game_effect_entities { get; set; }
	public string sound_loop_tag { get; set; }
	public string projectile_file { get; set; }

    public void Load(NoitaStream s){
		action_id = s.ReadBeString();
		action_name = s.ReadBeString();
		action_description = s.ReadBeString();
		action_sprite_filename = s.ReadBeString();
		action_unidentified_sprite_filename = s.ReadBeString();
		action_type = s.ReadBeInt32();
		action_spawn_level = s.ReadBeString();
		action_spawn_probability = s.ReadBeString();
		action_spawn_requires_flag = s.ReadBeString();
		action_spawn_manual_unlock = s.ReadBool();
		action_max_uses = s.ReadBeInt32();
		custom_xml_file = s.ReadBeString();
		action_mana_drain = s.ReadBeFloat();
		action_is_dangerous_blast = s.ReadBool();
		action_draw_many_count = s.ReadBeInt32();
		action_ai_never_uses = s.ReadBool();
		action_never_unlimited = s.ReadBool();
		state_shuffled = s.ReadBool();
		state_cards_drawn = s.ReadBeInt32();
		state_discarded_action = s.ReadBool();
		state_destroyed_action = s.ReadBool();
		fire_rate_wait = s.ReadBeInt32();
		speed_multiplier = s.ReadBeFloat();
		child_speed_multiplier = s.ReadBeFloat();
		dampening = s.ReadBeFloat();
		explosion_radius = s.ReadBeFloat();
		spread_degrees = s.ReadBeFloat();
		pattern_degrees = s.ReadBeFloat();
		screenshake = s.ReadBeFloat();
		recoil = s.ReadBeFloat();
		damage_melee_add = s.ReadBeFloat();
		damage_projectile_add = s.ReadBeFloat();
		damage_electricity_add = s.ReadBeFloat();
		damage_fire_add = s.ReadBeFloat();
		damage_explosion_add = s.ReadBeFloat();
		damage_ice_add = s.ReadBeFloat();
		damage_slice_add = s.ReadBeFloat();
		damage_healing_add = s.ReadBeFloat();
		damage_curse_add = s.ReadBeFloat();
		damage_drill_add = s.ReadBeFloat();
		damage_null_all = s.ReadBeFloat();
		damage_critical_chance = s.ReadBeInt32();
		damage_critical_multiplier = s.ReadBeFloat();
		explosion_damage_to_materials = s.ReadBeFloat();
		knockback_force = s.ReadBeFloat();
		reload_time = s.ReadBeInt32();
		lightning_count = s.ReadBeInt32();
		material = s.ReadBeString();
		material_amount = s.ReadBeInt32();
		trail_material = s.ReadBeString();
		trail_material_amount = s.ReadBeInt32();
		bounces = s.ReadBeInt32();
		gravity = s.ReadBeFloat();
		light = s.ReadBeFloat();
		blood_count_multiplier = s.ReadBeFloat();
		gore_particles = s.ReadBeInt32();
		ragdoll_fx = s.ReadBeInt32();
		friendly_fire = s.ReadBool();
		physics_impulse_coeff = s.ReadBeFloat();
		lifetime_add = s.ReadBeInt32();
		sprite = s.ReadBeString();
		extra_entities = s.ReadBeString();
		game_effect_entities = s.ReadBeString();
		sound_loop_tag = s.ReadBeString();
		projectile_file = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(action_id);
		s.WriteBeString(action_name);
		s.WriteBeString(action_description);
		s.WriteBeString(action_sprite_filename);
		s.WriteBeString(action_unidentified_sprite_filename);
		s.WriteBeInt32(action_type);
		s.WriteBeString(action_spawn_level);
		s.WriteBeString(action_spawn_probability);
		s.WriteBeString(action_spawn_requires_flag);
		s.WriteBool(action_spawn_manual_unlock);
		s.WriteBeInt32(action_max_uses);
		s.WriteBeString(custom_xml_file);
		s.WriteBeFloat(action_mana_drain);
		s.WriteBool(action_is_dangerous_blast);
		s.WriteBeInt32(action_draw_many_count);
		s.WriteBool(action_ai_never_uses);
		s.WriteBool(action_never_unlimited);
		s.WriteBool(state_shuffled);
		s.WriteBeInt32(state_cards_drawn);
		s.WriteBool(state_discarded_action);
		s.WriteBool(state_destroyed_action);
		s.WriteBeInt32(fire_rate_wait);
		s.WriteBeFloat(speed_multiplier);
		s.WriteBeFloat(child_speed_multiplier);
		s.WriteBeFloat(dampening);
		s.WriteBeFloat(explosion_radius);
		s.WriteBeFloat(spread_degrees);
		s.WriteBeFloat(pattern_degrees);
		s.WriteBeFloat(screenshake);
		s.WriteBeFloat(recoil);
		s.WriteBeFloat(damage_melee_add);
		s.WriteBeFloat(damage_projectile_add);
		s.WriteBeFloat(damage_electricity_add);
		s.WriteBeFloat(damage_fire_add);
		s.WriteBeFloat(damage_explosion_add);
		s.WriteBeFloat(damage_ice_add);
		s.WriteBeFloat(damage_slice_add);
		s.WriteBeFloat(damage_healing_add);
		s.WriteBeFloat(damage_curse_add);
		s.WriteBeFloat(damage_drill_add);
		s.WriteBeFloat(damage_null_all);
		s.WriteBeInt32(damage_critical_chance);
		s.WriteBeFloat(damage_critical_multiplier);
		s.WriteBeFloat(explosion_damage_to_materials);
		s.WriteBeFloat(knockback_force);
		s.WriteBeInt32(reload_time);
		s.WriteBeInt32(lightning_count);
		s.WriteBeString(material);
		s.WriteBeInt32(material_amount);
		s.WriteBeString(trail_material);
		s.WriteBeInt32(trail_material_amount);
		s.WriteBeInt32(bounces);
		s.WriteBeFloat(gravity);
		s.WriteBeFloat(light);
		s.WriteBeFloat(blood_count_multiplier);
		s.WriteBeInt32(gore_particles);
		s.WriteBeInt32(ragdoll_fx);
		s.WriteBool(friendly_fire);
		s.WriteBeFloat(physics_impulse_coeff);
		s.WriteBeInt32(lifetime_add);
		s.WriteBeString(sprite);
		s.WriteBeString(extra_entities);
		s.WriteBeString(game_effect_entities);
		s.WriteBeString(sound_loop_tag);
		s.WriteBeString(projectile_file);

    }
}