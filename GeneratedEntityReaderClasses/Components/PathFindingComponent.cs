namespace GeneratedNoitaClasses;
public class PathFindingComponent {
	public Int32 search_depth_max_no_goal { get; set; }
	public Int32 iterations_max_no_goal { get; set; }
	public Int32 search_depth_max_with_goal { get; set; }
	public Int32 iterations_max_with_goal { get; set; }
	public float cost_of_flying { get; set; }
	public Int32 distance_to_reach_node_x { get; set; }
	public Int32 distance_to_reach_node_y { get; set; }
	public Int32 frames_to_get_stuck { get; set; }
	public Int32 frames_between_searches { get; set; }
	public float y_walking_compensation { get; set; }
	public bool can_fly { get; set; }
	public bool can_walk { get; set; }
	public bool can_jump { get; set; }
	public bool can_dive { get; set; }
	public bool can_swim_on_surface { get; set; }
	public bool never_consider_line_of_sight { get; set; }
	public float space_required { get; set; }
	public float max_jump_distance_from_camera { get; set; }
	public float jump_speed { get; set; }
	public float initial_jump_lob { get; set; }
	public float initial_jump_max_distance_x { get; set; }
	public float initial_jump_max_distance_y { get; set; }
	public List<PathFindingJumpParams> jump_trajectories { get; set; }
	public Int32 read_state { get; set; }

    public void Load(NoitaStream s){
		search_depth_max_no_goal = s.ReadBeInt32();
		iterations_max_no_goal = s.ReadBeInt32();
		search_depth_max_with_goal = s.ReadBeInt32();
		iterations_max_with_goal = s.ReadBeInt32();
		cost_of_flying = s.ReadBeFloat();
		distance_to_reach_node_x = s.ReadBeInt32();
		distance_to_reach_node_y = s.ReadBeInt32();
		frames_to_get_stuck = s.ReadBeInt32();
		frames_between_searches = s.ReadBeInt32();
		y_walking_compensation = s.ReadBeFloat();
		can_fly = s.ReadBool();
		can_walk = s.ReadBool();
		can_jump = s.ReadBool();
		can_dive = s.ReadBool();
		can_swim_on_surface = s.ReadBool();
		never_consider_line_of_sight = s.ReadBool();
		space_required = s.ReadBeFloat();
		max_jump_distance_from_camera = s.ReadBeFloat();
		jump_speed = s.ReadBeFloat();
		initial_jump_lob = s.ReadBeFloat();
		initial_jump_max_distance_x = s.ReadBeFloat();
		initial_jump_max_distance_y = s.ReadBeFloat();
		jump_trajectories = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 jump_trajectories.Add(PathFindingJumpParams.Load(s));
}
		read_state = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(search_depth_max_no_goal);
		s.WriteBeInt32(iterations_max_no_goal);
		s.WriteBeInt32(search_depth_max_with_goal);
		s.WriteBeInt32(iterations_max_with_goal);
		s.WriteBeFloat(cost_of_flying);
		s.WriteBeInt32(distance_to_reach_node_x);
		s.WriteBeInt32(distance_to_reach_node_y);
		s.WriteBeInt32(frames_to_get_stuck);
		s.WriteBeInt32(frames_between_searches);
		s.WriteBeFloat(y_walking_compensation);
		s.WriteBool(can_fly);
		s.WriteBool(can_walk);
		s.WriteBool(can_jump);
		s.WriteBool(can_dive);
		s.WriteBool(can_swim_on_surface);
		s.WriteBool(never_consider_line_of_sight);
		s.WriteBeFloat(space_required);
		s.WriteBeFloat(max_jump_distance_from_camera);
		s.WriteBeFloat(jump_speed);
		s.WriteBeFloat(initial_jump_lob);
		s.WriteBeFloat(initial_jump_max_distance_x);
		s.WriteBeFloat(initial_jump_max_distance_y);
		s.WriteBeUInt32(jump_trajectories.Length);
foreach(var item in jump_trajectories){ jump_trajectories.Write(s);
}
		s.WriteBeInt32(read_state);

    }
}