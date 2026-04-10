namespace GeneratedNoitaClasses;
public class ExplodeOnDamageComponent {
	public float explode_on_death_percent { get; set; }
	public float explode_on_damage_percent { get; set; }
	public float physics_body_modified_death_probability { get; set; }
	public float physics_body_destruction_required { get; set; }
	public ConfigExplosion config_explosion { get; set; }

    public void Load(NoitaStream s){
		explode_on_death_percent = s.ReadBeFloat();
		explode_on_damage_percent = s.ReadBeFloat();
		physics_body_modified_death_probability = s.ReadBeFloat();
		physics_body_destruction_required = s.ReadBeFloat();
		config_explosion.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(explode_on_death_percent);
		s.WriteBeFloat(explode_on_damage_percent);
		s.WriteBeFloat(physics_body_modified_death_probability);
		s.WriteBeFloat(physics_body_destruction_required);
		config_explosion.Write(s);

    }
}