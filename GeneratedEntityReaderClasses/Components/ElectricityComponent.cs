namespace GeneratedNoitaClasses;
public class ElectricityComponent {
	public Int32 energy { get; set; }
	public float probability_to_heat { get; set; }
	public Int32 speed { get; set; }
	public Int32 splittings_min { get; set; }
	public Int32 splittings_max { get; set; }
	public Int32 splitting_energy_min { get; set; }
	public Int32 splitting_energy_max { get; set; }
	public bool hack_is_material_crack { get; set; }
	public bool hack_crack_ice { get; set; }
	public bool hack_is_set_fire { get; set; }

    public void Load(NoitaStream s){
		energy = s.ReadBeInt32();
		probability_to_heat = s.ReadBeFloat();
		speed = s.ReadBeInt32();
		splittings_min = s.ReadBeInt32();
		splittings_max = s.ReadBeInt32();
		splitting_energy_min = s.ReadBeInt32();
		splitting_energy_max = s.ReadBeInt32();
		hack_is_material_crack = s.ReadBool();
		hack_crack_ice = s.ReadBool();
		hack_is_set_fire = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(energy);
		s.WriteBeFloat(probability_to_heat);
		s.WriteBeInt32(speed);
		s.WriteBeInt32(splittings_min);
		s.WriteBeInt32(splittings_max);
		s.WriteBeInt32(splitting_energy_min);
		s.WriteBeInt32(splitting_energy_max);
		s.WriteBool(hack_is_material_crack);
		s.WriteBool(hack_crack_ice);
		s.WriteBool(hack_is_set_fire);

    }
}