namespace GeneratedNoitaClasses;
public class EnergyShieldComponent : NoitaComponentBase,  iNoitaType<EnergyShieldComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat damage_multiplier { get; set; } = new();
	public NoitaFloat max_energy { get; set; } = new();
	public NoitaFloat energy_required_to_shield { get; set; } = new();
	public NoitaFloat recharge_speed { get; set; } = new();
	public NoitaFloat sector_degrees { get; set; } = new();
	public NoitaFloat energy { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		damage_multiplier.Read(s);
		max_energy.Read(s);
		energy_required_to_shield.Read(s);
		recharge_speed.Read(s);
		sector_degrees.Read(s);
		energy.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		damage_multiplier.Write(s);
		max_energy.Write(s);
		energy_required_to_shield.Write(s);
		recharge_speed.Write(s);
		sector_degrees.Write(s);
		energy.Write(s);

    }
}