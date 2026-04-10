namespace GeneratedNoitaClasses;
public class SpriteAnimatorComponent {
	public string target_sprite_comp_name { get; set; }
	public bool rotate_to_surface_normal { get; set; }

    public void Load(NoitaStream s){
		target_sprite_comp_name = s.ReadBeString();
		rotate_to_surface_normal = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(target_sprite_comp_name);
		s.WriteBool(rotate_to_surface_normal);

    }
}