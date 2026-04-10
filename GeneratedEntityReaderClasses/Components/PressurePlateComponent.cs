namespace GeneratedNoitaClasses;
public class PressurePlateComponent {
	public Int32 check_every_x_frames { get; set; }
	public Int32 state { get; set; }
	public CVector2<float> aabb_min { get; set; }
	public CVector2<float> aabb_max { get; set; }
	public float material_percent { get; set; }

    public void Load(NoitaStream s){
		check_every_x_frames = s.ReadBeInt32();
		state = s.ReadBeInt32();
		aabb_min.Load(s);
		aabb_max.Load(s);
		material_percent = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(check_every_x_frames);
		s.WriteBeInt32(state);
		aabb_min.Write(s);
		aabb_max.Write(s);
		s.WriteBeFloat(material_percent);

    }
}