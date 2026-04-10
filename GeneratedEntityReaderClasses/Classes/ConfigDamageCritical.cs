namespace GeneratedNoitaClasses;
public class ConfigDamageCritical {
	public Int32 chance { get; set; }
	public float damage_multiplier { get; set; }

    public void Load(NoitaStream s){
		chance = s.ReadBeInt32();
		damage_multiplier = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(chance);
		s.WriteBeFloat(damage_multiplier);

    }
}