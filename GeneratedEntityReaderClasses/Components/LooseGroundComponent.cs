namespace GeneratedNoitaClasses;
public class LooseGroundComponent {
	public float probability { get; set; }
	public Int32 max_durability { get; set; }
	public float max_distance { get; set; }
	public float max_angle { get; set; }
	public Int32 min_radius { get; set; }
	public Int32 max_radius { get; set; }
	public float chunk_probability { get; set; }
	public float chunk_max_angle { get; set; }
	public Int32 chunk_count { get; set; }
	public Int32 chunk_material { get; set; }
	public string collapse_images { get; set; }

    public void Load(NoitaStream s){
		probability = s.ReadBeFloat();
		max_durability = s.ReadBeInt32();
		max_distance = s.ReadBeFloat();
		max_angle = s.ReadBeFloat();
		min_radius = s.ReadBeInt32();
		max_radius = s.ReadBeInt32();
		chunk_probability = s.ReadBeFloat();
		chunk_max_angle = s.ReadBeFloat();
		chunk_count = s.ReadBeInt32();
		chunk_material = s.ReadBeInt32();
		collapse_images = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(probability);
		s.WriteBeInt32(max_durability);
		s.WriteBeFloat(max_distance);
		s.WriteBeFloat(max_angle);
		s.WriteBeInt32(min_radius);
		s.WriteBeInt32(max_radius);
		s.WriteBeFloat(chunk_probability);
		s.WriteBeFloat(chunk_max_angle);
		s.WriteBeInt32(chunk_count);
		s.WriteBeInt32(chunk_material);
		s.WriteBeString(collapse_images);

    }
}