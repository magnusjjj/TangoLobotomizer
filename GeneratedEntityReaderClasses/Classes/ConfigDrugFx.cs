namespace GeneratedNoitaClasses;
public class ConfigDrugFx :  iNoitaType<ConfigDrugFx>{
	public NoitaFloat distortion_amount { get; set; } = new();
	public NoitaFloat color_amount { get; set; } = new();
	public NoitaFloat fractals_amount { get; set; } = new();
	public NoitaFloat fractals_size { get; set; } = new();
	public NoitaFloat nightvision_amount { get; set; } = new();
	public NoitaFloat doublevision_amount { get; set; } = new();

    public void Read(NoitaStream s){
		distortion_amount.Read(s);
		color_amount.Read(s);
		fractals_amount.Read(s);
		fractals_size.Read(s);
		nightvision_amount.Read(s);
		doublevision_amount.Read(s);

    }
    public void Write(NoitaStream s){
		distortion_amount.Write(s);
		color_amount.Write(s);
		fractals_amount.Write(s);
		fractals_size.Write(s);
		nightvision_amount.Write(s);
		doublevision_amount.Write(s);

    }
}