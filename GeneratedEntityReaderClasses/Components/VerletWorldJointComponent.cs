namespace GeneratedNoitaClasses;
public class VerletWorldJointComponent {
	public CVector2<float> world_position { get; set; }
	public Int32 verlet_point_index { get; set; }

    public void Load(NoitaStream s){
		world_position.Load(s);
		verlet_point_index = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		world_position.Write(s);
		s.WriteBeInt32(verlet_point_index);

    }
}