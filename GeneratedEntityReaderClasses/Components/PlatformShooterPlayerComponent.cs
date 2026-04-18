namespace GeneratedNoitaClasses;
public class PlatformShooterPlayerComponent : NoitaComponentBase,  iNoitaType<PlatformShooterPlayerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat aiming_reticle_distance_from_character { get; set; } = new();
	public NoitaFloat camera_max_distance_from_character { get; set; } = new();
	public NoitaFloat alcohol_drunken_speed { get; set; } = new();
	public NoitaFloat blood_fungi_drunken_speed { get; set; } = new();
	public NoitaFloat blood_worm_drunken_speed { get; set; } = new();
	public NoitaCVector2<NoitaInt> eating_area_min { get; set; } = new();
	public NoitaCVector2<NoitaInt> eating_area_max { get; set; } = new();
	public NoitaInt eating_cells_per_frame { get; set; } = new();
	public NoitaInt eating_probability { get; set; } = new();
	public NoitaInt eating_delay_frames { get; set; } = new();
	public NoitaFloat stoned_speed { get; set; } = new();
	public NoitaBool center_camera_on_this_entity { get; set; } = new();
	public NoitaBool move_camera_with_aim { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		aiming_reticle_distance_from_character.Read(s);
		camera_max_distance_from_character.Read(s);
		alcohol_drunken_speed.Read(s);
		blood_fungi_drunken_speed.Read(s);
		blood_worm_drunken_speed.Read(s);
		eating_area_min.Read(s);
		eating_area_max.Read(s);
		eating_cells_per_frame.Read(s);
		eating_probability.Read(s);
		eating_delay_frames.Read(s);
		stoned_speed.Read(s);
		center_camera_on_this_entity.Read(s);
		move_camera_with_aim.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		aiming_reticle_distance_from_character.Write(s);
		camera_max_distance_from_character.Write(s);
		alcohol_drunken_speed.Write(s);
		blood_fungi_drunken_speed.Write(s);
		blood_worm_drunken_speed.Write(s);
		eating_area_min.Write(s);
		eating_area_max.Write(s);
		eating_cells_per_frame.Write(s);
		eating_probability.Write(s);
		eating_delay_frames.Write(s);
		stoned_speed.Write(s);
		center_camera_on_this_entity.Write(s);
		move_camera_with_aim.Write(s);

    }
}