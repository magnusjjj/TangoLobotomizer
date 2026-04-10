namespace GeneratedNoitaClasses;
public class ItemActionComponent {
	public string action_id { get; set; }

    public void Load(NoitaStream s){
		action_id = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(action_id);

    }
}