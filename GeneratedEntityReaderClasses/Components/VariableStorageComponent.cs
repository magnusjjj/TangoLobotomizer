namespace GeneratedNoitaClasses;
public class VariableStorageComponent : NoitaComponentBase,  iNoitaType<VariableStorageComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString name { get; set; } = new();
	public NoitaString value_string { get; set; } = new();
	public NoitaInt value_int { get; set; } = new();
	public NoitaBool value_bool { get; set; } = new();
	public NoitaFloat value_float { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		name.Read(s);
		value_string.Read(s);
		value_int.Read(s);
		value_bool.Read(s);
		value_float.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		name.Write(s);
		value_string.Write(s);
		value_int.Write(s);
		value_bool.Write(s);
		value_float.Write(s);

    }
}