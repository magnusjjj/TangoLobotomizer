namespace GeneratedNoitaClasses;
public class CharacterDataComponent {
	public Int32 platforming_type { get; set; }
	public LensValue<float> collision_aabb_min_x { get; set; }
	public LensValue<float> collision_aabb_max_x { get; set; }
	public LensValue<float> collision_aabb_min_y { get; set; }
	public LensValue<float> collision_aabb_max_y { get; set; }
	public float mass { get; set; }
	public Int32 buoyancy_check_offset_y { get; set; }
	public float liquid_velocity_coeff { get; set; }
	public float gravity { get; set; }
	public LensValue<float> fly_time_max { get; set; }
	public float fly_recharge_spd { get; set; }
	public float fly_recharge_spd_ground { get; set; }
	public bool flying_needs_recharge { get; set; }
	public Int32 flying_in_air_wait_frames { get; set; }
	public Int32 flying_recharge_removal_frames { get; set; }
	public Int32 climb_over_y { get; set; }
	public Int32 check_collision_max_size_x { get; set; }
	public Int32 check_collision_max_size_y { get; set; }
	public bool is_on_ground { get; set; }
	public bool is_on_slippery_ground { get; set; }
	public float ground_stickyness { get; set; }
	public bool effect_hit_ground { get; set; }
	public Int32 eff_hg_damage_min { get; set; }
	public Int32 eff_hg_damage_max { get; set; }
	public float eff_hg_position_x { get; set; }
	public float eff_hg_position_y { get; set; }
	public float eff_hg_size_x { get; set; }
	public float eff_hg_size_y { get; set; }
	public float eff_hg_velocity_min_x { get; set; }
	public float eff_hg_velocity_max_x { get; set; }
	public float eff_hg_velocity_min_y { get; set; }
	public float eff_hg_velocity_max_y { get; set; }
	public float eff_hg_offset_y { get; set; }
	public bool eff_hg_update_box2d { get; set; }
	public float eff_hg_b2force_multiplier { get; set; }
	public float destroy_ground { get; set; }
	public bool send_transform_update_message { get; set; }
	public bool dont_update_velocity_and_xform { get; set; }
	public float mFlyingTimeLeft { get; set; }

    public void Load(NoitaStream s){
		platforming_type = s.ReadBeInt32();
		collision_aabb_min_x.Load(s);
		collision_aabb_max_x.Load(s);
		collision_aabb_min_y.Load(s);
		collision_aabb_max_y.Load(s);
		mass = s.ReadBeFloat();
		buoyancy_check_offset_y = s.ReadBeInt32();
		liquid_velocity_coeff = s.ReadBeFloat();
		gravity = s.ReadBeFloat();
		fly_time_max.Load(s);
		fly_recharge_spd = s.ReadBeFloat();
		fly_recharge_spd_ground = s.ReadBeFloat();
		flying_needs_recharge = s.ReadBool();
		flying_in_air_wait_frames = s.ReadBeInt32();
		flying_recharge_removal_frames = s.ReadBeInt32();
		climb_over_y = s.ReadBeInt32();
		check_collision_max_size_x = s.ReadBeInt32();
		check_collision_max_size_y = s.ReadBeInt32();
		is_on_ground = s.ReadBool();
		is_on_slippery_ground = s.ReadBool();
		ground_stickyness = s.ReadBeFloat();
		effect_hit_ground = s.ReadBool();
		eff_hg_damage_min = s.ReadBeInt32();
		eff_hg_damage_max = s.ReadBeInt32();
		eff_hg_position_x = s.ReadBeFloat();
		eff_hg_position_y = s.ReadBeFloat();
		eff_hg_size_x = s.ReadBeFloat();
		eff_hg_size_y = s.ReadBeFloat();
		eff_hg_velocity_min_x = s.ReadBeFloat();
		eff_hg_velocity_max_x = s.ReadBeFloat();
		eff_hg_velocity_min_y = s.ReadBeFloat();
		eff_hg_velocity_max_y = s.ReadBeFloat();
		eff_hg_offset_y = s.ReadBeFloat();
		eff_hg_update_box2d = s.ReadBool();
		eff_hg_b2force_multiplier = s.ReadBeFloat();
		destroy_ground = s.ReadBeFloat();
		send_transform_update_message = s.ReadBool();
		dont_update_velocity_and_xform = s.ReadBool();
		mFlyingTimeLeft = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(platforming_type);
		collision_aabb_min_x.Write(s);
		collision_aabb_max_x.Write(s);
		collision_aabb_min_y.Write(s);
		collision_aabb_max_y.Write(s);
		s.WriteBeFloat(mass);
		s.WriteBeInt32(buoyancy_check_offset_y);
		s.WriteBeFloat(liquid_velocity_coeff);
		s.WriteBeFloat(gravity);
		fly_time_max.Write(s);
		s.WriteBeFloat(fly_recharge_spd);
		s.WriteBeFloat(fly_recharge_spd_ground);
		s.WriteBool(flying_needs_recharge);
		s.WriteBeInt32(flying_in_air_wait_frames);
		s.WriteBeInt32(flying_recharge_removal_frames);
		s.WriteBeInt32(climb_over_y);
		s.WriteBeInt32(check_collision_max_size_x);
		s.WriteBeInt32(check_collision_max_size_y);
		s.WriteBool(is_on_ground);
		s.WriteBool(is_on_slippery_ground);
		s.WriteBeFloat(ground_stickyness);
		s.WriteBool(effect_hit_ground);
		s.WriteBeInt32(eff_hg_damage_min);
		s.WriteBeInt32(eff_hg_damage_max);
		s.WriteBeFloat(eff_hg_position_x);
		s.WriteBeFloat(eff_hg_position_y);
		s.WriteBeFloat(eff_hg_size_x);
		s.WriteBeFloat(eff_hg_size_y);
		s.WriteBeFloat(eff_hg_velocity_min_x);
		s.WriteBeFloat(eff_hg_velocity_max_x);
		s.WriteBeFloat(eff_hg_velocity_min_y);
		s.WriteBeFloat(eff_hg_velocity_max_y);
		s.WriteBeFloat(eff_hg_offset_y);
		s.WriteBool(eff_hg_update_box2d);
		s.WriteBeFloat(eff_hg_b2force_multiplier);
		s.WriteBeFloat(destroy_ground);
		s.WriteBool(send_transform_update_message);
		s.WriteBool(dont_update_velocity_and_xform);
		s.WriteBeFloat(mFlyingTimeLeft);

    }
}