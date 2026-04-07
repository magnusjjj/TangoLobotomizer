namespace GeneratedNoitaClasses;
public class PathFindingComponent{
	public int search_depth_max_no_goal{ get; set; }
	public int iterations_max_no_goal{ get; set; }
	public int search_depth_max_with_goal{ get; set; }
	public int iterations_max_with_goal{ get; set; }
	public float cost_of_flying{ get; set; }
	public int distance_to_reach_node_x{ get; set; }
	public int distance_to_reach_node_y{ get; set; }
	public int frames_to_get_stuck{ get; set; }
	public int frames_between_searches{ get; set; }
	public float y_walking_compensation{ get; set; }
	public bool can_fly{ get; set; }
	public bool can_walk{ get; set; }
	public bool can_jump{ get; set; }
	public bool can_dive{ get; set; }
	public bool can_swim_on_surface{ get; set; }
	public bool never_consider_line_of_sight{ get; set; }
	public float space_required{ get; set; }
	public float max_jump_distance_from_camera{ get; set; }
	public float jump_speed{ get; set; }
	public float initial_jump_lob{ get; set; }
	public float initial_jump_max_distance_x{ get; set; }
	public float initial_jump_max_distance_y{ get; set; }
	public List<PathFindingJumpParams> jump_trajectories{ get; set; }
	public int read_state{ get; set; }

}