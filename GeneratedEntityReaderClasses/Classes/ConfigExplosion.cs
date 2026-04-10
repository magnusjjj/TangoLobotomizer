namespace GeneratedNoitaClasses;
public class ConfigExplosion {
	public bool never_cache { get; set; }
	public float explosion_radius { get; set; }
	public string explosion_sprite { get; set; }
	public bool explosion_sprite_emissive { get; set; }
	public bool explosion_sprite_additive { get; set; }
	public bool explosion_sprite_random_rotation { get; set; }
	public float explosion_sprite_lifetime { get; set; }
	public float damage { get; set; }
	public ConfigDamageCritical damage_critical { get; set; }
	public float camera_shake { get; set; }
	public bool particle_effect { get; set; }
	public string load_this_entity { get; set; }
	public bool light_enabled { get; set; }
	public float light_fade_time { get; set; }
	public UInt32 light_r { get; set; }
	public UInt32 light_g { get; set; }
	public UInt32 light_b { get; set; }
	public float light_radius_coeff { get; set; }
	public bool hole_enabled { get; set; }
	public bool destroy_non_platform_solid_enabled { get; set; }
	public Int32 electricity_count { get; set; }
	public Int32 min_radius_for_cracks { get; set; }
	public Int32 crack_count { get; set; }
	public float knockback_force { get; set; }
	public bool hole_destroy_liquid { get; set; }
	public bool hole_destroy_physics_dynamic { get; set; }
	public string create_cell_material { get; set; }
	public Int32 create_cell_probability { get; set; }
	public Int32 background_lightning_count { get; set; }
	public string spark_material { get; set; }
	public Int32 material_sparks_min_hp { get; set; }
	public Int32 material_sparks_probability { get; set; }
	public Int32 material_sparks_count_min { get; set; }
	public Int32 material_sparks_count_max { get; set; }
	public bool material_sparks_enabled { get; set; }
	public bool material_sparks_real { get; set; }
	public bool material_sparks_scale_with_hp { get; set; }
	public bool sparks_enabled { get; set; }
	public Int32 sparks_count_min { get; set; }
	public Int32 sparks_count_max { get; set; }
	public float sparks_inner_radius_coeff { get; set; }
	public bool stains_enabled { get; set; }
	public float stains_radius { get; set; }
	public Int32 ray_energy { get; set; }
	public Int32 max_durability_to_destroy { get; set; }
	public Int32 gore_particle_count { get; set; }
	public bool shake_vegetation { get; set; }
	public bool damage_mortals { get; set; }
	public bool physics_throw_enabled { get; set; }
	public ValueRange physics_explosion_power { get; set; }
	public float physics_multiplier_ragdoll_force { get; set; }
	public float cell_explosion_power { get; set; }
	public float cell_explosion_radius_min { get; set; }
	public float cell_explosion_radius_max { get; set; }
	public float cell_explosion_velocity_min { get; set; }
	public float cell_explosion_damage_required { get; set; }
	public float cell_explosion_probability { get; set; }
	public float cell_explosion_power_ragdoll_coeff { get; set; }
	public bool pixel_sprites_enabled { get; set; }
	public bool is_digger { get; set; }
	public bool audio_enabled { get; set; }
	public string audio_event_name { get; set; }
	public float audio_liquid_amount_normalized { get; set; }
	public ValueRangeInt delay { get; set; }
	public Int32 explosion_delay_id { get; set; }
	public bool not_scaled_by_gamefx { get; set; }

    public void Load(NoitaStream s){
		never_cache = s.ReadBool();
		explosion_radius = s.ReadBeFloat();
		explosion_sprite = s.ReadBeString();
		explosion_sprite_emissive = s.ReadBool();
		explosion_sprite_additive = s.ReadBool();
		explosion_sprite_random_rotation = s.ReadBool();
		explosion_sprite_lifetime = s.ReadBeFloat();
		damage = s.ReadBeFloat();
		damage_critical.Load(s);
		camera_shake = s.ReadBeFloat();
		particle_effect = s.ReadBool();
		load_this_entity = s.ReadBeString();
		light_enabled = s.ReadBool();
		light_fade_time = s.ReadBeFloat();
		light_r = s.ReadBeUInt32();
		light_g = s.ReadBeUInt32();
		light_b = s.ReadBeUInt32();
		light_radius_coeff = s.ReadBeFloat();
		hole_enabled = s.ReadBool();
		destroy_non_platform_solid_enabled = s.ReadBool();
		electricity_count = s.ReadBeInt32();
		min_radius_for_cracks = s.ReadBeInt32();
		crack_count = s.ReadBeInt32();
		knockback_force = s.ReadBeFloat();
		hole_destroy_liquid = s.ReadBool();
		hole_destroy_physics_dynamic = s.ReadBool();
		create_cell_material = s.ReadBeString();
		create_cell_probability = s.ReadBeInt32();
		background_lightning_count = s.ReadBeInt32();
		spark_material = s.ReadBeString();
		material_sparks_min_hp = s.ReadBeInt32();
		material_sparks_probability = s.ReadBeInt32();
		material_sparks_count_min = s.ReadBeInt32();
		material_sparks_count_max = s.ReadBeInt32();
		material_sparks_enabled = s.ReadBool();
		material_sparks_real = s.ReadBool();
		material_sparks_scale_with_hp = s.ReadBool();
		sparks_enabled = s.ReadBool();
		sparks_count_min = s.ReadBeInt32();
		sparks_count_max = s.ReadBeInt32();
		sparks_inner_radius_coeff = s.ReadBeFloat();
		stains_enabled = s.ReadBool();
		stains_radius = s.ReadBeFloat();
		ray_energy = s.ReadBeInt32();
		max_durability_to_destroy = s.ReadBeInt32();
		gore_particle_count = s.ReadBeInt32();
		shake_vegetation = s.ReadBool();
		damage_mortals = s.ReadBool();
		physics_throw_enabled = s.ReadBool();
		physics_explosion_power.Load(s);
		physics_multiplier_ragdoll_force = s.ReadBeFloat();
		cell_explosion_power = s.ReadBeFloat();
		cell_explosion_radius_min = s.ReadBeFloat();
		cell_explosion_radius_max = s.ReadBeFloat();
		cell_explosion_velocity_min = s.ReadBeFloat();
		cell_explosion_damage_required = s.ReadBeFloat();
		cell_explosion_probability = s.ReadBeFloat();
		cell_explosion_power_ragdoll_coeff = s.ReadBeFloat();
		pixel_sprites_enabled = s.ReadBool();
		is_digger = s.ReadBool();
		audio_enabled = s.ReadBool();
		audio_event_name = s.ReadBeString();
		audio_liquid_amount_normalized = s.ReadBeFloat();
		delay.Load(s);
		explosion_delay_id = s.ReadBeInt32();
		not_scaled_by_gamefx = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(never_cache);
		s.WriteBeFloat(explosion_radius);
		s.WriteBeString(explosion_sprite);
		s.WriteBool(explosion_sprite_emissive);
		s.WriteBool(explosion_sprite_additive);
		s.WriteBool(explosion_sprite_random_rotation);
		s.WriteBeFloat(explosion_sprite_lifetime);
		s.WriteBeFloat(damage);
		damage_critical.Write(s);
		s.WriteBeFloat(camera_shake);
		s.WriteBool(particle_effect);
		s.WriteBeString(load_this_entity);
		s.WriteBool(light_enabled);
		s.WriteBeFloat(light_fade_time);
		s.WriteBeUInt32(light_r);
		s.WriteBeUInt32(light_g);
		s.WriteBeUInt32(light_b);
		s.WriteBeFloat(light_radius_coeff);
		s.WriteBool(hole_enabled);
		s.WriteBool(destroy_non_platform_solid_enabled);
		s.WriteBeInt32(electricity_count);
		s.WriteBeInt32(min_radius_for_cracks);
		s.WriteBeInt32(crack_count);
		s.WriteBeFloat(knockback_force);
		s.WriteBool(hole_destroy_liquid);
		s.WriteBool(hole_destroy_physics_dynamic);
		s.WriteBeString(create_cell_material);
		s.WriteBeInt32(create_cell_probability);
		s.WriteBeInt32(background_lightning_count);
		s.WriteBeString(spark_material);
		s.WriteBeInt32(material_sparks_min_hp);
		s.WriteBeInt32(material_sparks_probability);
		s.WriteBeInt32(material_sparks_count_min);
		s.WriteBeInt32(material_sparks_count_max);
		s.WriteBool(material_sparks_enabled);
		s.WriteBool(material_sparks_real);
		s.WriteBool(material_sparks_scale_with_hp);
		s.WriteBool(sparks_enabled);
		s.WriteBeInt32(sparks_count_min);
		s.WriteBeInt32(sparks_count_max);
		s.WriteBeFloat(sparks_inner_radius_coeff);
		s.WriteBool(stains_enabled);
		s.WriteBeFloat(stains_radius);
		s.WriteBeInt32(ray_energy);
		s.WriteBeInt32(max_durability_to_destroy);
		s.WriteBeInt32(gore_particle_count);
		s.WriteBool(shake_vegetation);
		s.WriteBool(damage_mortals);
		s.WriteBool(physics_throw_enabled);
		physics_explosion_power.Write(s);
		s.WriteBeFloat(physics_multiplier_ragdoll_force);
		s.WriteBeFloat(cell_explosion_power);
		s.WriteBeFloat(cell_explosion_radius_min);
		s.WriteBeFloat(cell_explosion_radius_max);
		s.WriteBeFloat(cell_explosion_velocity_min);
		s.WriteBeFloat(cell_explosion_damage_required);
		s.WriteBeFloat(cell_explosion_probability);
		s.WriteBeFloat(cell_explosion_power_ragdoll_coeff);
		s.WriteBool(pixel_sprites_enabled);
		s.WriteBool(is_digger);
		s.WriteBool(audio_enabled);
		s.WriteBeString(audio_event_name);
		s.WriteBeFloat(audio_liquid_amount_normalized);
		delay.Write(s);
		s.WriteBeInt32(explosion_delay_id);
		s.WriteBool(not_scaled_by_gamefx);

    }
}