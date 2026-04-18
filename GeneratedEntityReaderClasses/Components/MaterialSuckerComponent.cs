namespace GeneratedNoitaClasses;
public class MaterialSuckerComponent : NoitaComponentBase,  iNoitaType<MaterialSuckerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt material_type { get; set; } = new();
	public NoitaInt barrel_size { get; set; } = new();
	public NoitaInt num_cells_sucked_per_frame { get; set; } = new();
	public NoitaBool set_projectile_to_liquid { get; set; } = new();
	public NoitaInt last_material_id { get; set; } = new();
	public NoitaBool suck_gold { get; set; } = new();
	public NoitaBool suck_health { get; set; } = new();
	public NoitaBool suck_static_materials { get; set; } = new();
	public NoitaString suck_tag { get; set; } = new();
	public types_iaabb randomized_position { get; set; } = new();
	public NoitaInt mAmountUsed { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		material_type.Read(s);
		barrel_size.Read(s);
		num_cells_sucked_per_frame.Read(s);
		set_projectile_to_liquid.Read(s);
		last_material_id.Read(s);
		suck_gold.Read(s);
		suck_health.Read(s);
		suck_static_materials.Read(s);
		suck_tag.Read(s);
		randomized_position.Read(s);
		mAmountUsed.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		material_type.Write(s);
		barrel_size.Write(s);
		num_cells_sucked_per_frame.Write(s);
		set_projectile_to_liquid.Write(s);
		last_material_id.Write(s);
		suck_gold.Write(s);
		suck_health.Write(s);
		suck_static_materials.Write(s);
		suck_tag.Write(s);
		randomized_position.Write(s);
		mAmountUsed.Write(s);

    }
}