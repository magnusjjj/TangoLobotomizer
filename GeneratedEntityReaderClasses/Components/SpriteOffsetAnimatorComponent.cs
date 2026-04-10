namespace GeneratedNoitaClasses;
public class SpriteOffsetAnimatorComponent {
	public float x_amount { get; set; }
	public float x_speed { get; set; }
	public float y_amount { get; set; }
	public float y_speed { get; set; }
	public Int32 sprite_id { get; set; }
	public float x_phase { get; set; }
	public float x_phase_offset { get; set; }

    public void Load(NoitaStream s){
		x_amount = s.ReadBeFloat();
		x_speed = s.ReadBeFloat();
		y_amount = s.ReadBeFloat();
		y_speed = s.ReadBeFloat();
		sprite_id = s.ReadBeInt32();
		x_phase = s.ReadBeFloat();
		x_phase_offset = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(x_amount);
		s.WriteBeFloat(x_speed);
		s.WriteBeFloat(y_amount);
		s.WriteBeFloat(y_speed);
		s.WriteBeInt32(sprite_id);
		s.WriteBeFloat(x_phase);
		s.WriteBeFloat(x_phase_offset);

    }
}