namespace GeneratedNoitaClasses;
public class PotionComponent {
	public float spray_velocity_coeff { get; set; }
	public float spray_velocity_normalized_min { get; set; }
	public bool body_colored { get; set; }
	public bool throw_bunch { get; set; }
	public Int32 throw_how_many { get; set; }
	public bool dont_spray_static_materials { get; set; }
	public bool dont_spray_just_leak_gas_materials { get; set; }
	public bool never_color { get; set; }
	public Int32 custom_color_material { get; set; }

    public void Load(NoitaStream s){
		spray_velocity_coeff = s.ReadBeFloat();
		spray_velocity_normalized_min = s.ReadBeFloat();
		body_colored = s.ReadBool();
		throw_bunch = s.ReadBool();
		throw_how_many = s.ReadBeInt32();
		dont_spray_static_materials = s.ReadBool();
		dont_spray_just_leak_gas_materials = s.ReadBool();
		never_color = s.ReadBool();
		custom_color_material = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(spray_velocity_coeff);
		s.WriteBeFloat(spray_velocity_normalized_min);
		s.WriteBool(body_colored);
		s.WriteBool(throw_bunch);
		s.WriteBeInt32(throw_how_many);
		s.WriteBool(dont_spray_static_materials);
		s.WriteBool(dont_spray_just_leak_gas_materials);
		s.WriteBool(never_color);
		s.WriteBeInt32(custom_color_material);

    }
}