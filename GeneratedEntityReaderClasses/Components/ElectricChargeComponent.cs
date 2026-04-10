namespace GeneratedNoitaClasses;
public class ElectricChargeComponent {
	public Int32 charge_time_frames { get; set; }
	public float fx_velocity_max { get; set; }
	public Int32 electricity_emission_interval_frames { get; set; }
	public Int32 fx_emission_interval_min { get; set; }
	public Int32 fx_emission_interval_max { get; set; }
	public Int32 charge { get; set; }

    public void Load(NoitaStream s){
		charge_time_frames = s.ReadBeInt32();
		fx_velocity_max = s.ReadBeFloat();
		electricity_emission_interval_frames = s.ReadBeInt32();
		fx_emission_interval_min = s.ReadBeInt32();
		fx_emission_interval_max = s.ReadBeInt32();
		charge = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(charge_time_frames);
		s.WriteBeFloat(fx_velocity_max);
		s.WriteBeInt32(electricity_emission_interval_frames);
		s.WriteBeInt32(fx_emission_interval_min);
		s.WriteBeInt32(fx_emission_interval_max);
		s.WriteBeInt32(charge);

    }
}