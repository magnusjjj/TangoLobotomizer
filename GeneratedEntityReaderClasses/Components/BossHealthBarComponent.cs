namespace GeneratedNoitaClasses;
public class BossHealthBarComponent : NoitaComponentBase,  iNoitaType<BossHealthBarComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool gui { get; set; } = new();
	public NoitaBool gui_special_final_boss { get; set; } = new();
	public NoitaBool in_world { get; set; } = new();
	public NoitaFloat gui_max_distance_visible { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		gui.Read(s);
		gui_special_final_boss.Read(s);
		in_world.Read(s);
		gui_max_distance_visible.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		gui.Write(s);
		gui_special_final_boss.Write(s);
		in_world.Write(s);
		gui_max_distance_visible.Write(s);

    }
}