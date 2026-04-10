namespace GeneratedNoitaClasses;
public class DroneLauncherComponent {
	public string drone_entity_file { get; set; }

    public void Load(NoitaStream s){
		drone_entity_file = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(drone_entity_file);

    }
}