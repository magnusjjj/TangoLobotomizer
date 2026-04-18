namespace GeneratedNoitaClasses;
public class LooseGroundComponent : NoitaComponentBase,  iNoitaType<LooseGroundComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat probability { get; set; } = new();
	public NoitaInt max_durability { get; set; } = new();
	public NoitaFloat max_distance { get; set; } = new();
	public NoitaFloat max_angle { get; set; } = new();
	public NoitaInt min_radius { get; set; } = new();
	public NoitaInt max_radius { get; set; } = new();
	public NoitaFloat chunk_probability { get; set; } = new();
	public NoitaFloat chunk_max_angle { get; set; } = new();
	public NoitaInt chunk_count { get; set; } = new();
	public NoitaInt chunk_material { get; set; } = new();
	public NoitaString collapse_images { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		probability.Read(s);
		max_durability.Read(s);
		max_distance.Read(s);
		max_angle.Read(s);
		min_radius.Read(s);
		max_radius.Read(s);
		chunk_probability.Read(s);
		chunk_max_angle.Read(s);
		chunk_count.Read(s);
		chunk_material.Read(s);
		collapse_images.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		probability.Write(s);
		max_durability.Write(s);
		max_distance.Write(s);
		max_angle.Write(s);
		min_radius.Write(s);
		max_radius.Write(s);
		chunk_probability.Write(s);
		chunk_max_angle.Write(s);
		chunk_count.Write(s);
		chunk_material.Write(s);
		collapse_images.Write(s);

    }
}