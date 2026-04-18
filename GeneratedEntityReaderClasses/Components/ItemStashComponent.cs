namespace GeneratedNoitaClasses;
public class ItemStashComponent : NoitaComponentBase,  iNoitaType<ItemStashComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt throw_openable_cooldown_frames { get; set; } = new();
	public NoitaBool init_children { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		throw_openable_cooldown_frames.Read(s);
		init_children.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		throw_openable_cooldown_frames.Write(s);
		init_children.Write(s);

    }
}