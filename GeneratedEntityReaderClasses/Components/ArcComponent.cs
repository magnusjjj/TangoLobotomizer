namespace GeneratedNoitaClasses;
public class ArcComponent {
	public UInt32 type { get; set; }
	public Int32 material { get; set; }
	public Int32 lifetime { get; set; }

    public void Load(NoitaStream s){
		type = s.ReadBeUInt32();
		material = s.ReadBeInt32();
		lifetime = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(type);
		s.WriteBeInt32(material);
		s.WriteBeInt32(lifetime);

    }
}