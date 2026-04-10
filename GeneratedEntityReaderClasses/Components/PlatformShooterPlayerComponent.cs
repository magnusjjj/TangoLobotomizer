namespace GeneratedNoitaClasses;
public class PlatformShooterPlayerComponent {
	public float aiming_reticle_distance_from_character { get; set; }
	public float camera_max_distance_from_character { get; set; }
	public float alcohol_drunken_speed { get; set; }
	public float blood_fungi_drunken_speed { get; set; }
	public float blood_worm_drunken_speed { get; set; }
	public CVector2<int> eating_area_min { get; set; }
	public CVector2<int> eating_area_max { get; set; }
	public Int32 eating_cells_per_frame { get; set; }
	public Int32 eating_probability { get; set; }
	public Int32 eating_delay_frames { get; set; }
	public float stoned_speed { get; set; }
	public bool center_camera_on_this_entity { get; set; }
	public bool move_camera_with_aim { get; set; }

    public void Load(NoitaStream s){
		aiming_reticle_distance_from_character = s.ReadBeFloat();
		camera_max_distance_from_character = s.ReadBeFloat();
		alcohol_drunken_speed = s.ReadBeFloat();
		blood_fungi_drunken_speed = s.ReadBeFloat();
		blood_worm_drunken_speed = s.ReadBeFloat();
		eating_area_min.Load(s);
		eating_area_max.Load(s);
		eating_cells_per_frame = s.ReadBeInt32();
		eating_probability = s.ReadBeInt32();
		eating_delay_frames = s.ReadBeInt32();
		stoned_speed = s.ReadBeFloat();
		center_camera_on_this_entity = s.ReadBool();
		move_camera_with_aim = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(aiming_reticle_distance_from_character);
		s.WriteBeFloat(camera_max_distance_from_character);
		s.WriteBeFloat(alcohol_drunken_speed);
		s.WriteBeFloat(blood_fungi_drunken_speed);
		s.WriteBeFloat(blood_worm_drunken_speed);
		eating_area_min.Write(s);
		eating_area_max.Write(s);
		s.WriteBeInt32(eating_cells_per_frame);
		s.WriteBeInt32(eating_probability);
		s.WriteBeInt32(eating_delay_frames);
		s.WriteBeFloat(stoned_speed);
		s.WriteBool(center_camera_on_this_entity);
		s.WriteBool(move_camera_with_aim);

    }
}