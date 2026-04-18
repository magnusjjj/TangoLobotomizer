namespace GeneratedNoitaClasses;
public class DebugSpatialVisualizerComponent : NoitaComponentBase,  iNoitaType<DebugSpatialVisualizerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat min_x { get; set; } = new();
	public NoitaFloat min_y { get; set; } = new();
	public NoitaFloat max_x { get; set; } = new();
	public NoitaFloat max_y { get; set; } = new();
	public NoitaUInt color { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		min_x.Read(s);
		min_y.Read(s);
		max_x.Read(s);
		max_y.Read(s);
		color.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		min_x.Write(s);
		min_y.Write(s);
		max_x.Write(s);
		max_y.Write(s);
		color.Write(s);

    }
}