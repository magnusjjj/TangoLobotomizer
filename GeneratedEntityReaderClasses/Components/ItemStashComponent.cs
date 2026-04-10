namespace GeneratedNoitaClasses;
public class ItemStashComponent {
	public Int32 throw_openable_cooldown_frames { get; set; }
	public bool init_children { get; set; }

    public void Load(NoitaStream s){
		throw_openable_cooldown_frames = s.ReadBeInt32();
		init_children = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(throw_openable_cooldown_frames);
		s.WriteBool(init_children);

    }
}