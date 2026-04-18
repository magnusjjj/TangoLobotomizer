namespace GeneratedNoitaClasses;
public class DrugEffectComponent : NoitaComponentBase,  iNoitaType<DrugEffectComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public ConfigDrugFx drug_fx_target { get; set; } = new();
	public ConfigDrugFx m_drug_fx_current { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		drug_fx_target.Read(s);
		m_drug_fx_current.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		drug_fx_target.Write(s);
		m_drug_fx_current.Write(s);

    }
}