namespace GeneratedNoitaClasses;
public class ItemRechargeNearGroundComponent {
	public float TEMP_TEMPY { get; set; }
	public float TEMP_TEMP_TEMP { get; set; }

    public void Load(NoitaStream s){
		TEMP_TEMPY = s.ReadBeFloat();
		TEMP_TEMP_TEMP = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(TEMP_TEMPY);
		s.WriteBeFloat(TEMP_TEMP_TEMP);

    }
}