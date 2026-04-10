namespace GeneratedNoitaClasses;
public class GameEffectComponent {
	public UInt32 effect { get; set; }
	public string custom_effect_id { get; set; }
	public Int32 frames { get; set; }
	public Int32 exclusivity_group { get; set; }
	public bool report_block_msg { get; set; }
	public bool disable_movement { get; set; }
	public UInt32 ragdoll_effect { get; set; }
	public Int32 ragdoll_material { get; set; }
	public string ragdoll_effect_custom_entity_file { get; set; }
	public bool ragdoll_fx_custom_entity_apply_only_to_largest_body { get; set; }
	public string polymorph_target { get; set; }
	public string mSerializedData { get; set; }
	public UInt32 mCaster { get; set; }
	public Int32 mCasterHerdId { get; set; }
	public Int32 teleportation_probability { get; set; }
	public Int32 teleportation_delay_min_frames { get; set; }
	public float teleportation_radius_min { get; set; }
	public float teleportation_radius_max { get; set; }
	public Int32 teleportations_num { get; set; }
	public double no_heal_max_hp_cap { get; set; }
	public UInt32 causing_status_effect { get; set; }
	public bool caused_by_ingestion_status_effect { get; set; }
	public bool caused_by_stains { get; set; }
	public bool mCharmDisabledCameraBound { get; set; }
	public bool mCharmEnabledTeleporting { get; set; }
	public bool mInvisible { get; set; }
	public Int32 mCounter { get; set; }
	public Int32 mCooldown { get; set; }
	public bool mIsExtension { get; set; }
	public bool mIsSpent { get; set; }

    public void Load(NoitaStream s){
		effect = s.ReadBeUInt32();
		custom_effect_id = s.ReadBeString();
		frames = s.ReadBeInt32();
		exclusivity_group = s.ReadBeInt32();
		report_block_msg = s.ReadBool();
		disable_movement = s.ReadBool();
		ragdoll_effect = s.ReadBeUInt32();
		ragdoll_material = s.ReadBeInt32();
		ragdoll_effect_custom_entity_file = s.ReadBeString();
		ragdoll_fx_custom_entity_apply_only_to_largest_body = s.ReadBool();
		polymorph_target = s.ReadBeString();
		mSerializedData = s.ReadBeString();
		mCaster = s.ReadBeUInt32();
		mCasterHerdId = s.ReadBeInt32();
		teleportation_probability = s.ReadBeInt32();
		teleportation_delay_min_frames = s.ReadBeInt32();
		teleportation_radius_min = s.ReadBeFloat();
		teleportation_radius_max = s.ReadBeFloat();
		teleportations_num = s.ReadBeInt32();
		no_heal_max_hp_cap = s.ReadBeDouble();
		causing_status_effect = s.ReadBeUInt32();
		caused_by_ingestion_status_effect = s.ReadBool();
		caused_by_stains = s.ReadBool();
		mCharmDisabledCameraBound = s.ReadBool();
		mCharmEnabledTeleporting = s.ReadBool();
		mInvisible = s.ReadBool();
		mCounter = s.ReadBeInt32();
		mCooldown = s.ReadBeInt32();
		mIsExtension = s.ReadBool();
		mIsSpent = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(effect);
		s.WriteBeString(custom_effect_id);
		s.WriteBeInt32(frames);
		s.WriteBeInt32(exclusivity_group);
		s.WriteBool(report_block_msg);
		s.WriteBool(disable_movement);
		s.WriteBeUInt32(ragdoll_effect);
		s.WriteBeInt32(ragdoll_material);
		s.WriteBeString(ragdoll_effect_custom_entity_file);
		s.WriteBool(ragdoll_fx_custom_entity_apply_only_to_largest_body);
		s.WriteBeString(polymorph_target);
		s.WriteBeString(mSerializedData);
		s.WriteBeUInt32(mCaster);
		s.WriteBeInt32(mCasterHerdId);
		s.WriteBeInt32(teleportation_probability);
		s.WriteBeInt32(teleportation_delay_min_frames);
		s.WriteBeFloat(teleportation_radius_min);
		s.WriteBeFloat(teleportation_radius_max);
		s.WriteBeInt32(teleportations_num);
		s.WriteBeDouble(no_heal_max_hp_cap);
		s.WriteBeUInt32(causing_status_effect);
		s.WriteBool(caused_by_ingestion_status_effect);
		s.WriteBool(caused_by_stains);
		s.WriteBool(mCharmDisabledCameraBound);
		s.WriteBool(mCharmEnabledTeleporting);
		s.WriteBool(mInvisible);
		s.WriteBeInt32(mCounter);
		s.WriteBeInt32(mCooldown);
		s.WriteBool(mIsExtension);
		s.WriteBool(mIsSpent);

    }
}