namespace GeneratedNoitaClasses;
public class LightningComponent {
	public ConfigExplosion config_explosion { get; set; }
	public string sprite_lightning_file { get; set; }
	public bool is_projectile { get; set; }
	public Int32 explosion_type { get; set; }
	public Int32 arc_lifetime { get; set; }

    public void Load(NoitaStream s){
		config_explosion.Load(s);
		sprite_lightning_file = s.ReadBeString();
		is_projectile = s.ReadBool();
		explosion_type = s.ReadBeInt32();
		arc_lifetime = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		config_explosion.Write(s);
		s.WriteBeString(sprite_lightning_file);
		s.WriteBool(is_projectile);
		s.WriteBeInt32(explosion_type);
		s.WriteBeInt32(arc_lifetime);

    }
}