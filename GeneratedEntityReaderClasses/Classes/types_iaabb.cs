namespace GeneratedNoitaClasses;
public class types_iaabb {
	public CVector2<int> min { get; set; }
	public CVector2<int> max { get; set; }

    public void Load(NoitaStream s){
		min.Load(s);
		max.Load(s);

    }
    public void Save(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}