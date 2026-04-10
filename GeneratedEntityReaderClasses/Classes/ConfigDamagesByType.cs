namespace GeneratedNoitaClasses;
public class ConfigDamagesByType {
	public float melee { get; set; }
	public float projectile { get; set; }
	public float explosion { get; set; }
	public float electricity { get; set; }
	public float fire { get; set; }
	public float drill { get; set; }
	public float slice { get; set; }
	public float ice { get; set; }
	public float healing { get; set; }
	public float physics_hit { get; set; }
	public float radioactive { get; set; }
	public float poison { get; set; }
	public float overeating { get; set; }
	public float curse { get; set; }
	public float holy { get; set; }

    public void Load(NoitaStream s){
		melee = s.ReadBeFloat();
		projectile = s.ReadBeFloat();
		explosion = s.ReadBeFloat();
		electricity = s.ReadBeFloat();
		fire = s.ReadBeFloat();
		drill = s.ReadBeFloat();
		slice = s.ReadBeFloat();
		ice = s.ReadBeFloat();
		healing = s.ReadBeFloat();
		physics_hit = s.ReadBeFloat();
		radioactive = s.ReadBeFloat();
		poison = s.ReadBeFloat();
		overeating = s.ReadBeFloat();
		curse = s.ReadBeFloat();
		holy = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(melee);
		s.WriteBeFloat(projectile);
		s.WriteBeFloat(explosion);
		s.WriteBeFloat(electricity);
		s.WriteBeFloat(fire);
		s.WriteBeFloat(drill);
		s.WriteBeFloat(slice);
		s.WriteBeFloat(ice);
		s.WriteBeFloat(healing);
		s.WriteBeFloat(physics_hit);
		s.WriteBeFloat(radioactive);
		s.WriteBeFloat(poison);
		s.WriteBeFloat(overeating);
		s.WriteBeFloat(curse);
		s.WriteBeFloat(holy);

    }
}