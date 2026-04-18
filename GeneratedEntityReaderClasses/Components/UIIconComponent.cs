namespace GeneratedNoitaClasses;
public class UIIconComponent : NoitaComponentBase,  iNoitaType<UIIconComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString icon_sprite_file { get; set; } = new();
	public NoitaString name { get; set; } = new();
	public NoitaString description { get; set; } = new();
	public NoitaBool display_above_head { get; set; } = new();
	public NoitaBool display_in_hud { get; set; } = new();
	public NoitaBool is_perk { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		icon_sprite_file.Read(s);
		name.Read(s);
		description.Read(s);
		display_above_head.Read(s);
		display_in_hud.Read(s);
		is_perk.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		icon_sprite_file.Write(s);
		name.Write(s);
		description.Write(s);
		display_above_head.Write(s);
		display_in_hud.Write(s);
		is_perk.Write(s);

    }
}