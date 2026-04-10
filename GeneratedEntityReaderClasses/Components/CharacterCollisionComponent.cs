namespace GeneratedNoitaClasses;
public class CharacterCollisionComponent {
	public Int32 getting_crushed_threshold { get; set; }
	public Int32 moving_up_before_getting_crushed_threshold { get; set; }

    public void Load(NoitaStream s){
		getting_crushed_threshold = s.ReadBeInt32();
		moving_up_before_getting_crushed_threshold = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(getting_crushed_threshold);
		s.WriteBeInt32(moving_up_before_getting_crushed_threshold);

    }
}