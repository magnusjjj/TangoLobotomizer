namespace GeneratedNoitaClasses;
public class MaterialAreaCheckerComponent {
	public Int32 update_every_x_frame { get; set; }
	public bool look_for_failure { get; set; }
	public types_aabb area_aabb { get; set; }
	public Int32 material { get; set; }
	public Int32 material2 { get; set; }
	public Int32 count_min { get; set; }
	public bool always_check_fullness { get; set; }
	public bool kill_after_message { get; set; }

    public void Load(NoitaStream s){
		update_every_x_frame = s.ReadBeInt32();
		look_for_failure = s.ReadBool();
		area_aabb.Load(s);
		material = s.ReadBeInt32();
		material2 = s.ReadBeInt32();
		count_min = s.ReadBeInt32();
		always_check_fullness = s.ReadBool();
		kill_after_message = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(update_every_x_frame);
		s.WriteBool(look_for_failure);
		area_aabb.Write(s);
		s.WriteBeInt32(material);
		s.WriteBeInt32(material2);
		s.WriteBeInt32(count_min);
		s.WriteBool(always_check_fullness);
		s.WriteBool(kill_after_message);

    }
}