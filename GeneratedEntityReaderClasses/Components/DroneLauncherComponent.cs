namespace GeneratedNoitaClasses;
public class DroneLauncherComponent : NoitaComponentBase,  iNoitaType<DroneLauncherComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString drone_entity_file { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		drone_entity_file.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		drone_entity_file.Write(s);

    }
}