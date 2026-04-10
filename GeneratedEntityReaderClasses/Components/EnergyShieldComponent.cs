namespace GeneratedNoitaClasses;
public class EnergyShieldComponent {
	public float radius { get; set; }
	public float damage_multiplier { get; set; }
	public float max_energy { get; set; }
	public float energy_required_to_shield { get; set; }
	public float recharge_speed { get; set; }
	public float sector_degrees { get; set; }
	public float energy { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		damage_multiplier = s.ReadBeFloat();
		max_energy = s.ReadBeFloat();
		energy_required_to_shield = s.ReadBeFloat();
		recharge_speed = s.ReadBeFloat();
		sector_degrees = s.ReadBeFloat();
		energy = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeFloat(damage_multiplier);
		s.WriteBeFloat(max_energy);
		s.WriteBeFloat(energy_required_to_shield);
		s.WriteBeFloat(recharge_speed);
		s.WriteBeFloat(sector_degrees);
		s.WriteBeFloat(energy);

    }
}