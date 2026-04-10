namespace GeneratedNoitaClasses;
public class BossHealthBarComponent {
	public bool gui { get; set; }
	public bool gui_special_final_boss { get; set; }
	public bool in_world { get; set; }
	public float gui_max_distance_visible { get; set; }

    public void Load(NoitaStream s){
		gui = s.ReadBool();
		gui_special_final_boss = s.ReadBool();
		in_world = s.ReadBool();
		gui_max_distance_visible = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(gui);
		s.WriteBool(gui_special_final_boss);
		s.WriteBool(in_world);
		s.WriteBeFloat(gui_max_distance_visible);

    }
}