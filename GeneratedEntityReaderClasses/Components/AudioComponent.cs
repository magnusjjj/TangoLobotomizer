namespace GeneratedNoitaClasses;
public class AudioComponent {
	public string file { get; set; }
	public string event_root { get; set; }
	public string audio_physics_material { get; set; }
	public bool set_latest_event_position { get; set; }
	public bool remove_latest_event_on_destroyed { get; set; }
	public bool send_message_on_event_dead { get; set; }
	public bool play_only_if_visible { get; set; }

    public void Load(NoitaStream s){
		file = s.ReadBeString();
		event_root = s.ReadBeString();
		audio_physics_material = s.ReadBeString();
		set_latest_event_position = s.ReadBool();
		remove_latest_event_on_destroyed = s.ReadBool();
		send_message_on_event_dead = s.ReadBool();
		play_only_if_visible = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(file);
		s.WriteBeString(event_root);
		s.WriteBeString(audio_physics_material);
		s.WriteBool(set_latest_event_position);
		s.WriteBool(remove_latest_event_on_destroyed);
		s.WriteBool(send_message_on_event_dead);
		s.WriteBool(play_only_if_visible);

    }
}