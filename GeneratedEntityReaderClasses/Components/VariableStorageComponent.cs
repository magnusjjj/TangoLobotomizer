namespace GeneratedNoitaClasses;
public class VariableStorageComponent {
	public string name { get; set; }
	public string value_string { get; set; }
	public Int32 value_int { get; set; }
	public bool value_bool { get; set; }
	public float value_float { get; set; }

    public void Load(NoitaStream s){
		name = s.ReadBeString();
		value_string = s.ReadBeString();
		value_int = s.ReadBeInt32();
		value_bool = s.ReadBool();
		value_float = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(name);
		s.WriteBeString(value_string);
		s.WriteBeInt32(value_int);
		s.WriteBool(value_bool);
		s.WriteBeFloat(value_float);

    }
}