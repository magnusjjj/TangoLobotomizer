namespace GeneratedNoitaClasses;
public class RotateTowardsComponent : NoitaComponentBase,  iNoitaType<RotateTowardsComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString entity_with_tag { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		entity_with_tag.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		entity_with_tag.Write(s);

    }
}