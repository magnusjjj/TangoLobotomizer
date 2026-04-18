namespace GeneratedNoitaClasses;
public class AdvancedFishAIComponent : NoitaComponentBase,  iNoitaType<AdvancedFishAIComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat move_check_range_min { get; set; } = new();
	public NoitaFloat move_check_range_max { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		move_check_range_min.Read(s);
		move_check_range_max.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		move_check_range_min.Write(s);
		move_check_range_max.Write(s);

    }
}