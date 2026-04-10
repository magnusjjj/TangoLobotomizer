namespace GeneratedNoitaClasses;
public class TextLogComponent {
	public string key { get; set; }
	public string image_filename { get; set; }

    public void Load(NoitaStream s){
		key = s.ReadBeString();
		image_filename = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(key);
		s.WriteBeString(image_filename);

    }
}