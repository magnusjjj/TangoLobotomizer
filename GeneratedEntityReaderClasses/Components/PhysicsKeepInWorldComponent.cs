namespace GeneratedNoitaClasses;
public class PhysicsKeepInWorldComponent : NoitaComponentBase,  iNoitaType<PhysicsKeepInWorldComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool check_whole_aabb { get; set; } = new();
	public NoitaBool predict_aabb { get; set; } = new();
	public NoitaBool keep_at_last_valid_pos { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		check_whole_aabb.Read(s);
		predict_aabb.Read(s);
		keep_at_last_valid_pos.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		check_whole_aabb.Write(s);
		predict_aabb.Write(s);
		keep_at_last_valid_pos.Write(s);

    }
}