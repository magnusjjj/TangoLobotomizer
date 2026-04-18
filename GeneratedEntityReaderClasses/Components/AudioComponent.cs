namespace GeneratedNoitaClasses;
public class AudioComponent : NoitaComponentBase,  iNoitaType<AudioComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString file { get; set; } = new();
	public NoitaString event_root { get; set; } = new();
	public NoitaString audio_physics_material { get; set; } = new();
	public NoitaBool set_latest_event_position { get; set; } = new();
	public NoitaBool remove_latest_event_on_destroyed { get; set; } = new();
	public NoitaBool send_message_on_event_dead { get; set; } = new();
	public NoitaBool play_only_if_visible { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		file.Read(s);
		event_root.Read(s);
		audio_physics_material.Read(s);
		set_latest_event_position.Read(s);
		remove_latest_event_on_destroyed.Read(s);
		send_message_on_event_dead.Read(s);
		play_only_if_visible.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		file.Write(s);
		event_root.Write(s);
		audio_physics_material.Write(s);
		set_latest_event_position.Write(s);
		remove_latest_event_on_destroyed.Write(s);
		send_message_on_event_dead.Write(s);
		play_only_if_visible.Write(s);

    }
}