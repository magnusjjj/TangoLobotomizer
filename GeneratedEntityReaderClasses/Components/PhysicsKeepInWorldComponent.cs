namespace GeneratedNoitaClasses;
public class PhysicsKeepInWorldComponent {
	public bool check_whole_aabb { get; set; }
	public bool predict_aabb { get; set; }
	public bool keep_at_last_valid_pos { get; set; }

    public void Load(NoitaStream s){
		check_whole_aabb = s.ReadBool();
		predict_aabb = s.ReadBool();
		keep_at_last_valid_pos = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(check_whole_aabb);
		s.WriteBool(predict_aabb);
		s.WriteBool(keep_at_last_valid_pos);

    }
}