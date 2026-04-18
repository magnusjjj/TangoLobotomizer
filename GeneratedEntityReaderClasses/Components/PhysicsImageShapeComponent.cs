namespace GeneratedNoitaClasses;
public class PhysicsImageShapeComponent : NoitaComponentBase,  iNoitaType<PhysicsImageShapeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool is_root { get; set; } = new();
	public NoitaInt body_id { get; set; } = new();
	public NoitaBool use_sprite { get; set; } = new();
	public NoitaBool is_circle { get; set; } = new();
	public NoitaBool centered { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();
	public NoitaFloat z { get; set; } = new();
	public NoitaString image_file { get; set; } = new();
	public NoitaInt material { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		is_root.Read(s);
		body_id.Read(s);
		use_sprite.Read(s);
		is_circle.Read(s);
		centered.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		z.Read(s);
		image_file.Read(s);
		material.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		is_root.Write(s);
		body_id.Write(s);
		use_sprite.Write(s);
		is_circle.Write(s);
		centered.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		z.Write(s);
		image_file.Write(s);
		material.Write(s);

    }
}