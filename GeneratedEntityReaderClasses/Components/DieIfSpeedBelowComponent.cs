namespace GeneratedNoitaClasses;
public class DieIfSpeedBelowComponent {
	public float min_speed { get; set; }
	public float mMinSpeedSquared { get; set; }

    public void Load(NoitaStream s){
		min_speed = s.ReadBeFloat();
		mMinSpeedSquared = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(min_speed);
		s.WriteBeFloat(mMinSpeedSquared);

    }
}