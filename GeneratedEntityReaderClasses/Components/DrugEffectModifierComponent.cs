namespace GeneratedNoitaClasses;
public class DrugEffectModifierComponent {
	public ConfigDrugFx fx_add { get; set; }
	public ConfigDrugFx fx_multiply { get; set; }

    public void Load(NoitaStream s){
		fx_add.Load(s);
		fx_multiply.Load(s);

    }
    public void Save(NoitaStream s){
		fx_add.Write(s);
		fx_multiply.Write(s);

    }
}