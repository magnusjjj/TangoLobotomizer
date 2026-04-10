namespace GeneratedNoitaClasses;
public class MagicXRayComponent {
	public Int32 radius { get; set; }
	public Int32 steps_per_frame { get; set; }
	public Int32 mStep { get; set; }
	public Int32 mRadius { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeInt32();
		steps_per_frame = s.ReadBeInt32();
		mStep = s.ReadBeInt32();
		mRadius = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(radius);
		s.WriteBeInt32(steps_per_frame);
		s.WriteBeInt32(mStep);
		s.WriteBeInt32(mRadius);

    }
}