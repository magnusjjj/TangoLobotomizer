namespace GeneratedNoitaClasses;
public class ConfigDrugFx {
	public float distortion_amount { get; set; }
	public float color_amount { get; set; }
	public float fractals_amount { get; set; }
	public float fractals_size { get; set; }
	public float nightvision_amount { get; set; }
	public float doublevision_amount { get; set; }

    public void Load(NoitaStream s){
		distortion_amount = s.ReadBeFloat();
		color_amount = s.ReadBeFloat();
		fractals_amount = s.ReadBeFloat();
		fractals_size = s.ReadBeFloat();
		nightvision_amount = s.ReadBeFloat();
		doublevision_amount = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(distortion_amount);
		s.WriteBeFloat(color_amount);
		s.WriteBeFloat(fractals_amount);
		s.WriteBeFloat(fractals_size);
		s.WriteBeFloat(nightvision_amount);
		s.WriteBeFloat(doublevision_amount);

    }
}