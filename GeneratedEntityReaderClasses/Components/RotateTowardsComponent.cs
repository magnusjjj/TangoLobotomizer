namespace GeneratedNoitaClasses;
public class RotateTowardsComponent {
	public string entity_with_tag { get; set; }

    public void Load(NoitaStream s){
		entity_with_tag = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(entity_with_tag);

    }
}