namespace GeneratedNoitaClasses;
public class ConfigDamageCritical :  iNoitaType<ConfigDamageCritical>{
	public NoitaInt chance { get; set; } = new();
	public NoitaFloat damage_multiplier { get; set; } = new();

    public void Read(NoitaStream s){
		chance.Read(s);
		damage_multiplier.Read(s);

    }
    public void Write(NoitaStream s){
		chance.Write(s);
		damage_multiplier.Write(s);

    }
}