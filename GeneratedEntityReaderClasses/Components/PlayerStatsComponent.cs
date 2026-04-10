namespace GeneratedNoitaClasses;
public class PlayerStatsComponent {
	public Int32 lives { get; set; }
	public float max_hp { get; set; }
	public float speed { get; set; }

    public void Load(NoitaStream s){
		lives = s.ReadBeInt32();
		max_hp = s.ReadBeFloat();
		speed = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(lives);
		s.WriteBeFloat(max_hp);
		s.WriteBeFloat(speed);

    }
}