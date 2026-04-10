namespace GeneratedNoitaClasses;
public class PhysicsImageShapeComponent {
	public bool is_root { get; set; }
	public Int32 body_id { get; set; }
	public bool use_sprite { get; set; }
	public bool is_circle { get; set; }
	public bool centered { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }
	public float z { get; set; }
	public string image_file { get; set; }
	public Int32 material { get; set; }

    public void Load(NoitaStream s){
		is_root = s.ReadBool();
		body_id = s.ReadBeInt32();
		use_sprite = s.ReadBool();
		is_circle = s.ReadBool();
		centered = s.ReadBool();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();
		z = s.ReadBeFloat();
		image_file = s.ReadBeString();
		material = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_root);
		s.WriteBeInt32(body_id);
		s.WriteBool(use_sprite);
		s.WriteBool(is_circle);
		s.WriteBool(centered);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);
		s.WriteBeFloat(z);
		s.WriteBeString(image_file);
		s.WriteBeInt32(material);

    }
}