namespace GeneratedNoitaClasses;
public class KickComponent : NoitaComponentBase,  iNoitaType<KickComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool can_kick { get; set; } = new();
	public NoitaLensValue<NoitaFloat> max_force { get; set; } = new();
	public NoitaLensValue<NoitaFloat> player_kickforce { get; set; } = new();
	public NoitaFloat kick_radius { get; set; } = new();
	public NoitaLensValue<NoitaFloat> kick_damage { get; set; } = new();
	public NoitaLensValue<NoitaFloat> kick_knockback { get; set; } = new();
	public NoitaFloat telekinesis_throw_speed { get; set; } = new();
	public NoitaString kick_entities { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		can_kick.Read(s);
		max_force.Read(s);
		player_kickforce.Read(s);
		kick_radius.Read(s);
		kick_damage.Read(s);
		kick_knockback.Read(s);
		telekinesis_throw_speed.Read(s);
		kick_entities.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		can_kick.Write(s);
		max_force.Write(s);
		player_kickforce.Write(s);
		kick_radius.Write(s);
		kick_damage.Write(s);
		kick_knockback.Write(s);
		telekinesis_throw_speed.Write(s);
		kick_entities.Write(s);

    }
}