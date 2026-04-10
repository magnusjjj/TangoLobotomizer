namespace GeneratedNoitaClasses;
public class MaterialSuckerComponent {
	public Int32 material_type { get; set; }
	public Int32 barrel_size { get; set; }
	public Int32 num_cells_sucked_per_frame { get; set; }
	public bool set_projectile_to_liquid { get; set; }
	public Int32 last_material_id { get; set; }
	public bool suck_gold { get; set; }
	public bool suck_health { get; set; }
	public bool suck_static_materials { get; set; }
	public string suck_tag { get; set; }
	public types_iaabb randomized_position { get; set; }
	public Int32 mAmountUsed { get; set; }

    public void Load(NoitaStream s){
		material_type = s.ReadBeInt32();
		barrel_size = s.ReadBeInt32();
		num_cells_sucked_per_frame = s.ReadBeInt32();
		set_projectile_to_liquid = s.ReadBool();
		last_material_id = s.ReadBeInt32();
		suck_gold = s.ReadBool();
		suck_health = s.ReadBool();
		suck_static_materials = s.ReadBool();
		suck_tag = s.ReadBeString();
		randomized_position.Load(s);
		mAmountUsed = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(material_type);
		s.WriteBeInt32(barrel_size);
		s.WriteBeInt32(num_cells_sucked_per_frame);
		s.WriteBool(set_projectile_to_liquid);
		s.WriteBeInt32(last_material_id);
		s.WriteBool(suck_gold);
		s.WriteBool(suck_health);
		s.WriteBool(suck_static_materials);
		s.WriteBeString(suck_tag);
		randomized_position.Write(s);
		s.WriteBeInt32(mAmountUsed);

    }
}