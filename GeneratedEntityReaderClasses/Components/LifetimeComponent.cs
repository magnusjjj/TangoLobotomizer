namespace GeneratedNoitaClasses;
public class LifetimeComponent {
	public Int32 lifetime { get; set; }
	public ValueRange randomize_lifetime { get; set; }
	public bool fade_sprites { get; set; }
	public bool kill_parent { get; set; }
	public bool kill_all_parents { get; set; }
	public bool serialize_duration { get; set; }
	public Int32 kill_frame_serialized { get; set; }
	public Int32 creation_frame_serialized { get; set; }

    public void Load(NoitaStream s){
		lifetime = s.ReadBeInt32();
		randomize_lifetime.Load(s);
		fade_sprites = s.ReadBool();
		kill_parent = s.ReadBool();
		kill_all_parents = s.ReadBool();
		serialize_duration = s.ReadBool();
		kill_frame_serialized = s.ReadBeInt32();
		creation_frame_serialized = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(lifetime);
		randomize_lifetime.Write(s);
		s.WriteBool(fade_sprites);
		s.WriteBool(kill_parent);
		s.WriteBool(kill_all_parents);
		s.WriteBool(serialize_duration);
		s.WriteBeInt32(kill_frame_serialized);
		s.WriteBeInt32(creation_frame_serialized);

    }
}