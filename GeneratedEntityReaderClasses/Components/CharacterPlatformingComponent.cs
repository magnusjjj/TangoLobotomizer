namespace GeneratedNoitaClasses;
public class CharacterPlatformingComponent{
	public float velocity_min_x{ get; set; }
	public float velocity_max_x{ get; set; }
	public float velocity_min_y{ get; set; }
	public float velocity_max_y{ get; set; }
	public float run_velocity{ get; set; }
	public float fly_velocity_x{ get; set; }
	public float jump_velocity_x{ get; set; }
	public float jump_velocity_y{ get; set; }
	public int jump_keydown_buffer{ get; set; }
	public float fly_speed_max_up{ get; set; }
	public float fly_speed_max_down{ get; set; }
	public float fly_speed_mult{ get; set; }
	public float fly_speed_change_spd{ get; set; }
	public bool fly_model_player{ get; set; }
	public bool fly_smooth_y{ get; set; }
	public float accel_x{ get; set; }
	public float accel_x_air{ get; set; }
	public float pixel_gravity{ get; set; }
	public float swim_idle_buoyancy_coeff{ get; set; }
	public float swim_down_buoyancy_coeff{ get; set; }
	public float swim_up_buoyancy_coeff{ get; set; }
	public float swim_drag{ get; set; }
	public float swim_extra_horizontal_drag{ get; set; }
	public bool mouse_look{ get; set; }
	public float mouse_look_buffer{ get; set; }
	public bool keyboard_look{ get; set; }
	public float turning_buffer{ get; set; }
	public string animation_to_play{ get; set; }
	public string animation_to_play_next{ get; set; }
	public float run_animation_velocity_switching_threshold{ get; set; }
	public bool run_animation_velocity_switching_enabled{ get; set; }
	public int turn_animation_frames_between{ get; set; }
	public int precision_jumping_max_duration_frames{ get; set; }
	public float audio_liquid_splash_intensity{ get; set; }

}