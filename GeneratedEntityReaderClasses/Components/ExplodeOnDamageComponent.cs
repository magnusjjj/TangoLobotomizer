namespace GeneratedNoitaClasses;
public class ExplodeOnDamageComponent : NoitaComponentBase,  iNoitaType<ExplodeOnDamageComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat explode_on_death_percent { get; set; } = new();
	public NoitaFloat explode_on_damage_percent { get; set; } = new();
	public NoitaFloat physics_body_modified_death_probability { get; set; } = new();
	public NoitaFloat physics_body_destruction_required { get; set; } = new();
	public ConfigExplosion config_explosion { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		explode_on_death_percent.Read(s);
		explode_on_damage_percent.Read(s);
		physics_body_modified_death_probability.Read(s);
		physics_body_destruction_required.Read(s);
		config_explosion.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		explode_on_death_percent.Write(s);
		explode_on_damage_percent.Write(s);
		physics_body_modified_death_probability.Write(s);
		physics_body_destruction_required.Write(s);
		config_explosion.Write(s);

    }
}