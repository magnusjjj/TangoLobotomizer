namespace GeneratedNoitaClasses;
public class MaterialAreaCheckerComponent : NoitaComponentBase,  iNoitaType<MaterialAreaCheckerComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt update_every_x_frame { get; set; } = new();
	public NoitaBool look_for_failure { get; set; } = new();
	public types_aabb area_aabb { get; set; } = new();
	public NoitaInt material { get; set; } = new();
	public NoitaInt material2 { get; set; } = new();
	public NoitaInt count_min { get; set; } = new();
	public NoitaBool always_check_fullness { get; set; } = new();
	public NoitaBool kill_after_message { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		update_every_x_frame.Read(s);
		look_for_failure.Read(s);
		area_aabb.Read(s);
		material.Read(s);
		material2.Read(s);
		count_min.Read(s);
		always_check_fullness.Read(s);
		kill_after_message.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		update_every_x_frame.Write(s);
		look_for_failure.Write(s);
		area_aabb.Write(s);
		material.Write(s);
		material2.Write(s);
		count_min.Write(s);
		always_check_fullness.Write(s);
		kill_after_message.Write(s);

    }
}