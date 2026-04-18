namespace GeneratedNoitaClasses;
public class SpriteAnimatorComponent : NoitaComponentBase,  iNoitaType<SpriteAnimatorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString target_sprite_comp_name { get; set; } = new();
	public NoitaBool rotate_to_surface_normal { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		target_sprite_comp_name.Read(s);
		rotate_to_surface_normal.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		target_sprite_comp_name.Write(s);
		rotate_to_surface_normal.Write(s);

    }
}