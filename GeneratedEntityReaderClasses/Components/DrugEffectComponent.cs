namespace GeneratedNoitaClasses;
public class DrugEffectComponent {
	public ConfigDrugFx drug_fx_target { get; set; }
	public ConfigDrugFx m_drug_fx_current { get; set; }

    public void Load(NoitaStream s){
		drug_fx_target.Load(s);
		m_drug_fx_current.Load(s);

    }
    public void Save(NoitaStream s){
		drug_fx_target.Write(s);
		m_drug_fx_current.Write(s);

    }
}