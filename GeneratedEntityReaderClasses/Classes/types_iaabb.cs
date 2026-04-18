namespace GeneratedNoitaClasses;
public class types_iaabb :  iNoitaType<types_iaabb>{
	public NoitaCVector2<NoitaInt> min { get; set; } = new();
	public NoitaCVector2<NoitaInt> max { get; set; } = new();

    public void Read(NoitaStream s){
		min.Read(s);
		max.Read(s);

    }
    public void Write(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}