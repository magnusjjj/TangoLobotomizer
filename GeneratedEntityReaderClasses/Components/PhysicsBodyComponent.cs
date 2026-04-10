namespace GeneratedNoitaClasses;
public class PhysicsBodyComponent {
	public bool is_external { get; set; }
	public bool hax_fix_going_through_ground { get; set; }
	public bool hax_fix_going_through_sand { get; set; }
	public bool hax_wait_till_pixel_scenes_loaded { get; set; }
	public Int32 uid { get; set; }
	public bool is_enabled { get; set; }
	public float linear_damping { get; set; }
	public float angular_damping { get; set; }
	public bool allow_sleep { get; set; }
	public bool fixed_rotation { get; set; }
	public float buoyancy { get; set; }
	public float gravity_scale_if_has_no_image_shapes { get; set; }
	public bool is_bullet { get; set; }
	public bool is_static { get; set; }
	public bool is_kinematic { get; set; }
	public bool is_character { get; set; }
	public bool go_through_sand { get; set; }
	public bool gridworld_box2d { get; set; }
	public bool auto_clean { get; set; }
	public bool on_death_leave_physics_body { get; set; }
	public bool on_death_really_leave_body { get; set; }
	public bool update_entity_transform { get; set; }
	public bool force_add_update_areas { get; set; }
	public bool kills_entity { get; set; }
	public bool projectiles_rotate_toward_velocity { get; set; }
	public CVector2<float> initial_velocity { get; set; }
	public bool randomize_init_velocity { get; set; }
	public bool mActiveState { get; set; }

    public void Load(NoitaStream s){
		is_external = s.ReadBool();
		hax_fix_going_through_ground = s.ReadBool();
		hax_fix_going_through_sand = s.ReadBool();
		hax_wait_till_pixel_scenes_loaded = s.ReadBool();
		uid = s.ReadBeInt32();
		is_enabled = s.ReadBool();
		linear_damping = s.ReadBeFloat();
		angular_damping = s.ReadBeFloat();
		allow_sleep = s.ReadBool();
		fixed_rotation = s.ReadBool();
		buoyancy = s.ReadBeFloat();
		gravity_scale_if_has_no_image_shapes = s.ReadBeFloat();
		is_bullet = s.ReadBool();
		is_static = s.ReadBool();
		is_kinematic = s.ReadBool();
		is_character = s.ReadBool();
		go_through_sand = s.ReadBool();
		gridworld_box2d = s.ReadBool();
		auto_clean = s.ReadBool();
		on_death_leave_physics_body = s.ReadBool();
		on_death_really_leave_body = s.ReadBool();
		update_entity_transform = s.ReadBool();
		force_add_update_areas = s.ReadBool();
		kills_entity = s.ReadBool();
		projectiles_rotate_toward_velocity = s.ReadBool();
		initial_velocity.Load(s);
		randomize_init_velocity = s.ReadBool();
		mActiveState = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_external);
		s.WriteBool(hax_fix_going_through_ground);
		s.WriteBool(hax_fix_going_through_sand);
		s.WriteBool(hax_wait_till_pixel_scenes_loaded);
		s.WriteBeInt32(uid);
		s.WriteBool(is_enabled);
		s.WriteBeFloat(linear_damping);
		s.WriteBeFloat(angular_damping);
		s.WriteBool(allow_sleep);
		s.WriteBool(fixed_rotation);
		s.WriteBeFloat(buoyancy);
		s.WriteBeFloat(gravity_scale_if_has_no_image_shapes);
		s.WriteBool(is_bullet);
		s.WriteBool(is_static);
		s.WriteBool(is_kinematic);
		s.WriteBool(is_character);
		s.WriteBool(go_through_sand);
		s.WriteBool(gridworld_box2d);
		s.WriteBool(auto_clean);
		s.WriteBool(on_death_leave_physics_body);
		s.WriteBool(on_death_really_leave_body);
		s.WriteBool(update_entity_transform);
		s.WriteBool(force_add_update_areas);
		s.WriteBool(kills_entity);
		s.WriteBool(projectiles_rotate_toward_velocity);
		initial_velocity.Write(s);
		s.WriteBool(randomize_init_velocity);
		s.WriteBool(mActiveState);

    }
}