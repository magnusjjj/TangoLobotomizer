namespace GeneratedNoitaClasses;
public class MaterialSeaSpawnerComponent : NoitaComponentBase,  iNoitaType<MaterialSeaSpawnerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt material { get; set; } = new();
	public NoitaCVector2<NoitaInt> size { get; set; } = new();
	public NoitaCVector2<NoitaInt> offset { get; set; } = new();
	public NoitaInt speed { get; set; } = new();
	public NoitaFloat sine_wavelength { get; set; } = new();
	public NoitaFloat sine_amplitude { get; set; } = new();
	public NoitaDouble noise_scale { get; set; } = new();
	public NoitaDouble noise_threshold { get; set; } = new();
	public NoitaInt m_position { get; set; } = new();
	public NoitaInt frames_run { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		material.Read(s);
		size.Read(s);
		offset.Read(s);
		speed.Read(s);
		sine_wavelength.Read(s);
		sine_amplitude.Read(s);
		noise_scale.Read(s);
		noise_threshold.Read(s);
		m_position.Read(s);
		frames_run.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		material.Write(s);
		size.Write(s);
		offset.Write(s);
		speed.Write(s);
		sine_wavelength.Write(s);
		sine_amplitude.Write(s);
		noise_scale.Write(s);
		noise_threshold.Write(s);
		m_position.Write(s);
		frames_run.Write(s);

    }
}