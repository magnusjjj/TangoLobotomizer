namespace GeneratedNoitaClasses;
public class PhysicsBody2Component{
	public UInt64 mBodyId{ get; set; }
	public float linear_damping{ get; set; }
	public float angular_damping{ get; set; }
	public bool allow_sleep{ get; set; }
	public bool fixed_rotation{ get; set; }
	public bool is_bullet{ get; set; }
	public bool is_static{ get; set; }
	public float buoyancy{ get; set; }
	public bool hax_fix_going_through_ground{ get; set; }
	public bool hax_fix_going_through_sand{ get; set; }
	public bool hax_wait_till_pixel_scenes_loaded{ get; set; }
	public bool go_through_sand{ get; set; }
	public bool auto_clean{ get; set; }
	public bool force_add_update_areas{ get; set; }
	public bool update_entity_transform{ get; set; }
	public bool kill_entity_if_body_destroyed{ get; set; }
	public bool kill_entity_after_initialized{ get; set; }
	public bool manual_init{ get; set; }
	public bool destroy_body_if_entity_destroyed{ get; set; }
	public float root_offset_x{ get; set; }
	public float root_offset_y{ get; set; }
	public float init_offset_x{ get; set; }
	public float init_offset_y{ get; set; }
	public bool mActiveState{ get; set; }
	public List<float> mLocalPosition{ get; set; }
	public UInt32 mPixelCountOrig{ get; set; }

}