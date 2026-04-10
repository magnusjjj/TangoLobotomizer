namespace GeneratedNoitaClasses;
public class TeleportComponent {
	public CVector2<float> target { get; set; }
	public bool target_x_is_absolute_position { get; set; }
	public bool target_y_is_absolute_position { get; set; }
	public string source_particle_fx_file { get; set; }
	public string target_particle_fx_file { get; set; }
	public bool load_collapse_entity { get; set; }

    public void Load(NoitaStream s){
		target.Load(s);
		target_x_is_absolute_position = s.ReadBool();
		target_y_is_absolute_position = s.ReadBool();
		source_particle_fx_file = s.ReadBeString();
		target_particle_fx_file = s.ReadBeString();
		load_collapse_entity = s.ReadBool();

    }
    public void Save(NoitaStream s){
		target.Write(s);
		s.WriteBool(target_x_is_absolute_position);
		s.WriteBool(target_y_is_absolute_position);
		s.WriteBeString(source_particle_fx_file);
		s.WriteBeString(target_particle_fx_file);
		s.WriteBool(load_collapse_entity);

    }
}