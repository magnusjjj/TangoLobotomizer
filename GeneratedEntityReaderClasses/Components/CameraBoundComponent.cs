namespace GeneratedNoitaClasses;
public class CameraBoundComponent : NoitaComponentBase,  iNoitaType<CameraBoundComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool enabled { get; set; } = new();
	public NoitaFloat distance { get; set; } = new();
	public NoitaFloat distance_border { get; set; } = new();
	public NoitaInt max_count { get; set; } = new();
	public NoitaBool freeze_on_distance_kill { get; set; } = new();
	public NoitaBool freeze_on_max_count_kill { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		enabled.Read(s);
		distance.Read(s);
		distance_border.Read(s);
		max_count.Read(s);
		freeze_on_distance_kill.Read(s);
		freeze_on_max_count_kill.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		enabled.Write(s);
		distance.Write(s);
		distance_border.Write(s);
		max_count.Write(s);
		freeze_on_distance_kill.Write(s);
		freeze_on_max_count_kill.Write(s);

    }
}