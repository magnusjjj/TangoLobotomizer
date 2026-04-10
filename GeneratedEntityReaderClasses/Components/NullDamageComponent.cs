namespace GeneratedNoitaClasses;
public class NullDamageComponent {
	public float null_chance { get; set; }

    public void Load(NoitaStream s){
		null_chance = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(null_chance);

    }
}