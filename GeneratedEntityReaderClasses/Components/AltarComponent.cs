namespace GeneratedNoitaClasses;
public class AltarComponent {
	public string recognized_entity_tags { get; set; }
	public Int32 good_fx_material { get; set; }
	public Int32 neutral_fx_material { get; set; }
	public Int32 evil_fx_material { get; set; }
	public Int32 uses_remaining { get; set; }

    public void Load(NoitaStream s){
		recognized_entity_tags = s.ReadBeString();
		good_fx_material = s.ReadBeInt32();
		neutral_fx_material = s.ReadBeInt32();
		evil_fx_material = s.ReadBeInt32();
		uses_remaining = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(recognized_entity_tags);
		s.WriteBeInt32(good_fx_material);
		s.WriteBeInt32(neutral_fx_material);
		s.WriteBeInt32(evil_fx_material);
		s.WriteBeInt32(uses_remaining);

    }
}