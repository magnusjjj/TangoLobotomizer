namespace GeneratedNoitaClasses;
public class SpriteOffsetAnimatorComponent : NoitaComponentBase,  iNoitaType<SpriteOffsetAnimatorComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat x_amount { get; set; } = new();
	public NoitaFloat x_speed { get; set; } = new();
	public NoitaFloat y_amount { get; set; } = new();
	public NoitaFloat y_speed { get; set; } = new();
	public NoitaInt sprite_id { get; set; } = new();
	public NoitaFloat x_phase { get; set; } = new();
	public NoitaFloat x_phase_offset { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		x_amount.Read(s);
		x_speed.Read(s);
		y_amount.Read(s);
		y_speed.Read(s);
		sprite_id.Read(s);
		x_phase.Read(s);
		x_phase_offset.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		x_amount.Write(s);
		x_speed.Write(s);
		y_amount.Write(s);
		y_speed.Write(s);
		sprite_id.Write(s);
		x_phase.Write(s);
		x_phase_offset.Write(s);

    }
}