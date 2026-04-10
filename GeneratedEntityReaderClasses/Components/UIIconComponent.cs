namespace GeneratedNoitaClasses;
public class UIIconComponent {
	public string icon_sprite_file { get; set; }
	public string name { get; set; }
	public string description { get; set; }
	public bool display_above_head { get; set; }
	public bool display_in_hud { get; set; }
	public bool is_perk { get; set; }

    public void Load(NoitaStream s){
		icon_sprite_file = s.ReadBeString();
		name = s.ReadBeString();
		description = s.ReadBeString();
		display_above_head = s.ReadBool();
		display_in_hud = s.ReadBool();
		is_perk = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(icon_sprite_file);
		s.WriteBeString(name);
		s.WriteBeString(description);
		s.WriteBool(display_above_head);
		s.WriteBool(display_in_hud);
		s.WriteBool(is_perk);

    }
}