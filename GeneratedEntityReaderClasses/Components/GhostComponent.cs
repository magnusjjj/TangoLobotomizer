namespace GeneratedNoitaClasses;
public class GhostComponent : NoitaComponentBase,  iNoitaType<GhostComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();
	public NoitaCVector2<NoitaFloat> velocity { get; set; } = new();
	public NoitaInt new_hunt_target_check_every { get; set; } = new();
	public NoitaFloat hunt_box_radius { get; set; } = new();
	public NoitaFloat aggressiveness { get; set; } = new();
	public NoitaFloat max_distance_from_home { get; set; } = new();
	public NoitaBool die_if_no_home { get; set; } = new();
	public NoitaString target_tag { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		speed.Read(s);
		velocity.Read(s);
		new_hunt_target_check_every.Read(s);
		hunt_box_radius.Read(s);
		aggressiveness.Read(s);
		max_distance_from_home.Read(s);
		die_if_no_home.Read(s);
		target_tag.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		speed.Write(s);
		velocity.Write(s);
		new_hunt_target_check_every.Write(s);
		hunt_box_radius.Write(s);
		aggressiveness.Write(s);
		max_distance_from_home.Write(s);
		die_if_no_home.Write(s);
		target_tag.Write(s);

    }
}