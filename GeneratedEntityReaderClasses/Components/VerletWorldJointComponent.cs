namespace GeneratedNoitaClasses;
public class VerletWorldJointComponent : NoitaComponentBase,  iNoitaType<VerletWorldJointComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCVector2<NoitaFloat> world_position { get; set; } = new();
	public NoitaInt verlet_point_index { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		world_position.Read(s);
		verlet_point_index.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		world_position.Write(s);
		verlet_point_index.Write(s);

    }
}