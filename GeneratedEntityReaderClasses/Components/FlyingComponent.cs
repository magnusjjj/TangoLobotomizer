namespace GeneratedNoitaClasses;
public class FlyingComponent {
	public Int32 type { get; set; }
	public float perlin_freq { get; set; }
	public float perlin_time_freq { get; set; }
	public float perlin_wind_x { get; set; }
	public float perlin_wind_y { get; set; }

    public void Load(NoitaStream s){
		type = s.ReadBeInt32();
		perlin_freq = s.ReadBeFloat();
		perlin_time_freq = s.ReadBeFloat();
		perlin_wind_x = s.ReadBeFloat();
		perlin_wind_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(type);
		s.WriteBeFloat(perlin_freq);
		s.WriteBeFloat(perlin_time_freq);
		s.WriteBeFloat(perlin_wind_x);
		s.WriteBeFloat(perlin_wind_y);

    }
}