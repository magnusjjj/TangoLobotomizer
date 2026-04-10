namespace GeneratedNoitaClasses;
public class AIComponent {
	public float TEMP_TEMP_TEMP { get; set; }

    public void Load(NoitaStream s){
		TEMP_TEMP_TEMP = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(TEMP_TEMP_TEMP);

    }
}