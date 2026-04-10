namespace GeneratedNoitaClasses;
public class BlackHoleComponent {
	public float radius { get; set; }
	public float particle_attractor_force { get; set; }
	public float damage_probability { get; set; }
	public float damage_amount { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		particle_attractor_force = s.ReadBeFloat();
		damage_probability = s.ReadBeFloat();
		damage_amount = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeFloat(particle_attractor_force);
		s.WriteBeFloat(damage_probability);
		s.WriteBeFloat(damage_amount);

    }
}