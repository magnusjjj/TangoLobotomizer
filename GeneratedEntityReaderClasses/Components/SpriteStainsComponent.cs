namespace GeneratedNoitaClasses;
public class SpriteStainsComponent {
	public Int32 sprite_id { get; set; }
	public bool fade_stains_towards_srite_top { get; set; }
	public LensValue<int> stain_shaken_drop_chance_multiplier { get; set; }
	

    public void Load(NoitaStream s){
		sprite_id = s.ReadBeInt32();
		fade_stains_towards_srite_top = s.ReadBool();
		stain_shaken_drop_chance_multiplier.Load(s);
		

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(sprite_id);
		s.WriteBool(fade_stains_towards_srite_top);
		stain_shaken_drop_chance_multiplier.Write(s);
		

    }
}