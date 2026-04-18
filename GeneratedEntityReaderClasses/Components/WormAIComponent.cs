namespace GeneratedNoitaClasses;
public class WormAIComponent : NoitaComponentBase,  iNoitaType<WormAIComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();
	public NoitaFloat speed_hunt { get; set; } = new();
	public NoitaFloat direction_adjust_speed { get; set; } = new();
	public NoitaFloat direction_adjust_speed_hunt { get; set; } = new();
	public NoitaFloat random_target_box_radius { get; set; } = new();
	public NoitaInt new_hunt_target_check_every { get; set; } = new();
	public NoitaInt new_random_target_check_every { get; set; } = new();
	public NoitaFloat hunt_box_radius { get; set; } = new();
	public NoitaInt cocoon_food_required { get; set; } = new();
	public NoitaString cocoon_entity { get; set; } = new();
	public NoitaFloat give_up_area_radius { get; set; } = new();
	public NoitaInt give_up_time_frames { get; set; } = new();
	public NoitaBool debug_follow_mouse { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		speed.Read(s);
		speed_hunt.Read(s);
		direction_adjust_speed.Read(s);
		direction_adjust_speed_hunt.Read(s);
		random_target_box_radius.Read(s);
		new_hunt_target_check_every.Read(s);
		new_random_target_check_every.Read(s);
		hunt_box_radius.Read(s);
		cocoon_food_required.Read(s);
		cocoon_entity.Read(s);
		give_up_area_radius.Read(s);
		give_up_time_frames.Read(s);
		debug_follow_mouse.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		speed.Write(s);
		speed_hunt.Write(s);
		direction_adjust_speed.Write(s);
		direction_adjust_speed_hunt.Write(s);
		random_target_box_radius.Write(s);
		new_hunt_target_check_every.Write(s);
		new_random_target_check_every.Write(s);
		hunt_box_radius.Write(s);
		cocoon_food_required.Write(s);
		cocoon_entity.Write(s);
		give_up_area_radius.Write(s);
		give_up_time_frames.Write(s);
		debug_follow_mouse.Write(s);

    }
}