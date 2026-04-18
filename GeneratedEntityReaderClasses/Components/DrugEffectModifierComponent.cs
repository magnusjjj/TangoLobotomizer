namespace GeneratedNoitaClasses;
public class DrugEffectModifierComponent : NoitaComponentBase,  iNoitaType<DrugEffectModifierComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public ConfigDrugFx fx_add { get; set; } = new();
	public ConfigDrugFx fx_multiply { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		fx_add.Read(s);
		fx_multiply.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		fx_add.Write(s);
		fx_multiply.Write(s);

    }
}