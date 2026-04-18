namespace GeneratedNoitaClasses;
public class AltarComponent : NoitaComponentBase,  iNoitaType<AltarComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString recognized_entity_tags { get; set; } = new();
	public NoitaInt good_fx_material { get; set; } = new();
	public NoitaInt neutral_fx_material { get; set; } = new();
	public NoitaInt evil_fx_material { get; set; } = new();
	public NoitaInt uses_remaining { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		recognized_entity_tags.Read(s);
		good_fx_material.Read(s);
		neutral_fx_material.Read(s);
		evil_fx_material.Read(s);
		uses_remaining.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		recognized_entity_tags.Write(s);
		good_fx_material.Write(s);
		neutral_fx_material.Write(s);
		evil_fx_material.Write(s);
		uses_remaining.Write(s);

    }
}