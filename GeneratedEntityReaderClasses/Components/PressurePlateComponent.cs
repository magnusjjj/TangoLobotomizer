namespace GeneratedNoitaClasses;
public class PressurePlateComponent : NoitaComponentBase,  iNoitaType<PressurePlateComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt check_every_x_frames { get; set; } = new();
	public NoitaInt state { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_min { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_max { get; set; } = new();
	public NoitaFloat material_percent { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		check_every_x_frames.Read(s);
		state.Read(s);
		aabb_min.Read(s);
		aabb_max.Read(s);
		material_percent.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		check_every_x_frames.Write(s);
		state.Write(s);
		aabb_min.Write(s);
		aabb_max.Write(s);
		material_percent.Write(s);

    }
}