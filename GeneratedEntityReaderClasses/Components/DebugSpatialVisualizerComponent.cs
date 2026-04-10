namespace GeneratedNoitaClasses;
public class DebugSpatialVisualizerComponent {
	public float min_x { get; set; }
	public float min_y { get; set; }
	public float max_x { get; set; }
	public float max_y { get; set; }
	public UInt32 color { get; set; }

    public void Load(NoitaStream s){
		min_x = s.ReadBeFloat();
		min_y = s.ReadBeFloat();
		max_x = s.ReadBeFloat();
		max_y = s.ReadBeFloat();
		color = s.ReadBeUInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(min_x);
		s.WriteBeFloat(min_y);
		s.WriteBeFloat(max_x);
		s.WriteBeFloat(max_y);
		s.WriteBeUInt32(color);

    }
}