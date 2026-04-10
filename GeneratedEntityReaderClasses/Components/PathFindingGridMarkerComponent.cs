namespace GeneratedNoitaClasses;
public class PathFindingGridMarkerComponent {
	public Int32 marker_work_flag { get; set; }
	public float marker_offset_x { get; set; }
	public float marker_offset_y { get; set; }
	public float player_marker_radius { get; set; }

    public void Load(NoitaStream s){
		marker_work_flag = s.ReadBeInt32();
		marker_offset_x = s.ReadBeFloat();
		marker_offset_y = s.ReadBeFloat();
		player_marker_radius = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(marker_work_flag);
		s.WriteBeFloat(marker_offset_x);
		s.WriteBeFloat(marker_offset_y);
		s.WriteBeFloat(player_marker_radius);

    }
}