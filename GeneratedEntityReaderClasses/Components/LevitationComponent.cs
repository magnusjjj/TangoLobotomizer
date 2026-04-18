namespace GeneratedNoitaClasses;
public class LevitationComponent : NoitaComponentBase,  iNoitaType<LevitationComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaFloat entity_force { get; set; } = new();
	public NoitaFloat box2d_force { get; set; } = new();
	public NoitaInt effect_lifetime_frames { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		entity_force.Read(s);
		box2d_force.Read(s);
		effect_lifetime_frames.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		entity_force.Write(s);
		box2d_force.Write(s);
		effect_lifetime_frames.Write(s);

    }
}