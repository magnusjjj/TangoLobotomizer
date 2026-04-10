namespace GeneratedNoitaClasses;
public class PhysicsPickUpComponent {
	public CXForm<float> transform { get; set; }
	public CVector2<float> original_left_joint_pos { get; set; }
	public CVector2<float> original_right_joint_pos { get; set; }
	public float pick_up_strength { get; set; }

    public void Load(NoitaStream s){
		transform.Load(s);
		original_left_joint_pos.Load(s);
		original_right_joint_pos.Load(s);
		pick_up_strength = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		transform.Write(s);
		original_left_joint_pos.Write(s);
		original_right_joint_pos.Write(s);
		s.WriteBeFloat(pick_up_strength);

    }
}