namespace GeneratedNoitaClasses;
public class DamageModelComponent {
	public double hp { get; set; }
	public double max_hp { get; set; }
	public double max_hp_cap { get; set; }
	public double max_hp_old { get; set; }
	public ConfigDamagesByType damage_multipliers { get; set; }
	public float critical_damage_resistance { get; set; }
	public Int32 invincibility_frames { get; set; }
	public bool falling_damages { get; set; }
	public float falling_damage_height_min { get; set; }
	public float falling_damage_height_max { get; set; }
	public float falling_damage_damage_min { get; set; }
	public float falling_damage_damage_max { get; set; }
	public bool air_needed { get; set; }
	public float air_in_lungs { get; set; }
	public float air_in_lungs_max { get; set; }
	public float air_lack_of_damage { get; set; }
	public float minimum_knockback_force { get; set; }
	public bool materials_damage { get; set; }
	public Int32 material_damage_min_cell_count { get; set; }
	public string materials_that_damage { get; set; }
	public string materials_how_much_damage { get; set; }
	public bool materials_damage_proportional_to_maxhp { get; set; }
	public bool physics_objects_damage { get; set; }
	public bool materials_create_messages { get; set; }
	public string materials_that_create_messages { get; set; }
	public string ragdoll_filenames_file { get; set; }
	public string ragdoll_material { get; set; }
	public float ragdoll_offset_x { get; set; }
	public float ragdoll_offset_y { get; set; }
	public UInt32 ragdoll_fx_forced { get; set; }
	public string blood_material { get; set; }
	public string blood_spray_material { get; set; }
	public bool blood_spray_create_some_cosmetic { get; set; }
	public float blood_multiplier { get; set; }
	public Int32 ragdoll_blood_amount_absolute { get; set; }
	public string blood_sprite_directional { get; set; }
	public string blood_sprite_large { get; set; }
	public string healing_particle_effect_entity { get; set; }
	public bool create_ragdoll { get; set; }
	public bool ragdollify_child_entity_sprites { get; set; }
	public float ragdollify_root_angular_damping { get; set; }
	public bool ragdollify_disintegrate_nonroot { get; set; }
	public bool wait_for_kill_flag_on_death { get; set; }
	public bool kill_now { get; set; }
	public bool drop_items_on_death { get; set; }
	public bool ui_report_damage { get; set; }
	public bool ui_force_report_damage { get; set; }
	public Int32 in_liquid_shooting_electrify_prob { get; set; }
	public float wet_status_effect_damage { get; set; }
	public bool is_on_fire { get; set; }
	public float fire_probability_of_ignition { get; set; }
	public Int32 fire_how_much_fire_generates { get; set; }
	public float fire_damage_ignited_amount { get; set; }
	public float fire_damage_amount { get; set; }
	public Int32 mLastElectricityResistanceFrame { get; set; }
	public Int32 mLastFrameReportedBlock { get; set; }
	public Int32 mLastMaxHpChangeFrame { get; set; }

    public void Load(NoitaStream s){
		hp = s.ReadBeDouble();
		max_hp = s.ReadBeDouble();
		max_hp_cap = s.ReadBeDouble();
		max_hp_old = s.ReadBeDouble();
		damage_multipliers.Load(s);
		critical_damage_resistance = s.ReadBeFloat();
		invincibility_frames = s.ReadBeInt32();
		falling_damages = s.ReadBool();
		falling_damage_height_min = s.ReadBeFloat();
		falling_damage_height_max = s.ReadBeFloat();
		falling_damage_damage_min = s.ReadBeFloat();
		falling_damage_damage_max = s.ReadBeFloat();
		air_needed = s.ReadBool();
		air_in_lungs = s.ReadBeFloat();
		air_in_lungs_max = s.ReadBeFloat();
		air_lack_of_damage = s.ReadBeFloat();
		minimum_knockback_force = s.ReadBeFloat();
		materials_damage = s.ReadBool();
		material_damage_min_cell_count = s.ReadBeInt32();
		materials_that_damage = s.ReadBeString();
		materials_how_much_damage = s.ReadBeString();
		materials_damage_proportional_to_maxhp = s.ReadBool();
		physics_objects_damage = s.ReadBool();
		materials_create_messages = s.ReadBool();
		materials_that_create_messages = s.ReadBeString();
		ragdoll_filenames_file = s.ReadBeString();
		ragdoll_material = s.ReadBeString();
		ragdoll_offset_x = s.ReadBeFloat();
		ragdoll_offset_y = s.ReadBeFloat();
		ragdoll_fx_forced = s.ReadBeUInt32();
		blood_material = s.ReadBeString();
		blood_spray_material = s.ReadBeString();
		blood_spray_create_some_cosmetic = s.ReadBool();
		blood_multiplier = s.ReadBeFloat();
		ragdoll_blood_amount_absolute = s.ReadBeInt32();
		blood_sprite_directional = s.ReadBeString();
		blood_sprite_large = s.ReadBeString();
		healing_particle_effect_entity = s.ReadBeString();
		create_ragdoll = s.ReadBool();
		ragdollify_child_entity_sprites = s.ReadBool();
		ragdollify_root_angular_damping = s.ReadBeFloat();
		ragdollify_disintegrate_nonroot = s.ReadBool();
		wait_for_kill_flag_on_death = s.ReadBool();
		kill_now = s.ReadBool();
		drop_items_on_death = s.ReadBool();
		ui_report_damage = s.ReadBool();
		ui_force_report_damage = s.ReadBool();
		in_liquid_shooting_electrify_prob = s.ReadBeInt32();
		wet_status_effect_damage = s.ReadBeFloat();
		is_on_fire = s.ReadBool();
		fire_probability_of_ignition = s.ReadBeFloat();
		fire_how_much_fire_generates = s.ReadBeInt32();
		fire_damage_ignited_amount = s.ReadBeFloat();
		fire_damage_amount = s.ReadBeFloat();
		mLastElectricityResistanceFrame = s.ReadBeInt32();
		mLastFrameReportedBlock = s.ReadBeInt32();
		mLastMaxHpChangeFrame = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeDouble(hp);
		s.WriteBeDouble(max_hp);
		s.WriteBeDouble(max_hp_cap);
		s.WriteBeDouble(max_hp_old);
		damage_multipliers.Write(s);
		s.WriteBeFloat(critical_damage_resistance);
		s.WriteBeInt32(invincibility_frames);
		s.WriteBool(falling_damages);
		s.WriteBeFloat(falling_damage_height_min);
		s.WriteBeFloat(falling_damage_height_max);
		s.WriteBeFloat(falling_damage_damage_min);
		s.WriteBeFloat(falling_damage_damage_max);
		s.WriteBool(air_needed);
		s.WriteBeFloat(air_in_lungs);
		s.WriteBeFloat(air_in_lungs_max);
		s.WriteBeFloat(air_lack_of_damage);
		s.WriteBeFloat(minimum_knockback_force);
		s.WriteBool(materials_damage);
		s.WriteBeInt32(material_damage_min_cell_count);
		s.WriteBeString(materials_that_damage);
		s.WriteBeString(materials_how_much_damage);
		s.WriteBool(materials_damage_proportional_to_maxhp);
		s.WriteBool(physics_objects_damage);
		s.WriteBool(materials_create_messages);
		s.WriteBeString(materials_that_create_messages);
		s.WriteBeString(ragdoll_filenames_file);
		s.WriteBeString(ragdoll_material);
		s.WriteBeFloat(ragdoll_offset_x);
		s.WriteBeFloat(ragdoll_offset_y);
		s.WriteBeUInt32(ragdoll_fx_forced);
		s.WriteBeString(blood_material);
		s.WriteBeString(blood_spray_material);
		s.WriteBool(blood_spray_create_some_cosmetic);
		s.WriteBeFloat(blood_multiplier);
		s.WriteBeInt32(ragdoll_blood_amount_absolute);
		s.WriteBeString(blood_sprite_directional);
		s.WriteBeString(blood_sprite_large);
		s.WriteBeString(healing_particle_effect_entity);
		s.WriteBool(create_ragdoll);
		s.WriteBool(ragdollify_child_entity_sprites);
		s.WriteBeFloat(ragdollify_root_angular_damping);
		s.WriteBool(ragdollify_disintegrate_nonroot);
		s.WriteBool(wait_for_kill_flag_on_death);
		s.WriteBool(kill_now);
		s.WriteBool(drop_items_on_death);
		s.WriteBool(ui_report_damage);
		s.WriteBool(ui_force_report_damage);
		s.WriteBeInt32(in_liquid_shooting_electrify_prob);
		s.WriteBeFloat(wet_status_effect_damage);
		s.WriteBool(is_on_fire);
		s.WriteBeFloat(fire_probability_of_ignition);
		s.WriteBeInt32(fire_how_much_fire_generates);
		s.WriteBeFloat(fire_damage_ignited_amount);
		s.WriteBeFloat(fire_damage_amount);
		s.WriteBeInt32(mLastElectricityResistanceFrame);
		s.WriteBeInt32(mLastFrameReportedBlock);
		s.WriteBeInt32(mLastMaxHpChangeFrame);

    }
}