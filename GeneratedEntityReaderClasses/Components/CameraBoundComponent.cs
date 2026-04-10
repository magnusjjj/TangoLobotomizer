namespace GeneratedNoitaClasses;
public class CameraBoundComponent {
	public bool enabled { get; set; }
	public float distance { get; set; }
	public float distance_border { get; set; }
	public Int32 max_count { get; set; }
	public bool freeze_on_distance_kill { get; set; }
	public bool freeze_on_max_count_kill { get; set; }

    public void Load(NoitaStream s){
		enabled = s.ReadBool();
		distance = s.ReadBeFloat();
		distance_border = s.ReadBeFloat();
		max_count = s.ReadBeInt32();
		freeze_on_distance_kill = s.ReadBool();
		freeze_on_max_count_kill = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(enabled);
		s.WriteBeFloat(distance);
		s.WriteBeFloat(distance_border);
		s.WriteBeInt32(max_count);
		s.WriteBool(freeze_on_distance_kill);
		s.WriteBool(freeze_on_max_count_kill);

    }
}