namespace GeneratedNoitaClasses;
public class UIInfoComponent {
	public string name { get; set; }

    public void Load(NoitaStream s){
		name = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(name);

    }
}