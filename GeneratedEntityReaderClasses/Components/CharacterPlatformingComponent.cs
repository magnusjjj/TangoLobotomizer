namespace GeneratedNoitaClasses;
public class CharacterPlatformingComponent {
	public LensValue<float> velocity_min_x { get; set; }
	public LensValue<float> velocity_max_x { get; set; }
	public LensValue<float> velocity_min_y { get; set; }
	public LensValue<float> velocity_max_y { get; set; }
	public LensValue<float> run_velocity { get; set; }
	public LensValue<float> fly_velocity_x { get; set; }
	public float jump_velocity_x { get; set; }
	public float jump_velocity_y { get; set; }
	public Int32 jump_keydown_buffer { get; set; }
	public LensValue<float> fly_speed_max_up { get; set; }
	public LensValue<float> fly_speed_max_down { get; set; }
	public float fly_speed_mult { get; set; }
	public float fly_speed_change_spd { get; set; }
	public bool fly_model_player { get; set; }
	public bool fly_smooth_y { get; set; }
	public float accel_x { get; set; }
	public float accel_x_air { get; set; }
	public float pixel_gravity { get; set; }
	public float swim_idle_buoyancy_coeff { get; set; }
	public float swim_down_buoyancy_coeff { get; set; }
	public float swim_up_buoyancy_coeff { get; set; }
	public float swim_drag { get; set; }
	public float swim_extra_horizontal_drag { get; set; }
	public bool mouse_look { get; set; }
	public float mouse_look_buffer { get; set; }
	public bool keyboard_look { get; set; }
	public float turning_buffer { get; set; }
	public string animation_to_play { get; set; }
	public string animation_to_play_next { get; set; }
	public float run_animation_velocity_switching_threshold { get; set; }
	public bool run_animation_velocity_switching_enabled { get; set; }
	public Int32 turn_animation_frames_between { get; set; }
	public Int32 precision_jumping_max_duration_frames { get; set; }
	public float audio_liquid_splash_intensity { get; set; }

    public void Load(NoitaStream s){
		velocity_min_x.Load(s);
		velocity_max_x.Load(s);
		velocity_min_y.Load(s);
		velocity_max_y.Load(s);
		run_velocity.Load(s);
		fly_velocity_x.Load(s);
		jump_velocity_x = s.ReadBeFloat();
		jump_velocity_y = s.ReadBeFloat();
		jump_keydown_buffer = s.ReadBeInt32();
		fly_speed_max_up.Load(s);
		fly_speed_max_down.Load(s);
		fly_speed_mult = s.ReadBeFloat();
		fly_speed_change_spd = s.ReadBeFloat();
		fly_model_player = s.ReadBool();
		fly_smooth_y = s.ReadBool();
		accel_x = s.ReadBeFloat();
		accel_x_air = s.ReadBeFloat();
		pixel_gravity = s.ReadBeFloat();
		swim_idle_buoyancy_coeff = s.ReadBeFloat();
		swim_down_buoyancy_coeff = s.ReadBeFloat();
		swim_up_buoyancy_coeff = s.ReadBeFloat();
		swim_drag = s.ReadBeFloat();
		swim_extra_horizontal_drag = s.ReadBeFloat();
		mouse_look = s.ReadBool();
		mouse_look_buffer = s.ReadBeFloat();
		keyboard_look = s.ReadBool();
		turning_buffer = s.ReadBeFloat();
		animation_to_play = s.ReadBeString();
		animation_to_play_next = s.ReadBeString();
		run_animation_velocity_switching_threshold = s.ReadBeFloat();
		run_animation_velocity_switching_enabled = s.ReadBool();
		turn_animation_frames_between = s.ReadBeInt32();
		precision_jumping_max_duration_frames = s.ReadBeInt32();
		audio_liquid_splash_intensity = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		velocity_min_x.Write(s);
		velocity_max_x.Write(s);
		velocity_min_y.Write(s);
		velocity_max_y.Write(s);
		run_velocity.Write(s);
		fly_velocity_x.Write(s);
		s.WriteBeFloat(jump_velocity_x);
		s.WriteBeFloat(jump_velocity_y);
		s.WriteBeInt32(jump_keydown_buffer);
		fly_speed_max_up.Write(s);
		fly_speed_max_down.Write(s);
		s.WriteBeFloat(fly_speed_mult);
		s.WriteBeFloat(fly_speed_change_spd);
		s.WriteBool(fly_model_player);
		s.WriteBool(fly_smooth_y);
		s.WriteBeFloat(accel_x);
		s.WriteBeFloat(accel_x_air);
		s.WriteBeFloat(pixel_gravity);
		s.WriteBeFloat(swim_idle_buoyancy_coeff);
		s.WriteBeFloat(swim_down_buoyancy_coeff);
		s.WriteBeFloat(swim_up_buoyancy_coeff);
		s.WriteBeFloat(swim_drag);
		s.WriteBeFloat(swim_extra_horizontal_drag);
		s.WriteBool(mouse_look);
		s.WriteBeFloat(mouse_look_buffer);
		s.WriteBool(keyboard_look);
		s.WriteBeFloat(turning_buffer);
		s.WriteBeString(animation_to_play);
		s.WriteBeString(animation_to_play_next);
		s.WriteBeFloat(run_animation_velocity_switching_threshold);
		s.WriteBool(run_animation_velocity_switching_enabled);
		s.WriteBeInt32(turn_animation_frames_between);
		s.WriteBeInt32(precision_jumping_max_duration_frames);
		s.WriteBeFloat(audio_liquid_splash_intensity);

    }
}