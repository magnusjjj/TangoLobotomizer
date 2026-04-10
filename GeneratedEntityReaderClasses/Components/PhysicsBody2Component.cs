namespace GeneratedNoitaClasses;
public class PhysicsBody2Component {
	public UInt64 mBodyId { get; set; }
	public float linear_damping { get; set; }
	public float angular_damping { get; set; }
	public bool allow_sleep { get; set; }
	public bool fixed_rotation { get; set; }
	public bool is_bullet { get; set; }
	public bool is_static { get; set; }
	public float buoyancy { get; set; }
	public bool hax_fix_going_through_ground { get; set; }
	public bool hax_fix_going_through_sand { get; set; }
	public bool hax_wait_till_pixel_scenes_loaded { get; set; }
	public bool go_through_sand { get; set; }
	public bool auto_clean { get; set; }
	public bool force_add_update_areas { get; set; }
	public bool update_entity_transform { get; set; }
	public bool kill_entity_if_body_destroyed { get; set; }
	public bool kill_entity_after_initialized { get; set; }
	public bool manual_init { get; set; }
	public bool destroy_body_if_entity_destroyed { get; set; }
	public float root_offset_x { get; set; }
	public float root_offset_y { get; set; }
	public float init_offset_x { get; set; }
	public float init_offset_y { get; set; }
	public bool mActiveState { get; set; }
	public CVector2<float> mLocalPosition { get; set; }
	public UInt32 mPixelCountOrig { get; set; }

    public void Load(NoitaStream s){
		mBodyId = s.ReadBeUInt64();
		linear_damping = s.ReadBeFloat();
		angular_damping = s.ReadBeFloat();
		allow_sleep = s.ReadBool();
		fixed_rotation = s.ReadBool();
		is_bullet = s.ReadBool();
		is_static = s.ReadBool();
		buoyancy = s.ReadBeFloat();
		hax_fix_going_through_ground = s.ReadBool();
		hax_fix_going_through_sand = s.ReadBool();
		hax_wait_till_pixel_scenes_loaded = s.ReadBool();
		go_through_sand = s.ReadBool();
		auto_clean = s.ReadBool();
		force_add_update_areas = s.ReadBool();
		update_entity_transform = s.ReadBool();
		kill_entity_if_body_destroyed = s.ReadBool();
		kill_entity_after_initialized = s.ReadBool();
		manual_init = s.ReadBool();
		destroy_body_if_entity_destroyed = s.ReadBool();
		root_offset_x = s.ReadBeFloat();
		root_offset_y = s.ReadBeFloat();
		init_offset_x = s.ReadBeFloat();
		init_offset_y = s.ReadBeFloat();
		mActiveState = s.ReadBool();
		mLocalPosition.Load(s);
		mPixelCountOrig = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt64(mBodyId);
		s.WriteBeFloat(linear_damping);
		s.WriteBeFloat(angular_damping);
		s.WriteBool(allow_sleep);
		s.WriteBool(fixed_rotation);
		s.WriteBool(is_bullet);
		s.WriteBool(is_static);
		s.WriteBeFloat(buoyancy);
		s.WriteBool(hax_fix_going_through_ground);
		s.WriteBool(hax_fix_going_through_sand);
		s.WriteBool(hax_wait_till_pixel_scenes_loaded);
		s.WriteBool(go_through_sand);
		s.WriteBool(auto_clean);
		s.WriteBool(force_add_update_areas);
		s.WriteBool(update_entity_transform);
		s.WriteBool(kill_entity_if_body_destroyed);
		s.WriteBool(kill_entity_after_initialized);
		s.WriteBool(manual_init);
		s.WriteBool(destroy_body_if_entity_destroyed);
		s.WriteBeFloat(root_offset_x);
		s.WriteBeFloat(root_offset_y);
		s.WriteBeFloat(init_offset_x);
		s.WriteBeFloat(init_offset_y);
		s.WriteBool(mActiveState);
		mLocalPosition.Write(s);
		s.WriteBeUInt32(mPixelCountOrig);

    }
}