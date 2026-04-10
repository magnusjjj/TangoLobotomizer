namespace GeneratedNoitaClasses;
public class WormAIComponent {
	public float speed { get; set; }
	public float speed_hunt { get; set; }
	public float direction_adjust_speed { get; set; }
	public float direction_adjust_speed_hunt { get; set; }
	public float random_target_box_radius { get; set; }
	public Int32 new_hunt_target_check_every { get; set; }
	public Int32 new_random_target_check_every { get; set; }
	public float hunt_box_radius { get; set; }
	public Int32 cocoon_food_required { get; set; }
	public string cocoon_entity { get; set; }
	public float give_up_area_radius { get; set; }
	public Int32 give_up_time_frames { get; set; }
	public bool debug_follow_mouse { get; set; }

    public void Load(NoitaStream s){
		speed = s.ReadBeFloat();
		speed_hunt = s.ReadBeFloat();
		direction_adjust_speed = s.ReadBeFloat();
		direction_adjust_speed_hunt = s.ReadBeFloat();
		random_target_box_radius = s.ReadBeFloat();
		new_hunt_target_check_every = s.ReadBeInt32();
		new_random_target_check_every = s.ReadBeInt32();
		hunt_box_radius = s.ReadBeFloat();
		cocoon_food_required = s.ReadBeInt32();
		cocoon_entity = s.ReadBeString();
		give_up_area_radius = s.ReadBeFloat();
		give_up_time_frames = s.ReadBeInt32();
		debug_follow_mouse = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(speed);
		s.WriteBeFloat(speed_hunt);
		s.WriteBeFloat(direction_adjust_speed);
		s.WriteBeFloat(direction_adjust_speed_hunt);
		s.WriteBeFloat(random_target_box_radius);
		s.WriteBeInt32(new_hunt_target_check_every);
		s.WriteBeInt32(new_random_target_check_every);
		s.WriteBeFloat(hunt_box_radius);
		s.WriteBeInt32(cocoon_food_required);
		s.WriteBeString(cocoon_entity);
		s.WriteBeFloat(give_up_area_radius);
		s.WriteBeInt32(give_up_time_frames);
		s.WriteBool(debug_follow_mouse);

    }
}