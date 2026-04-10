namespace GeneratedNoitaClasses;
public class MaterialSeaSpawnerComponent {
	public Int32 material { get; set; }
	public CVector2<int> size { get; set; }
	public CVector2<int> offset { get; set; }
	public Int32 speed { get; set; }
	public float sine_wavelength { get; set; }
	public float sine_amplitude { get; set; }
	public double noise_scale { get; set; }
	public double noise_threshold { get; set; }
	public Int32 m_position { get; set; }
	public Int32 frames_run { get; set; }

    public void Load(NoitaStream s){
		material = s.ReadBeInt32();
		size.Load(s);
		offset.Load(s);
		speed = s.ReadBeInt32();
		sine_wavelength = s.ReadBeFloat();
		sine_amplitude = s.ReadBeFloat();
		noise_scale = s.ReadBeDouble();
		noise_threshold = s.ReadBeDouble();
		m_position = s.ReadBeInt32();
		frames_run = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(material);
		size.Write(s);
		offset.Write(s);
		s.WriteBeInt32(speed);
		s.WriteBeFloat(sine_wavelength);
		s.WriteBeFloat(sine_amplitude);
		s.WriteBeDouble(noise_scale);
		s.WriteBeDouble(noise_threshold);
		s.WriteBeInt32(m_position);
		s.WriteBeInt32(frames_run);

    }
}