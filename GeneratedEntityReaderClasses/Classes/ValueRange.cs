namespace GeneratedNoitaClasses;
public class ValueRange :  iNoitaType<ValueRange>{
	public NoitaFloat min { get; set; } = new();
	public NoitaFloat max { get; set; } = new();

    public void Read(NoitaStream s){
		min.Read(s);
		max.Read(s);

    }
    public void Write(NoitaStream s){
		min.Write(s);
		max.Write(s);

    }
}