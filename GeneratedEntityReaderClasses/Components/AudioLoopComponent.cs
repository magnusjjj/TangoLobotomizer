namespace GeneratedNoitaClasses;
public class AudioLoopComponent : NoitaComponentBase,  iNoitaType<AudioLoopComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString file { get; set; } = new();
	public NoitaString event_name { get; set; } = new();
	public NoitaBool auto_play { get; set; } = new();
	public NoitaBool auto_play_if_enabled { get; set; } = new();
	public NoitaBool play_on_component_enable { get; set; } = new();
	public NoitaBool calculate_material_lowpass { get; set; } = new();
	public NoitaBool set_speed_parameter { get; set; } = new();
	public NoitaBool set_speed_parameter_only_based_on_x_movement { get; set; } = new();
	public NoitaBool set_speed_parameter_only_based_on_y_movement { get; set; } = new();
	public NoitaFloat volume_autofade_speed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		file.Read(s);
		event_name.Read(s);
		auto_play.Read(s);
		auto_play_if_enabled.Read(s);
		play_on_component_enable.Read(s);
		calculate_material_lowpass.Read(s);
		set_speed_parameter.Read(s);
		set_speed_parameter_only_based_on_x_movement.Read(s);
		set_speed_parameter_only_based_on_y_movement.Read(s);
		volume_autofade_speed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		file.Write(s);
		event_name.Write(s);
		auto_play.Write(s);
		auto_play_if_enabled.Write(s);
		play_on_component_enable.Write(s);
		calculate_material_lowpass.Write(s);
		set_speed_parameter.Write(s);
		set_speed_parameter_only_based_on_x_movement.Write(s);
		set_speed_parameter_only_based_on_y_movement.Write(s);
		volume_autofade_speed.Write(s);

    }
}