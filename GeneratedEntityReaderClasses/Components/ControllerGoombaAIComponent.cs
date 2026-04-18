namespace GeneratedNoitaClasses;
public class ControllerGoombaAIComponent : NoitaComponentBase,  iNoitaType<ControllerGoombaAIComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool auto_turn_around_enabled { get; set; } = new();
	public NoitaInt wait_to_turn_around { get; set; } = new();
	public NoitaInt wall_hit_wait { get; set; } = new();
	public NoitaBool check_wall_detection { get; set; } = new();
	public NoitaFloat wall_detection_aabb_min_x { get; set; } = new();
	public NoitaFloat wall_detection_aabb_max_x { get; set; } = new();
	public NoitaFloat wall_detection_aabb_min_y { get; set; } = new();
	public NoitaFloat wall_detection_aabb_max_y { get; set; } = new();
	public NoitaBool check_floor_detection { get; set; } = new();
	public NoitaFloat floor_detection_aabb_min_x { get; set; } = new();
	public NoitaFloat floor_detection_aabb_max_x { get; set; } = new();
	public NoitaFloat floor_detection_aabb_min_y { get; set; } = new();
	public NoitaFloat floor_detection_aabb_max_y { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		auto_turn_around_enabled.Read(s);
		wait_to_turn_around.Read(s);
		wall_hit_wait.Read(s);
		check_wall_detection.Read(s);
		wall_detection_aabb_min_x.Read(s);
		wall_detection_aabb_max_x.Read(s);
		wall_detection_aabb_min_y.Read(s);
		wall_detection_aabb_max_y.Read(s);
		check_floor_detection.Read(s);
		floor_detection_aabb_min_x.Read(s);
		floor_detection_aabb_max_x.Read(s);
		floor_detection_aabb_min_y.Read(s);
		floor_detection_aabb_max_y.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		auto_turn_around_enabled.Write(s);
		wait_to_turn_around.Write(s);
		wall_hit_wait.Write(s);
		check_wall_detection.Write(s);
		wall_detection_aabb_min_x.Write(s);
		wall_detection_aabb_max_x.Write(s);
		wall_detection_aabb_min_y.Write(s);
		wall_detection_aabb_max_y.Write(s);
		check_floor_detection.Write(s);
		floor_detection_aabb_min_x.Write(s);
		floor_detection_aabb_max_x.Write(s);
		floor_detection_aabb_min_y.Write(s);
		floor_detection_aabb_max_y.Write(s);

    }
}