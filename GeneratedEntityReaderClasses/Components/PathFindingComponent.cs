namespace GeneratedNoitaClasses;
public class PathFindingComponent : NoitaComponentBase,  iNoitaType<PathFindingComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt search_depth_max_no_goal { get; set; } = new();
	public NoitaInt iterations_max_no_goal { get; set; } = new();
	public NoitaInt search_depth_max_with_goal { get; set; } = new();
	public NoitaInt iterations_max_with_goal { get; set; } = new();
	public NoitaFloat cost_of_flying { get; set; } = new();
	public NoitaInt distance_to_reach_node_x { get; set; } = new();
	public NoitaInt distance_to_reach_node_y { get; set; } = new();
	public NoitaInt frames_to_get_stuck { get; set; } = new();
	public NoitaInt frames_between_searches { get; set; } = new();
	public NoitaFloat y_walking_compensation { get; set; } = new();
	public NoitaBool can_fly { get; set; } = new();
	public NoitaBool can_walk { get; set; } = new();
	public NoitaBool can_jump { get; set; } = new();
	public NoitaBool can_dive { get; set; } = new();
	public NoitaBool can_swim_on_surface { get; set; } = new();
	public NoitaBool never_consider_line_of_sight { get; set; } = new();
	public NoitaFloat space_required { get; set; } = new();
	public NoitaFloat max_jump_distance_from_camera { get; set; } = new();
	public NoitaFloat jump_speed { get; set; } = new();
	public NoitaFloat initial_jump_lob { get; set; } = new();
	public NoitaFloat initial_jump_max_distance_x { get; set; } = new();
	public NoitaFloat initial_jump_max_distance_y { get; set; } = new();
	public NoitaVector<PathFindingJumpParams> jump_trajectories { get; set; } = new();
	public NoitaInt read_state { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		search_depth_max_no_goal.Read(s);
		iterations_max_no_goal.Read(s);
		search_depth_max_with_goal.Read(s);
		iterations_max_with_goal.Read(s);
		cost_of_flying.Read(s);
		distance_to_reach_node_x.Read(s);
		distance_to_reach_node_y.Read(s);
		frames_to_get_stuck.Read(s);
		frames_between_searches.Read(s);
		y_walking_compensation.Read(s);
		can_fly.Read(s);
		can_walk.Read(s);
		can_jump.Read(s);
		can_dive.Read(s);
		can_swim_on_surface.Read(s);
		never_consider_line_of_sight.Read(s);
		space_required.Read(s);
		max_jump_distance_from_camera.Read(s);
		jump_speed.Read(s);
		initial_jump_lob.Read(s);
		initial_jump_max_distance_x.Read(s);
		initial_jump_max_distance_y.Read(s);
		jump_trajectories.Read(s);
		read_state.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		search_depth_max_no_goal.Write(s);
		iterations_max_no_goal.Write(s);
		search_depth_max_with_goal.Write(s);
		iterations_max_with_goal.Write(s);
		cost_of_flying.Write(s);
		distance_to_reach_node_x.Write(s);
		distance_to_reach_node_y.Write(s);
		frames_to_get_stuck.Write(s);
		frames_between_searches.Write(s);
		y_walking_compensation.Write(s);
		can_fly.Write(s);
		can_walk.Write(s);
		can_jump.Write(s);
		can_dive.Write(s);
		can_swim_on_surface.Write(s);
		never_consider_line_of_sight.Write(s);
		space_required.Write(s);
		max_jump_distance_from_camera.Write(s);
		jump_speed.Write(s);
		initial_jump_lob.Write(s);
		initial_jump_max_distance_x.Write(s);
		initial_jump_max_distance_y.Write(s);
		jump_trajectories.Write(s);
		read_state.Write(s);

    }
}