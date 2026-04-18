namespace GeneratedNoitaClasses;
public class FlyingComponent : NoitaComponentBase,  iNoitaType<FlyingComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt type { get; set; } = new();
	public NoitaFloat perlin_freq { get; set; } = new();
	public NoitaFloat perlin_time_freq { get; set; } = new();
	public NoitaFloat perlin_wind_x { get; set; } = new();
	public NoitaFloat perlin_wind_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		type.Read(s);
		perlin_freq.Read(s);
		perlin_time_freq.Read(s);
		perlin_wind_x.Read(s);
		perlin_wind_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		type.Write(s);
		perlin_freq.Write(s);
		perlin_time_freq.Write(s);
		perlin_wind_x.Write(s);
		perlin_wind_y.Write(s);

    }
}