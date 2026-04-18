namespace GeneratedNoitaClasses;
public class PathFindingGridMarkerComponent : NoitaComponentBase,  iNoitaType<PathFindingGridMarkerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt marker_work_flag { get; set; } = new();
	public NoitaFloat marker_offset_x { get; set; } = new();
	public NoitaFloat marker_offset_y { get; set; } = new();
	public NoitaFloat player_marker_radius { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		marker_work_flag.Read(s);
		marker_offset_x.Read(s);
		marker_offset_y.Read(s);
		player_marker_radius.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		marker_work_flag.Write(s);
		marker_offset_x.Write(s);
		marker_offset_y.Write(s);
		player_marker_radius.Write(s);

    }
}