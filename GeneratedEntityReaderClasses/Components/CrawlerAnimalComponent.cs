namespace GeneratedNoitaClasses;
public class CrawlerAnimalComponent : NoitaComponentBase,  iNoitaType<CrawlerAnimalComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat ray_length { get; set; } = new();
	public NoitaInt ray_count { get; set; } = new();
	public NoitaFloat gravity { get; set; } = new();
	public NoitaFloat terminal_velocity { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();
	public NoitaInt give_up_area_radius { get; set; } = new();
	public NoitaInt give_up_time { get; set; } = new();
	public NoitaFloat attack_from_ceiling_check_ray_length { get; set; } = new();
	public NoitaInt attack_from_ceiling_check_every_n_frames { get; set; } = new();
	public NoitaFloat collision_damage { get; set; } = new();
	public NoitaFloat collision_damage_radius { get; set; } = new();
	public NoitaInt collision_damage_frames_between { get; set; } = new();
	public NoitaBool animate { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		ray_length.Read(s);
		ray_count.Read(s);
		gravity.Read(s);
		terminal_velocity.Read(s);
		speed.Read(s);
		give_up_area_radius.Read(s);
		give_up_time.Read(s);
		attack_from_ceiling_check_ray_length.Read(s);
		attack_from_ceiling_check_every_n_frames.Read(s);
		collision_damage.Read(s);
		collision_damage_radius.Read(s);
		collision_damage_frames_between.Read(s);
		animate.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		ray_length.Write(s);
		ray_count.Write(s);
		gravity.Write(s);
		terminal_velocity.Write(s);
		speed.Write(s);
		give_up_area_radius.Write(s);
		give_up_time.Write(s);
		attack_from_ceiling_check_ray_length.Write(s);
		attack_from_ceiling_check_every_n_frames.Write(s);
		collision_damage.Write(s);
		collision_damage_radius.Write(s);
		collision_damage_frames_between.Write(s);
		animate.Write(s);

    }
}