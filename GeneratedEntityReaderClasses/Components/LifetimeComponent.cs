namespace GeneratedNoitaClasses;
public class LifetimeComponent : NoitaComponentBase,  iNoitaType<LifetimeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt lifetime { get; set; } = new();
	public ValueRange randomize_lifetime { get; set; } = new();
	public NoitaBool fade_sprites { get; set; } = new();
	public NoitaBool kill_parent { get; set; } = new();
	public NoitaBool kill_all_parents { get; set; } = new();
	public NoitaBool serialize_duration { get; set; } = new();
	public NoitaInt kill_frame_serialized { get; set; } = new();
	public NoitaInt creation_frame_serialized { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		lifetime.Read(s);
		randomize_lifetime.Read(s);
		fade_sprites.Read(s);
		kill_parent.Read(s);
		kill_all_parents.Read(s);
		serialize_duration.Read(s);
		kill_frame_serialized.Read(s);
		creation_frame_serialized.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		lifetime.Write(s);
		randomize_lifetime.Write(s);
		fade_sprites.Write(s);
		kill_parent.Write(s);
		kill_all_parents.Write(s);
		serialize_duration.Write(s);
		kill_frame_serialized.Write(s);
		creation_frame_serialized.Write(s);

    }
}