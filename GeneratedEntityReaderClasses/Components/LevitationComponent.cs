namespace GeneratedNoitaClasses;
public class LevitationComponent {
	public float radius { get; set; }
	public float entity_force { get; set; }
	public float box2d_force { get; set; }
	public Int32 effect_lifetime_frames { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		entity_force = s.ReadBeFloat();
		box2d_force = s.ReadBeFloat();
		effect_lifetime_frames = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeFloat(entity_force);
		s.WriteBeFloat(box2d_force);
		s.WriteBeInt32(effect_lifetime_frames);

    }
}