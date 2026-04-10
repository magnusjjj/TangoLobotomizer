namespace GeneratedNoitaClasses;
public class ProjectileComponent {
	public UInt32 projectile_type { get; set; }
	public Int32 lifetime { get; set; }
	public Int32 lifetime_randomness { get; set; }
	public bool on_lifetime_out_explode { get; set; }
	public bool collide_with_world { get; set; }
	public ConfigGunActionInfo config { get; set; }
	public float speed_min { get; set; }
	public float speed_max { get; set; }
	public float friction { get; set; }
	public float direction_random_rad { get; set; }
	public float direction_nonrandom_rad { get; set; }
	public float lob_min { get; set; }
	public float lob_max { get; set; }
	public float camera_shake_when_shot { get; set; }
	public float shoot_light_flash_radius { get; set; }
	public UInt32 shoot_light_flash_r { get; set; }
	public UInt32 shoot_light_flash_g { get; set; }
	public UInt32 shoot_light_flash_b { get; set; }
	public bool create_shell_casing { get; set; }
	public string shell_casing_material { get; set; }
	public CVector2<float> shell_casing_offset { get; set; }
	public string muzzle_flash_file { get; set; }
	public Int32 bounces_left { get; set; }
	public float bounce_energy { get; set; }
	public bool bounce_always { get; set; }
	public bool bounce_at_any_angle { get; set; }
	public bool attach_to_parent_trigger { get; set; }
	public string bounce_fx_file { get; set; }
	public float angular_velocity { get; set; }
	public bool velocity_sets_rotation { get; set; }
	public bool velocity_sets_scale { get; set; }
	public float velocity_sets_scale_coeff { get; set; }
	public bool velocity_sets_y_flip { get; set; }
	public float velocity_updates_animation { get; set; }
	public float ground_penetration_coeff { get; set; }
	public Int32 ground_penetration_max_durability_to_destroy { get; set; }
	public string go_through_this_material { get; set; }
	public bool do_moveto_update { get; set; }
	public Int32 on_death_duplicate_remaining { get; set; }
	public bool on_death_gfx_leave_sprite { get; set; }
	public bool on_death_explode { get; set; }
	public bool on_death_emit_particle { get; set; }
	public Int32 on_death_emit_particle_count { get; set; }
	public bool die_on_liquid_collision { get; set; }
	public bool die_on_low_velocity { get; set; }
	public float die_on_low_velocity_limit { get; set; }
	public string on_death_emit_particle_type { get; set; }
	public bool on_death_particle_check_concrete { get; set; }
	public bool ground_collision_fx { get; set; }
	public bool explosion_dont_damage_shooter { get; set; }
	public ConfigExplosion config_explosion { get; set; }
	public float on_death_item_pickable_radius { get; set; }
	public bool penetrate_world { get; set; }
	public float penetrate_world_velocity_coeff { get; set; }
	public bool penetrate_entities { get; set; }
	public bool on_collision_die { get; set; }
	public bool on_collision_remove_projectile { get; set; }
	public bool on_collision_spawn_entity { get; set; }
	public string spawn_entity { get; set; }
	public bool spawn_entity_is_projectile { get; set; }
	public float physics_impulse_coeff { get; set; }
	public Int32 damage_every_x_frames { get; set; }
	public bool damage_scaled_by_speed { get; set; }
	public float damage_scale_max_speed { get; set; }
	public UInt32 ragdoll_fx_on_collision { get; set; }
	public bool collide_with_entities { get; set; }
	public string collide_with_tag { get; set; }
	public string dont_collide_with_tag { get; set; }
	public Int32 collide_with_shooter_frames { get; set; }
	public bool friendly_fire { get; set; }
	public float damage { get; set; }
	public ConfigDamagesByType damage_by_type { get; set; }
	public ConfigDamageCritical damage_critical { get; set; }
	public float knockback_force { get; set; }
	public float ragdoll_force_multiplier { get; set; }
	public float hit_particle_force_multiplier { get; set; }
	public float blood_count_multiplier { get; set; }
	public string damage_game_effect_entities { get; set; }
	public bool never_hit_player { get; set; }
	public bool collect_materials_to_shooter { get; set; }
	public bool play_damage_sounds { get; set; }
	public Int32 mLastFrameDamaged { get; set; }

    public void Load(NoitaStream s){
		projectile_type = s.ReadBeUInt32();
		lifetime = s.ReadBeInt32();
		lifetime_randomness = s.ReadBeInt32();
		on_lifetime_out_explode = s.ReadBool();
		collide_with_world = s.ReadBool();
		config.Load(s);
		speed_min = s.ReadBeFloat();
		speed_max = s.ReadBeFloat();
		friction = s.ReadBeFloat();
		direction_random_rad = s.ReadBeFloat();
		direction_nonrandom_rad = s.ReadBeFloat();
		lob_min = s.ReadBeFloat();
		lob_max = s.ReadBeFloat();
		camera_shake_when_shot = s.ReadBeFloat();
		shoot_light_flash_radius = s.ReadBeFloat();
		shoot_light_flash_r = s.ReadBeUInt32();
		shoot_light_flash_g = s.ReadBeUInt32();
		shoot_light_flash_b = s.ReadBeUInt32();
		create_shell_casing = s.ReadBool();
		shell_casing_material = s.ReadBeString();
		shell_casing_offset.Load(s);
		muzzle_flash_file = s.ReadBeString();
		bounces_left = s.ReadBeInt32();
		bounce_energy = s.ReadBeFloat();
		bounce_always = s.ReadBool();
		bounce_at_any_angle = s.ReadBool();
		attach_to_parent_trigger = s.ReadBool();
		bounce_fx_file = s.ReadBeString();
		angular_velocity = s.ReadBeFloat();
		velocity_sets_rotation = s.ReadBool();
		velocity_sets_scale = s.ReadBool();
		velocity_sets_scale_coeff = s.ReadBeFloat();
		velocity_sets_y_flip = s.ReadBool();
		velocity_updates_animation = s.ReadBeFloat();
		ground_penetration_coeff = s.ReadBeFloat();
		ground_penetration_max_durability_to_destroy = s.ReadBeInt32();
		go_through_this_material = s.ReadBeString();
		do_moveto_update = s.ReadBool();
		on_death_duplicate_remaining = s.ReadBeInt32();
		on_death_gfx_leave_sprite = s.ReadBool();
		on_death_explode = s.ReadBool();
		on_death_emit_particle = s.ReadBool();
		on_death_emit_particle_count = s.ReadBeInt32();
		die_on_liquid_collision = s.ReadBool();
		die_on_low_velocity = s.ReadBool();
		die_on_low_velocity_limit = s.ReadBeFloat();
		on_death_emit_particle_type = s.ReadBeString();
		on_death_particle_check_concrete = s.ReadBool();
		ground_collision_fx = s.ReadBool();
		explosion_dont_damage_shooter = s.ReadBool();
		config_explosion.Load(s);
		on_death_item_pickable_radius = s.ReadBeFloat();
		penetrate_world = s.ReadBool();
		penetrate_world_velocity_coeff = s.ReadBeFloat();
		penetrate_entities = s.ReadBool();
		on_collision_die = s.ReadBool();
		on_collision_remove_projectile = s.ReadBool();
		on_collision_spawn_entity = s.ReadBool();
		spawn_entity = s.ReadBeString();
		spawn_entity_is_projectile = s.ReadBool();
		physics_impulse_coeff = s.ReadBeFloat();
		damage_every_x_frames = s.ReadBeInt32();
		damage_scaled_by_speed = s.ReadBool();
		damage_scale_max_speed = s.ReadBeFloat();
		ragdoll_fx_on_collision = s.ReadBeUInt32();
		collide_with_entities = s.ReadBool();
		collide_with_tag = s.ReadBeString();
		dont_collide_with_tag = s.ReadBeString();
		collide_with_shooter_frames = s.ReadBeInt32();
		friendly_fire = s.ReadBool();
		damage = s.ReadBeFloat();
		damage_by_type.Load(s);
		damage_critical.Load(s);
		knockback_force = s.ReadBeFloat();
		ragdoll_force_multiplier = s.ReadBeFloat();
		hit_particle_force_multiplier = s.ReadBeFloat();
		blood_count_multiplier = s.ReadBeFloat();
		damage_game_effect_entities = s.ReadBeString();
		never_hit_player = s.ReadBool();
		collect_materials_to_shooter = s.ReadBool();
		play_damage_sounds = s.ReadBool();
		mLastFrameDamaged = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(projectile_type);
		s.WriteBeInt32(lifetime);
		s.WriteBeInt32(lifetime_randomness);
		s.WriteBool(on_lifetime_out_explode);
		s.WriteBool(collide_with_world);
		config.Write(s);
		s.WriteBeFloat(speed_min);
		s.WriteBeFloat(speed_max);
		s.WriteBeFloat(friction);
		s.WriteBeFloat(direction_random_rad);
		s.WriteBeFloat(direction_nonrandom_rad);
		s.WriteBeFloat(lob_min);
		s.WriteBeFloat(lob_max);
		s.WriteBeFloat(camera_shake_when_shot);
		s.WriteBeFloat(shoot_light_flash_radius);
		s.WriteBeUInt32(shoot_light_flash_r);
		s.WriteBeUInt32(shoot_light_flash_g);
		s.WriteBeUInt32(shoot_light_flash_b);
		s.WriteBool(create_shell_casing);
		s.WriteBeString(shell_casing_material);
		shell_casing_offset.Write(s);
		s.WriteBeString(muzzle_flash_file);
		s.WriteBeInt32(bounces_left);
		s.WriteBeFloat(bounce_energy);
		s.WriteBool(bounce_always);
		s.WriteBool(bounce_at_any_angle);
		s.WriteBool(attach_to_parent_trigger);
		s.WriteBeString(bounce_fx_file);
		s.WriteBeFloat(angular_velocity);
		s.WriteBool(velocity_sets_rotation);
		s.WriteBool(velocity_sets_scale);
		s.WriteBeFloat(velocity_sets_scale_coeff);
		s.WriteBool(velocity_sets_y_flip);
		s.WriteBeFloat(velocity_updates_animation);
		s.WriteBeFloat(ground_penetration_coeff);
		s.WriteBeInt32(ground_penetration_max_durability_to_destroy);
		s.WriteBeString(go_through_this_material);
		s.WriteBool(do_moveto_update);
		s.WriteBeInt32(on_death_duplicate_remaining);
		s.WriteBool(on_death_gfx_leave_sprite);
		s.WriteBool(on_death_explode);
		s.WriteBool(on_death_emit_particle);
		s.WriteBeInt32(on_death_emit_particle_count);
		s.WriteBool(die_on_liquid_collision);
		s.WriteBool(die_on_low_velocity);
		s.WriteBeFloat(die_on_low_velocity_limit);
		s.WriteBeString(on_death_emit_particle_type);
		s.WriteBool(on_death_particle_check_concrete);
		s.WriteBool(ground_collision_fx);
		s.WriteBool(explosion_dont_damage_shooter);
		config_explosion.Write(s);
		s.WriteBeFloat(on_death_item_pickable_radius);
		s.WriteBool(penetrate_world);
		s.WriteBeFloat(penetrate_world_velocity_coeff);
		s.WriteBool(penetrate_entities);
		s.WriteBool(on_collision_die);
		s.WriteBool(on_collision_remove_projectile);
		s.WriteBool(on_collision_spawn_entity);
		s.WriteBeString(spawn_entity);
		s.WriteBool(spawn_entity_is_projectile);
		s.WriteBeFloat(physics_impulse_coeff);
		s.WriteBeInt32(damage_every_x_frames);
		s.WriteBool(damage_scaled_by_speed);
		s.WriteBeFloat(damage_scale_max_speed);
		s.WriteBeUInt32(ragdoll_fx_on_collision);
		s.WriteBool(collide_with_entities);
		s.WriteBeString(collide_with_tag);
		s.WriteBeString(dont_collide_with_tag);
		s.WriteBeInt32(collide_with_shooter_frames);
		s.WriteBool(friendly_fire);
		s.WriteBeFloat(damage);
		damage_by_type.Write(s);
		damage_critical.Write(s);
		s.WriteBeFloat(knockback_force);
		s.WriteBeFloat(ragdoll_force_multiplier);
		s.WriteBeFloat(hit_particle_force_multiplier);
		s.WriteBeFloat(blood_count_multiplier);
		s.WriteBeString(damage_game_effect_entities);
		s.WriteBool(never_hit_player);
		s.WriteBool(collect_materials_to_shooter);
		s.WriteBool(play_damage_sounds);
		s.WriteBeInt32(mLastFrameDamaged);

    }
}