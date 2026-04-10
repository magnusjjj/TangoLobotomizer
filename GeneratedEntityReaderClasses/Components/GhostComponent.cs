namespace GeneratedNoitaClasses;
public class GhostComponent {
	public float speed { get; set; }
	public CVector2<float> velocity { get; set; }
	public Int32 new_hunt_target_check_every { get; set; }
	public float hunt_box_radius { get; set; }
	public float aggressiveness { get; set; }
	public float max_distance_from_home { get; set; }
	public bool die_if_no_home { get; set; }
	public string target_tag { get; set; }

    public void Load(NoitaStream s){
		speed = s.ReadBeFloat();
		velocity.Load(s);
		new_hunt_target_check_every = s.ReadBeInt32();
		hunt_box_radius = s.ReadBeFloat();
		aggressiveness = s.ReadBeFloat();
		max_distance_from_home = s.ReadBeFloat();
		die_if_no_home = s.ReadBool();
		target_tag = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(speed);
		velocity.Write(s);
		s.WriteBeInt32(new_hunt_target_check_every);
		s.WriteBeFloat(hunt_box_radius);
		s.WriteBeFloat(aggressiveness);
		s.WriteBeFloat(max_distance_from_home);
		s.WriteBool(die_if_no_home);
		s.WriteBeString(target_tag);

    }
}