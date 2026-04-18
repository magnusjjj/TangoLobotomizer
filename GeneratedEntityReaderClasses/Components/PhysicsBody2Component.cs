namespace GeneratedNoitaClasses;
public class PhysicsBody2Component : NoitaComponentBase,  iNoitaType<PhysicsBody2Component>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt64 mBodyId { get; set; } = new();
	public NoitaFloat linear_damping { get; set; } = new();
	public NoitaFloat angular_damping { get; set; } = new();
	public NoitaBool allow_sleep { get; set; } = new();
	public NoitaBool fixed_rotation { get; set; } = new();
	public NoitaBool is_bullet { get; set; } = new();
	public NoitaBool is_static { get; set; } = new();
	public NoitaFloat buoyancy { get; set; } = new();
	public NoitaBool hax_fix_going_through_ground { get; set; } = new();
	public NoitaBool hax_fix_going_through_sand { get; set; } = new();
	public NoitaBool hax_wait_till_pixel_scenes_loaded { get; set; } = new();
	public NoitaBool go_through_sand { get; set; } = new();
	public NoitaBool auto_clean { get; set; } = new();
	public NoitaBool force_add_update_areas { get; set; } = new();
	public NoitaBool update_entity_transform { get; set; } = new();
	public NoitaBool kill_entity_if_body_destroyed { get; set; } = new();
	public NoitaBool kill_entity_after_initialized { get; set; } = new();
	public NoitaBool manual_init { get; set; } = new();
	public NoitaBool destroy_body_if_entity_destroyed { get; set; } = new();
	public NoitaFloat root_offset_x { get; set; } = new();
	public NoitaFloat root_offset_y { get; set; } = new();
	public NoitaFloat init_offset_x { get; set; } = new();
	public NoitaFloat init_offset_y { get; set; } = new();
	public NoitaBool mActiveState { get; set; } = new();
	public NoitaCVector2<NoitaFloat> mLocalPosition { get; set; } = new();
	public NoitaUInt mPixelCountOrig { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		mBodyId.Read(s);
		linear_damping.Read(s);
		angular_damping.Read(s);
		allow_sleep.Read(s);
		fixed_rotation.Read(s);
		is_bullet.Read(s);
		is_static.Read(s);
		buoyancy.Read(s);
		hax_fix_going_through_ground.Read(s);
		hax_fix_going_through_sand.Read(s);
		hax_wait_till_pixel_scenes_loaded.Read(s);
		go_through_sand.Read(s);
		auto_clean.Read(s);
		force_add_update_areas.Read(s);
		update_entity_transform.Read(s);
		kill_entity_if_body_destroyed.Read(s);
		kill_entity_after_initialized.Read(s);
		manual_init.Read(s);
		destroy_body_if_entity_destroyed.Read(s);
		root_offset_x.Read(s);
		root_offset_y.Read(s);
		init_offset_x.Read(s);
		init_offset_y.Read(s);
		mActiveState.Read(s);
		mLocalPosition.Read(s);
		mPixelCountOrig.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		mBodyId.Write(s);
		linear_damping.Write(s);
		angular_damping.Write(s);
		allow_sleep.Write(s);
		fixed_rotation.Write(s);
		is_bullet.Write(s);
		is_static.Write(s);
		buoyancy.Write(s);
		hax_fix_going_through_ground.Write(s);
		hax_fix_going_through_sand.Write(s);
		hax_wait_till_pixel_scenes_loaded.Write(s);
		go_through_sand.Write(s);
		auto_clean.Write(s);
		force_add_update_areas.Write(s);
		update_entity_transform.Write(s);
		kill_entity_if_body_destroyed.Write(s);
		kill_entity_after_initialized.Write(s);
		manual_init.Write(s);
		destroy_body_if_entity_destroyed.Write(s);
		root_offset_x.Write(s);
		root_offset_y.Write(s);
		init_offset_x.Write(s);
		init_offset_y.Write(s);
		mActiveState.Write(s);
		mLocalPosition.Write(s);
		mPixelCountOrig.Write(s);

    }
}