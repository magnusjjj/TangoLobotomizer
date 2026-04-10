namespace GeneratedNoitaClasses;
public class GodInfoComponent {
	public float mana_current { get; set; }
	public float mana_max { get; set; }
	public float gold { get; set; }

    public void Load(NoitaStream s){
		mana_current = s.ReadBeFloat();
		mana_max = s.ReadBeFloat();
		gold = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(mana_current);
		s.WriteBeFloat(mana_max);
		s.WriteBeFloat(gold);

    }
}