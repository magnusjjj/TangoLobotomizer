namespace GeneratedNoitaClasses;
public class FishAIComponent {
	public Int32 direction { get; set; }
	public float speed { get; set; }
	public CVector2<float> aabb_min { get; set; }
	public CVector2<float> aabb_max { get; set; }

    public void Load(NoitaStream s){
		direction = s.ReadBeInt32();
		speed = s.ReadBeFloat();
		aabb_min.Load(s);
		aabb_max.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(direction);
		s.WriteBeFloat(speed);
		aabb_min.Write(s);
		aabb_max.Write(s);

    }
}