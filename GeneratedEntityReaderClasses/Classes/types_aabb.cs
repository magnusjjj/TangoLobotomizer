namespace GeneratedNoitaClasses;
public class types_aabb {
	public CVector2<float> min { get; set; }
	public CVector2<float> max { get; set; }

    public void Load(NoitaStream s){
		min.Load(s);
		max.Load(s);

    }
    public void Save(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}