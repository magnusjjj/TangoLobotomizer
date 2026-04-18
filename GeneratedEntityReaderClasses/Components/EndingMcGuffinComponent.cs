namespace GeneratedNoitaClasses;
public class EndingMcGuffinComponent : NoitaComponentBase,  iNoitaType<EndingMcGuffinComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat TEMP_TEMPY { get; set; } = new();
	public NoitaFloat TEMP_TEMP_TEMP { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		TEMP_TEMPY.Read(s);
		TEMP_TEMP_TEMP.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		TEMP_TEMPY.Write(s);
		TEMP_TEMP_TEMP.Write(s);

    }
}