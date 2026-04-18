namespace GeneratedNoitaClasses;
public class VerletWeaponComponent : NoitaComponentBase,  iNoitaType<VerletWeaponComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat damage_radius { get; set; } = new();
	public NoitaFloat physics_force_radius { get; set; } = new();
	public NoitaFloat damage_min_step { get; set; } = new();
	public NoitaFloat damage_max { get; set; } = new();
	public NoitaFloat damage_coeff { get; set; } = new();
	public NoitaFloat impulse_coeff { get; set; } = new();
	public NoitaInt fade_duration_frames { get; set; } = new();
	public NoitaFloat physics_impulse_coeff { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		damage_radius.Read(s);
		physics_force_radius.Read(s);
		damage_min_step.Read(s);
		damage_max.Read(s);
		damage_coeff.Read(s);
		impulse_coeff.Read(s);
		fade_duration_frames.Read(s);
		physics_impulse_coeff.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		damage_radius.Write(s);
		physics_force_radius.Write(s);
		damage_min_step.Write(s);
		damage_max.Write(s);
		damage_coeff.Write(s);
		impulse_coeff.Write(s);
		fade_duration_frames.Write(s);
		physics_impulse_coeff.Write(s);

    }
}