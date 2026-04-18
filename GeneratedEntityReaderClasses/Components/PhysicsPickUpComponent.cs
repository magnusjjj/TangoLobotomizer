namespace GeneratedNoitaClasses;
public class PhysicsPickUpComponent : NoitaComponentBase,  iNoitaType<PhysicsPickUpComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCXForm<NoitaFloat> transform { get; set; } = new();
	public NoitaCVector2<NoitaFloat> original_left_joint_pos { get; set; } = new();
	public NoitaCVector2<NoitaFloat> original_right_joint_pos { get; set; } = new();
	public NoitaFloat pick_up_strength { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		transform.Read(s);
		original_left_joint_pos.Read(s);
		original_right_joint_pos.Read(s);
		pick_up_strength.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		transform.Write(s);
		original_left_joint_pos.Write(s);
		original_right_joint_pos.Write(s);
		pick_up_strength.Write(s);

    }
}