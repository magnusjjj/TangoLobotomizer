namespace GeneratedNoitaClasses;
public class KickComponent {
	public bool can_kick { get; set; }
	public LensValue<float> max_force { get; set; }
	public LensValue<float> player_kickforce { get; set; }
	public float kick_radius { get; set; }
	public LensValue<float> kick_damage { get; set; }
	public LensValue<float> kick_knockback { get; set; }
	public float telekinesis_throw_speed { get; set; }
	public string kick_entities { get; set; }

    public void Load(NoitaStream s){
		can_kick = s.ReadBool();
		max_force.Load(s);
		player_kickforce.Load(s);
		kick_radius = s.ReadBeFloat();
		kick_damage.Load(s);
		kick_knockback.Load(s);
		telekinesis_throw_speed = s.ReadBeFloat();
		kick_entities = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBool(can_kick);
		max_force.Write(s);
		player_kickforce.Write(s);
		s.WriteBeFloat(kick_radius);
		kick_damage.Write(s);
		kick_knockback.Write(s);
		s.WriteBeFloat(telekinesis_throw_speed);
		s.WriteBeString(kick_entities);

    }
}