namespace GeneratedNoitaClasses;
public class VerletWeaponComponent {
	public float damage_radius { get; set; }
	public float physics_force_radius { get; set; }
	public float damage_min_step { get; set; }
	public float damage_max { get; set; }
	public float damage_coeff { get; set; }
	public float impulse_coeff { get; set; }
	public Int32 fade_duration_frames { get; set; }
	public float physics_impulse_coeff { get; set; }

    public void Load(NoitaStream s){
		damage_radius = s.ReadBeFloat();
		physics_force_radius = s.ReadBeFloat();
		damage_min_step = s.ReadBeFloat();
		damage_max = s.ReadBeFloat();
		damage_coeff = s.ReadBeFloat();
		impulse_coeff = s.ReadBeFloat();
		fade_duration_frames = s.ReadBeInt32();
		physics_impulse_coeff = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(damage_radius);
		s.WriteBeFloat(physics_force_radius);
		s.WriteBeFloat(damage_min_step);
		s.WriteBeFloat(damage_max);
		s.WriteBeFloat(damage_coeff);
		s.WriteBeFloat(impulse_coeff);
		s.WriteBeInt32(fade_duration_frames);
		s.WriteBeFloat(physics_impulse_coeff);

    }
}