namespace GeneratedNoitaClasses;
public class SimplePhysicsComponent {
	public bool can_go_up { get; set; }

    public void Load(NoitaStream s){
		can_go_up = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(can_go_up);

    }
}