namespace GeneratedNoitaClasses;
public class CharacterDataComponent{
	public int platforming_type{ get; set; }
	public float collision_aabb_min_x{ get; set; }
	public float collision_aabb_max_x{ get; set; }
	public float collision_aabb_min_y{ get; set; }
	public float collision_aabb_max_y{ get; set; }
	public float mass{ get; set; }
	public int buoyancy_check_offset_y{ get; set; }
	public float liquid_velocity_coeff{ get; set; }
	public float gravity{ get; set; }
	public float fly_time_max{ get; set; }
	public float fly_recharge_spd{ get; set; }
	public float fly_recharge_spd_ground{ get; set; }
	public bool flying_needs_recharge{ get; set; }
	public int flying_in_air_wait_frames{ get; set; }
	public int flying_recharge_removal_frames{ get; set; }
	public int climb_over_y{ get; set; }
	public int check_collision_max_size_x{ get; set; }
	public int check_collision_max_size_y{ get; set; }
	public bool is_on_ground{ get; set; }
	public bool is_on_slippery_ground{ get; set; }
	public float ground_stickyness{ get; set; }
	public bool effect_hit_ground{ get; set; }
	public int eff_hg_damage_min{ get; set; }
	public int eff_hg_damage_max{ get; set; }
	public float eff_hg_position_x{ get; set; }
	public float eff_hg_position_y{ get; set; }
	public float eff_hg_size_x{ get; set; }
	public float eff_hg_size_y{ get; set; }
	public float eff_hg_velocity_min_x{ get; set; }
	public float eff_hg_velocity_max_x{ get; set; }
	public float eff_hg_velocity_min_y{ get; set; }
	public float eff_hg_velocity_max_y{ get; set; }
	public float eff_hg_offset_y{ get; set; }
	public bool eff_hg_update_box2d{ get; set; }
	public float eff_hg_b2force_multiplier{ get; set; }
	public float destroy_ground{ get; set; }
	public bool send_transform_update_message{ get; set; }
	public bool dont_update_velocity_and_xform{ get; set; }
	public float mFlyingTimeLeft{ get; set; }

}