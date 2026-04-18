namespace GeneratedNoitaClasses;
public class ElectricChargeComponent : NoitaComponentBase,  iNoitaType<ElectricChargeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt charge_time_frames { get; set; } = new();
	public NoitaFloat fx_velocity_max { get; set; } = new();
	public NoitaInt electricity_emission_interval_frames { get; set; } = new();
	public NoitaInt fx_emission_interval_min { get; set; } = new();
	public NoitaInt fx_emission_interval_max { get; set; } = new();
	public NoitaInt charge { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		charge_time_frames.Read(s);
		fx_velocity_max.Read(s);
		electricity_emission_interval_frames.Read(s);
		fx_emission_interval_min.Read(s);
		fx_emission_interval_max.Read(s);
		charge.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		charge_time_frames.Write(s);
		fx_velocity_max.Write(s);
		electricity_emission_interval_frames.Write(s);
		fx_emission_interval_min.Write(s);
		fx_emission_interval_max.Write(s);
		charge.Write(s);

    }
}