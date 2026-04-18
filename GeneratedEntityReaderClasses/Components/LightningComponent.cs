namespace GeneratedNoitaClasses;
public class LightningComponent : NoitaComponentBase,  iNoitaType<LightningComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public ConfigExplosion config_explosion { get; set; } = new();
	public NoitaString sprite_lightning_file { get; set; } = new();
	public NoitaBool is_projectile { get; set; } = new();
	public NoitaInt explosion_type { get; set; } = new();
	public NoitaInt arc_lifetime { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		config_explosion.Read(s);
		sprite_lightning_file.Read(s);
		is_projectile.Read(s);
		explosion_type.Read(s);
		arc_lifetime.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		config_explosion.Write(s);
		sprite_lightning_file.Write(s);
		is_projectile.Write(s);
		explosion_type.Write(s);
		arc_lifetime.Write(s);

    }
}