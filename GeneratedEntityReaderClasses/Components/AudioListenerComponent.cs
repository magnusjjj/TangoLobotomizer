namespace GeneratedNoitaClasses;
public class AudioListenerComponent {
	public float z { get; set; }

    public void Load(NoitaStream s){
		z = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(z);

    }
}