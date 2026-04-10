namespace GeneratedNoitaClasses;
public class MoveToSurfaceOnCreateComponent {
	public UInt32 type { get; set; }
	public float lookup_radius { get; set; }
	public float offset_from_surface { get; set; }
	public Int32 ray_count { get; set; }
	public float verlet_min_joint_distance { get; set; }

    public void Load(NoitaStream s){
		type = s.ReadBeUInt32();
		lookup_radius = s.ReadBeFloat();
		offset_from_surface = s.ReadBeFloat();
		ray_count = s.ReadBeInt32();
		verlet_min_joint_distance = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(type);
		s.WriteBeFloat(lookup_radius);
		s.WriteBeFloat(offset_from_surface);
		s.WriteBeInt32(ray_count);
		s.WriteBeFloat(verlet_min_joint_distance);

    }
}