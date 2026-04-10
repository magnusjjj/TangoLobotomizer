namespace GeneratedNoitaClasses;
public class ControllerGoombaAIComponent {
	public bool auto_turn_around_enabled { get; set; }
	public Int32 wait_to_turn_around { get; set; }
	public Int32 wall_hit_wait { get; set; }
	public bool check_wall_detection { get; set; }
	public float wall_detection_aabb_min_x { get; set; }
	public float wall_detection_aabb_max_x { get; set; }
	public float wall_detection_aabb_min_y { get; set; }
	public float wall_detection_aabb_max_y { get; set; }
	public bool check_floor_detection { get; set; }
	public float floor_detection_aabb_min_x { get; set; }
	public float floor_detection_aabb_max_x { get; set; }
	public float floor_detection_aabb_min_y { get; set; }
	public float floor_detection_aabb_max_y { get; set; }

    public void Load(NoitaStream s){
		auto_turn_around_enabled = s.ReadBool();
		wait_to_turn_around = s.ReadBeInt32();
		wall_hit_wait = s.ReadBeInt32();
		check_wall_detection = s.ReadBool();
		wall_detection_aabb_min_x = s.ReadBeFloat();
		wall_detection_aabb_max_x = s.ReadBeFloat();
		wall_detection_aabb_min_y = s.ReadBeFloat();
		wall_detection_aabb_max_y = s.ReadBeFloat();
		check_floor_detection = s.ReadBool();
		floor_detection_aabb_min_x = s.ReadBeFloat();
		floor_detection_aabb_max_x = s.ReadBeFloat();
		floor_detection_aabb_min_y = s.ReadBeFloat();
		floor_detection_aabb_max_y = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(auto_turn_around_enabled);
		s.WriteBeInt32(wait_to_turn_around);
		s.WriteBeInt32(wall_hit_wait);
		s.WriteBool(check_wall_detection);
		s.WriteBeFloat(wall_detection_aabb_min_x);
		s.WriteBeFloat(wall_detection_aabb_max_x);
		s.WriteBeFloat(wall_detection_aabb_min_y);
		s.WriteBeFloat(wall_detection_aabb_max_y);
		s.WriteBool(check_floor_detection);
		s.WriteBeFloat(floor_detection_aabb_min_x);
		s.WriteBeFloat(floor_detection_aabb_max_x);
		s.WriteBeFloat(floor_detection_aabb_min_y);
		s.WriteBeFloat(floor_detection_aabb_max_y);

    }
}