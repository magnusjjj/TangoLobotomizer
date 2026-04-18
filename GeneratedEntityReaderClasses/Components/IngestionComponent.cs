namespace GeneratedNoitaClasses;
public class IngestionComponent : NoitaComponentBase,  iNoitaType<IngestionComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt64 ingestion_size { get; set; } = new();
	public NoitaInt64 ingestion_capacity { get; set; } = new();
	public NoitaUInt ingestion_cooldown_delay_frames { get; set; } = new();
	public NoitaUInt ingestion_reduce_every_n_frame { get; set; } = new();
	public NoitaFloat overingestion_damage { get; set; } = new();
	public NoitaFloat blood_healing_speed { get; set; } = new();
	public NoitaString ingestion_satiation_material_tag { get; set; } = new();
	public NoitaInt m_ingestion_cooldown_frames { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		ingestion_size.Read(s);
		ingestion_capacity.Read(s);
		ingestion_cooldown_delay_frames.Read(s);
		ingestion_reduce_every_n_frame.Read(s);
		overingestion_damage.Read(s);
		blood_healing_speed.Read(s);
		ingestion_satiation_material_tag.Read(s);
		m_ingestion_cooldown_frames.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		ingestion_size.Write(s);
		ingestion_capacity.Write(s);
		ingestion_cooldown_delay_frames.Write(s);
		ingestion_reduce_every_n_frame.Write(s);
		overingestion_damage.Write(s);
		blood_healing_speed.Write(s);
		ingestion_satiation_material_tag.Write(s);
		m_ingestion_cooldown_frames.Write(s);

    }
}