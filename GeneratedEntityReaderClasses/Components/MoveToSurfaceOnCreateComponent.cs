namespace GeneratedNoitaClasses;
public class MoveToSurfaceOnCreateComponent : NoitaComponentBase,  iNoitaType<MoveToSurfaceOnCreateComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaUInt type { get; set; } = new();
	public NoitaFloat lookup_radius { get; set; } = new();
	public NoitaFloat offset_from_surface { get; set; } = new();
	public NoitaInt ray_count { get; set; } = new();
	public NoitaFloat verlet_min_joint_distance { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		type.Read(s);
		lookup_radius.Read(s);
		offset_from_surface.Read(s);
		ray_count.Read(s);
		verlet_min_joint_distance.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		type.Write(s);
		lookup_radius.Write(s);
		offset_from_surface.Write(s);
		ray_count.Write(s);
		verlet_min_joint_distance.Write(s);

    }
}