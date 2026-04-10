namespace GeneratedNoitaClasses;
public class CardinalMovementComponent {
	public bool horizontal_movement { get; set; }
	public bool vertical_movement { get; set; }
	public bool intercardinal_movement { get; set; }

    public void Load(NoitaStream s){
		horizontal_movement = s.ReadBool();
		vertical_movement = s.ReadBool();
		intercardinal_movement = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBool(horizontal_movement);
		s.WriteBool(vertical_movement);
		s.WriteBool(intercardinal_movement);

    }
}