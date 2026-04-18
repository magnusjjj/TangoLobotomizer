namespace GeneratedNoitaClasses;
public class TeleportComponent : NoitaComponentBase,  iNoitaType<TeleportComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaCVector2<NoitaFloat> target { get; set; } = new();
	public NoitaBool target_x_is_absolute_position { get; set; } = new();
	public NoitaBool target_y_is_absolute_position { get; set; } = new();
	public NoitaString source_particle_fx_file { get; set; } = new();
	public NoitaString target_particle_fx_file { get; set; } = new();
	public NoitaBool load_collapse_entity { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		target.Read(s);
		target_x_is_absolute_position.Read(s);
		target_y_is_absolute_position.Read(s);
		source_particle_fx_file.Read(s);
		target_particle_fx_file.Read(s);
		load_collapse_entity.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		target.Write(s);
		target_x_is_absolute_position.Write(s);
		target_y_is_absolute_position.Write(s);
		source_particle_fx_file.Write(s);
		target_particle_fx_file.Write(s);
		load_collapse_entity.Write(s);

    }
}