namespace GeneratedNoitaClasses;
public class AdvancedFishAIComponent {
	public float move_check_range_min { get; set; }
	public float move_check_range_max { get; set; }

    public void Load(NoitaStream s){
		move_check_range_min = s.ReadBeFloat();
		move_check_range_max = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(move_check_range_min);
		s.WriteBeFloat(move_check_range_max);

    }
}