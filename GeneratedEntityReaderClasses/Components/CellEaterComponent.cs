namespace GeneratedNoitaClasses;
public class CellEaterComponent {
	public float radius { get; set; }
	public Int32 eat_probability { get; set; }
	public Int32 ignored_material { get; set; }
	public bool only_stain { get; set; }
	public bool eat_dynamic_physics_bodies { get; set; }
	public bool limited_materials { get; set; }
	public string ignored_material_tag { get; set; }
	public List<int> materials { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		eat_probability = s.ReadBeInt32();
		ignored_material = s.ReadBeInt32();
		only_stain = s.ReadBool();
		eat_dynamic_physics_bodies = s.ReadBool();
		limited_materials = s.ReadBool();
		ignored_material_tag = s.ReadBeString();
		materials = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 materials.Add(int.Load(s));
}

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeInt32(eat_probability);
		s.WriteBeInt32(ignored_material);
		s.WriteBool(only_stain);
		s.WriteBool(eat_dynamic_physics_bodies);
		s.WriteBool(limited_materials);
		s.WriteBeString(ignored_material_tag);
		s.WriteBeUInt32(materials.Length);
foreach(var item in materials){ materials.Write(s);
}

    }
}