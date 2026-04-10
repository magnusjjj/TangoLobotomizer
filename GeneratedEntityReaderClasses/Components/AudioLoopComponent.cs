namespace GeneratedNoitaClasses;
public class AudioLoopComponent {
	public string file { get; set; }
	public string event_name { get; set; }
	public bool auto_play { get; set; }
	public bool auto_play_if_enabled { get; set; }
	public bool play_on_component_enable { get; set; }
	public bool calculate_material_lowpass { get; set; }
	public bool set_speed_parameter { get; set; }
	public bool set_speed_parameter_only_based_on_x_movement { get; set; }
	public bool set_speed_parameter_only_based_on_y_movement { get; set; }
	public float volume_autofade_speed { get; set; }

    public void Load(NoitaStream s){
		file = s.ReadBeString();
		event_name = s.ReadBeString();
		auto_play = s.ReadBool();
		auto_play_if_enabled = s.ReadBool();
		play_on_component_enable = s.ReadBool();
		calculate_material_lowpass = s.ReadBool();
		set_speed_parameter = s.ReadBool();
		set_speed_parameter_only_based_on_x_movement = s.ReadBool();
		set_speed_parameter_only_based_on_y_movement = s.ReadBool();
		volume_autofade_speed = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(file);
		s.WriteBeString(event_name);
		s.WriteBool(auto_play);
		s.WriteBool(auto_play_if_enabled);
		s.WriteBool(play_on_component_enable);
		s.WriteBool(calculate_material_lowpass);
		s.WriteBool(set_speed_parameter);
		s.WriteBool(set_speed_parameter_only_based_on_x_movement);
		s.WriteBool(set_speed_parameter_only_based_on_y_movement);
		s.WriteBeFloat(volume_autofade_speed);

    }
}