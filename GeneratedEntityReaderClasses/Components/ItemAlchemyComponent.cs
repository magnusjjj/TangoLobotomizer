namespace GeneratedNoitaClasses;
public class ItemAlchemyComponent {
	public Int32 material_make_always_cast { get; set; }
	public Int32 material_remove_shuffle { get; set; }
	public Int32 material_animate_wand { get; set; }
	public Int32 material_animate_wand_alt { get; set; }
	public Int32 material_increase_uses_remaining { get; set; }
	public Int32 material_sacrifice { get; set; }

    public void Load(NoitaStream s){
		material_make_always_cast = s.ReadBeInt32();
		material_remove_shuffle = s.ReadBeInt32();
		material_animate_wand = s.ReadBeInt32();
		material_animate_wand_alt = s.ReadBeInt32();
		material_increase_uses_remaining = s.ReadBeInt32();
		material_sacrifice = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(material_make_always_cast);
		s.WriteBeInt32(material_remove_shuffle);
		s.WriteBeInt32(material_animate_wand);
		s.WriteBeInt32(material_animate_wand_alt);
		s.WriteBeInt32(material_increase_uses_remaining);
		s.WriteBeInt32(material_sacrifice);

    }
}