namespace GeneratedNoitaClasses;
public class CharacterCollisionComponent : NoitaComponentBase,  iNoitaType<CharacterCollisionComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt getting_crushed_threshold { get; set; } = new();
	public NoitaInt moving_up_before_getting_crushed_threshold { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		getting_crushed_threshold.Read(s);
		moving_up_before_getting_crushed_threshold.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		getting_crushed_threshold.Write(s);
		moving_up_before_getting_crushed_threshold.Write(s);

    }
}