namespace GeneratedNoitaClasses;
public class IKLimbComponent {
	public float length { get; set; }
	public float thigh_extra_lenght { get; set; }
	public CVector2<float> end_position { get; set; }
	public float mJointSideInterpolation { get; set; }
	public CVector2<float> mJointWorldPos { get; set; }
	public CVector2<float> mEndPrevPos { get; set; }

    public void Load(NoitaStream s){
		length = s.ReadBeFloat();
		thigh_extra_lenght = s.ReadBeFloat();
		end_position.Load(s);
		mJointSideInterpolation = s.ReadBeFloat();
		mJointWorldPos.Load(s);
		mEndPrevPos.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(length);
		s.WriteBeFloat(thigh_extra_lenght);
		end_position.Write(s);
		s.WriteBeFloat(mJointSideInterpolation);
		mJointWorldPos.Write(s);
		mEndPrevPos.Write(s);

    }
}