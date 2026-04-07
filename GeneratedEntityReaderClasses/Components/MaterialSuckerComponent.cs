namespace GeneratedNoitaClasses;
public class MaterialSuckerComponent{
	public int material_type{ get; set; }
	public int barrel_size{ get; set; }
	public int num_cells_sucked_per_frame{ get; set; }
	public bool set_projectile_to_liquid{ get; set; }
	public int last_material_id{ get; set; }
	public bool suck_gold{ get; set; }
	public bool suck_health{ get; set; }
	public bool suck_static_materials{ get; set; }
	public string suck_tag{ get; set; }
	public types_iaabb randomized_position{ get; set; }
	public int mAmountUsed{ get; set; }

}