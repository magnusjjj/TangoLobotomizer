namespace GeneratedNoitaClasses;
public class ElectricityComponent : NoitaComponentBase,  iNoitaType<ElectricityComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt energy { get; set; } = new();
	public NoitaFloat probability_to_heat { get; set; } = new();
	public NoitaInt speed { get; set; } = new();
	public NoitaInt splittings_min { get; set; } = new();
	public NoitaInt splittings_max { get; set; } = new();
	public NoitaInt splitting_energy_min { get; set; } = new();
	public NoitaInt splitting_energy_max { get; set; } = new();
	public NoitaBool hack_is_material_crack { get; set; } = new();
	public NoitaBool hack_crack_ice { get; set; } = new();
	public NoitaBool hack_is_set_fire { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		energy.Read(s);
		probability_to_heat.Read(s);
		speed.Read(s);
		splittings_min.Read(s);
		splittings_max.Read(s);
		splitting_energy_min.Read(s);
		splitting_energy_max.Read(s);
		hack_is_material_crack.Read(s);
		hack_crack_ice.Read(s);
		hack_is_set_fire.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		energy.Write(s);
		probability_to_heat.Write(s);
		speed.Write(s);
		splittings_min.Write(s);
		splittings_max.Write(s);
		splitting_energy_min.Write(s);
		splitting_energy_max.Write(s);
		hack_is_material_crack.Write(s);
		hack_crack_ice.Write(s);
		hack_is_set_fire.Write(s);

    }
}