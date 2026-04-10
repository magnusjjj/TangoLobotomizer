namespace GeneratedNoitaClasses;
public class CrawlerAnimalComponent {
	public float ray_length { get; set; }
	public Int32 ray_count { get; set; }
	public float gravity { get; set; }
	public float terminal_velocity { get; set; }
	public float speed { get; set; }
	public Int32 give_up_area_radius { get; set; }
	public Int32 give_up_time { get; set; }
	public float attack_from_ceiling_check_ray_length { get; set; }
	public Int32 attack_from_ceiling_check_every_n_frames { get; set; }
	public float collision_damage { get; set; }
	public float collision_damage_radius { get; set; }
	public Int32 collision_damage_frames_between { get; set; }
	public bool animate { get; set; }

    public void Load(NoitaStream s){
		ray_length = s.ReadBeFloat();
		ray_count = s.ReadBeInt32();
		gravity = s.ReadBeFloat();
		terminal_velocity = s.ReadBeFloat();
		speed = s.ReadBeFloat();
		give_up_area_radius = s.ReadBeInt32();
		give_up_time = s.ReadBeInt32();
		attack_from_ceiling_check_ray_length = s.ReadBeFloat();
		attack_from_ceiling_check_every_n_frames = s.ReadBeInt32();
		collision_damage = s.ReadBeFloat();
		collision_damage_radius = s.ReadBeFloat();
		collision_damage_frames_between = s.ReadBeInt32();
		animate = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(ray_length);
		s.WriteBeInt32(ray_count);
		s.WriteBeFloat(gravity);
		s.WriteBeFloat(terminal_velocity);
		s.WriteBeFloat(speed);
		s.WriteBeInt32(give_up_area_radius);
		s.WriteBeInt32(give_up_time);
		s.WriteBeFloat(attack_from_ceiling_check_ray_length);
		s.WriteBeInt32(attack_from_ceiling_check_every_n_frames);
		s.WriteBeFloat(collision_damage);
		s.WriteBeFloat(collision_damage_radius);
		s.WriteBeInt32(collision_damage_frames_between);
		s.WriteBool(animate);

    }
}