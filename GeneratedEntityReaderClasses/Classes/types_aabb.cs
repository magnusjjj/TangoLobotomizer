namespace GeneratedNoitaClasses;
public class types_aabb :  iNoitaType<types_aabb>{
	public NoitaCVector2<NoitaFloat> min { get; set; } = new();
	public NoitaCVector2<NoitaFloat> max { get; set; } = new();

    public void Read(NoitaStream s){
		min.Read(s);
		max.Read(s);

    }
    public void Write(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}