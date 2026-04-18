namespace GeneratedNoitaClasses;
public class ValueRangeInt :  iNoitaType<ValueRangeInt>{
	public NoitaInt min { get; set; } = new();
	public NoitaInt max { get; set; } = new();

    public void Read(NoitaStream s){
		min.Read(s);
		max.Read(s);

    }
    public void Write(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}