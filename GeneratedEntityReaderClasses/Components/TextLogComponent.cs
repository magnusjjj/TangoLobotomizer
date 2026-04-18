namespace GeneratedNoitaClasses;
public class TextLogComponent : NoitaComponentBase,  iNoitaType<TextLogComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString key { get; set; } = new();
	public NoitaString image_filename { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		key.Read(s);
		image_filename.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		key.Write(s);
		image_filename.Write(s);

    }
}