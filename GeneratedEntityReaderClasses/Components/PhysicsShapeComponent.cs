namespace GeneratedNoitaClasses;
public class PhysicsShapeComponent {
	public bool recreate { get; set; }
	public bool is_circle { get; set; }
	public bool is_box { get; set; }
	public bool is_capsule { get; set; }
	public bool is_based_on_sprite { get; set; }
	public float friction { get; set; }
	public float restitution { get; set; }
	public float density { get; set; }
	public float local_position_x { get; set; }
	public float local_position_y { get; set; }
	public float radius_x { get; set; }
	public float radius_y { get; set; }
	public float capsule_x_percent { get; set; }
	public float capsule_y_percent { get; set; }
	public Int32 material { get; set; }

    public void Load(NoitaStream s){
		recreate = s.ReadBool();
		is_circle = s.ReadBool();
		is_box = s.ReadBool();
		is_capsule = s.ReadBool();
		is_based_on_sprite = s.ReadBool();
		friction = s.ReadBeFloat();
		restitution = s.ReadBeFloat();
		density = s.ReadBeFloat();
		local_position_x = s.ReadBeFloat();
		local_position_y = s.ReadBeFloat();
		radius_x = s.ReadBeFloat();
		radius_y = s.ReadBeFloat();
		capsule_x_percent = s.ReadBeFloat();
		capsule_y_percent = s.ReadBeFloat();
		material = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBool(recreate);
		s.WriteBool(is_circle);
		s.WriteBool(is_box);
		s.WriteBool(is_capsule);
		s.WriteBool(is_based_on_sprite);
		s.WriteBeFloat(friction);
		s.WriteBeFloat(restitution);
		s.WriteBeFloat(density);
		s.WriteBeFloat(local_position_x);
		s.WriteBeFloat(local_position_y);
		s.WriteBeFloat(radius_x);
		s.WriteBeFloat(radius_y);
		s.WriteBeFloat(capsule_x_percent);
		s.WriteBeFloat(capsule_y_percent);
		s.WriteBeInt32(material);

    }
}