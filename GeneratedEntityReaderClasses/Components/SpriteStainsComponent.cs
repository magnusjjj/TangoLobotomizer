namespace GeneratedNoitaClasses;
public class SpriteStainsComponent : NoitaComponentBase,  iNoitaType<SpriteStainsComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt sprite_id { get; set; } = new();
	public NoitaBool fade_stains_towards_srite_top { get; set; } = new();
	public NoitaLensValue<NoitaInt> stain_shaken_drop_chance_multiplier { get; set; } = new();
	

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		sprite_id.Read(s);
		fade_stains_towards_srite_top.Read(s);
		stain_shaken_drop_chance_multiplier.Read(s);
		

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		sprite_id.Write(s);
		fade_stains_towards_srite_top.Write(s);
		stain_shaken_drop_chance_multiplier.Write(s);
		

    }
}