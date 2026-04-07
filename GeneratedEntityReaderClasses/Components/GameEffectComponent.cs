namespace GeneratedNoitaClasses;
public class GameEffectComponent{
	public GAME_EFFECT effect{ get; set; }
	public string custom_effect_id{ get; set; }
	public int frames{ get; set; }
	public int exclusivity_group{ get; set; }
	public bool report_block_msg{ get; set; }
	public bool disable_movement{ get; set; }
	public RAGDOLL_FX ragdoll_effect{ get; set; }
	public int ragdoll_material{ get; set; }
	public string ragdoll_effect_custom_entity_file{ get; set; }
	public bool ragdoll_fx_custom_entity_apply_only_to_largest_body{ get; set; }
	public string polymorph_target{ get; set; }
	public string mSerializedData{ get; set; }
	public UInt32 mCaster{ get; set; }
	public int mCasterHerdId{ get; set; }
	public int teleportation_probability{ get; set; }
	public int teleportation_delay_min_frames{ get; set; }
	public float teleportation_radius_min{ get; set; }
	public float teleportation_radius_max{ get; set; }
	public int teleportations_num{ get; set; }
	public double no_heal_max_hp_cap{ get; set; }
	public UInt32 causing_status_effect{ get; set; }
	public bool caused_by_ingestion_status_effect{ get; set; }
	public bool caused_by_stains{ get; set; }
	public bool mCharmDisabledCameraBound{ get; set; }
	public bool mCharmEnabledTeleporting{ get; set; }
	public bool mInvisible{ get; set; }
	public int mCounter{ get; set; }
	public int mCooldown{ get; set; }
	public bool mIsExtension{ get; set; }
	public bool mIsSpent{ get; set; }

}