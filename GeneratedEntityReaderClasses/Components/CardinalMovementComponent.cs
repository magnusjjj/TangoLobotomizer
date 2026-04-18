namespace GeneratedNoitaClasses;
public class CardinalMovementComponent : NoitaComponentBase,  iNoitaType<CardinalMovementComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool horizontal_movement { get; set; } = new();
	public NoitaBool vertical_movement { get; set; } = new();
	public NoitaBool intercardinal_movement { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		horizontal_movement.Read(s);
		vertical_movement.Read(s);
		intercardinal_movement.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		horizontal_movement.Write(s);
		vertical_movement.Write(s);
		intercardinal_movement.Write(s);

    }
}