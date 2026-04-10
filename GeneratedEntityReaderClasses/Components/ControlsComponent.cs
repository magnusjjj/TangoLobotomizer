namespace GeneratedNoitaClasses;
public class ControlsComponent {
	public bool polymorph_hax { get; set; }
	public Int32 polymorph_next_attack_frame { get; set; }
	public bool enabled { get; set; }
	public bool gamepad_indirect_aiming_enabled { get; set; }
	public bool gamepad_fire_on_thumbstick_extend { get; set; }
	public float gamepad_fire_on_thumbstick_extend_threshold { get; set; }

    public void Load(NoitaStream s){
		polymorph_hax = s.ReadBool();
		polymorph_next_attack_frame = s.ReadBeInt32();
		enabled = s.ReadBool();
		gamepad_indirect_aiming_enabled = s.ReadBool();
		gamepad_fire_on_thumbstick_extend = s.ReadBool();
		gamepad_fire_on_thumbstick_extend_threshold = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(polymorph_hax);
		s.WriteBeInt32(polymorph_next_attack_frame);
		s.WriteBool(enabled);
		s.WriteBool(gamepad_indirect_aiming_enabled);
		s.WriteBool(gamepad_fire_on_thumbstick_extend);
		s.WriteBeFloat(gamepad_fire_on_thumbstick_extend_threshold);

    }
}