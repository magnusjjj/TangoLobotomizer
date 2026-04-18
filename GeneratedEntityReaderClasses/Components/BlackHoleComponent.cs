namespace GeneratedNoitaClasses;
public class BlackHoleComponent : NoitaComponentBase,  iNoitaType<BlackHoleComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat particle_attractor_force { get; set; } = new();
	public NoitaFloat damage_probability { get; set; } = new();
	public NoitaFloat damage_amount { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		particle_attractor_force.Read(s);
		damage_probability.Read(s);
		damage_amount.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		particle_attractor_force.Write(s);
		damage_probability.Write(s);
		damage_amount.Write(s);

    }
}