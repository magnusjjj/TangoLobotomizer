namespace GeneratedNoitaClasses;
public class ValueRangeInt {
	public Int32 min { get; set; }
	public Int32 max { get; set; }

    public void Load(NoitaStream s){
		min = s.ReadBeInt32();
		max = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(min);
		s.WriteBeInt32(max);

    }
}