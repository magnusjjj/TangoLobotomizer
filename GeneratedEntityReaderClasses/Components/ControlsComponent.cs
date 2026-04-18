namespace GeneratedNoitaClasses;
public class ControlsComponent : NoitaComponentBase,  iNoitaType<ControlsComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool polymorph_hax { get; set; } = new();
	public NoitaInt polymorph_next_attack_frame { get; set; } = new();
	public NoitaBool enabled { get; set; } = new();
	public NoitaBool gamepad_indirect_aiming_enabled { get; set; } = new();
	public NoitaBool gamepad_fire_on_thumbstick_extend { get; set; } = new();
	public NoitaFloat gamepad_fire_on_thumbstick_extend_threshold { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		polymorph_hax.Read(s);
		polymorph_next_attack_frame.Read(s);
		enabled.Read(s);
		gamepad_indirect_aiming_enabled.Read(s);
		gamepad_fire_on_thumbstick_extend.Read(s);
		gamepad_fire_on_thumbstick_extend_threshold.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		polymorph_hax.Write(s);
		polymorph_next_attack_frame.Write(s);
		enabled.Write(s);
		gamepad_indirect_aiming_enabled.Write(s);
		gamepad_fire_on_thumbstick_extend.Write(s);
		gamepad_fire_on_thumbstick_extend_threshold.Write(s);

    }
}