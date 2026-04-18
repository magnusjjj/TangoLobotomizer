namespace GeneratedNoitaClasses;
public class CellEaterComponent : NoitaComponentBase,  iNoitaType<CellEaterComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaInt eat_probability { get; set; } = new();
	public NoitaInt ignored_material { get; set; } = new();
	public NoitaBool only_stain { get; set; } = new();
	public NoitaBool eat_dynamic_physics_bodies { get; set; } = new();
	public NoitaBool limited_materials { get; set; } = new();
	public NoitaString ignored_material_tag { get; set; } = new();
	public NoitaVector<NoitaInt> materials { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		eat_probability.Read(s);
		ignored_material.Read(s);
		only_stain.Read(s);
		eat_dynamic_physics_bodies.Read(s);
		limited_materials.Read(s);
		ignored_material_tag.Read(s);
		materials.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		eat_probability.Write(s);
		ignored_material.Write(s);
		only_stain.Write(s);
		eat_dynamic_physics_bodies.Write(s);
		limited_materials.Write(s);
		ignored_material_tag.Write(s);
		materials.Write(s);

    }
}