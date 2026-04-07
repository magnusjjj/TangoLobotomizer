namespace GeneratedNoitaClasses;
public class PhysicsBodyComponent{
	public bool is_external{ get; set; }
	public bool hax_fix_going_through_ground{ get; set; }
	public bool hax_fix_going_through_sand{ get; set; }
	public bool hax_wait_till_pixel_scenes_loaded{ get; set; }
	public int uid{ get; set; }
	public bool is_enabled{ get; set; }
	public float linear_damping{ get; set; }
	public float angular_damping{ get; set; }
	public bool allow_sleep{ get; set; }
	public bool fixed_rotation{ get; set; }
	public float buoyancy{ get; set; }
	public float gravity_scale_if_has_no_image_shapes{ get; set; }
	public bool is_bullet{ get; set; }
	public bool is_static{ get; set; }
	public bool is_kinematic{ get; set; }
	public bool is_character{ get; set; }
	public bool go_through_sand{ get; set; }
	public bool gridworld_box2d{ get; set; }
	public bool auto_clean{ get; set; }
	public bool on_death_leave_physics_body{ get; set; }
	public bool on_death_really_leave_body{ get; set; }
	public bool update_entity_transform{ get; set; }
	public bool force_add_update_areas{ get; set; }
	public bool kills_entity{ get; set; }
	public bool projectiles_rotate_toward_velocity{ get; set; }
	public List<float> initial_velocity{ get; set; }
	public bool randomize_init_velocity{ get; set; }
	public bool mActiveState{ get; set; }

}