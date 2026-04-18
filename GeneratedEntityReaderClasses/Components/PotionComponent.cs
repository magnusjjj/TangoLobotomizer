namespace GeneratedNoitaClasses;
public class PotionComponent : NoitaComponentBase,  iNoitaType<PotionComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat spray_velocity_coeff { get; set; } = new();
	public NoitaFloat spray_velocity_normalized_min { get; set; } = new();
	public NoitaBool body_colored { get; set; } = new();
	public NoitaBool throw_bunch { get; set; } = new();
	public NoitaInt throw_how_many { get; set; } = new();
	public NoitaBool dont_spray_static_materials { get; set; } = new();
	public NoitaBool dont_spray_just_leak_gas_materials { get; set; } = new();
	public NoitaBool never_color { get; set; } = new();
	public NoitaInt custom_color_material { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		spray_velocity_coeff.Read(s);
		spray_velocity_normalized_min.Read(s);
		body_colored.Read(s);
		throw_bunch.Read(s);
		throw_how_many.Read(s);
		dont_spray_static_materials.Read(s);
		dont_spray_just_leak_gas_materials.Read(s);
		never_color.Read(s);
		custom_color_material.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		spray_velocity_coeff.Write(s);
		spray_velocity_normalized_min.Write(s);
		body_colored.Write(s);
		throw_bunch.Write(s);
		throw_how_many.Write(s);
		dont_spray_static_materials.Write(s);
		dont_spray_just_leak_gas_materials.Write(s);
		never_color.Write(s);
		custom_color_material.Write(s);

    }
}