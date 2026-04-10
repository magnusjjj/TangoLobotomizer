namespace GeneratedNoitaClasses;
public class IngestionComponent {
	public Int64 ingestion_size { get; set; }
	public Int64 ingestion_capacity { get; set; }
	public UInt32 ingestion_cooldown_delay_frames { get; set; }
	public UInt32 ingestion_reduce_every_n_frame { get; set; }
	public float overingestion_damage { get; set; }
	public float blood_healing_speed { get; set; }
	public string ingestion_satiation_material_tag { get; set; }
	public Int32 m_ingestion_cooldown_frames { get; set; }

    public void Load(NoitaStream s){
		ingestion_size = s.ReadBeInt64();
		ingestion_capacity = s.ReadBeInt64();
		ingestion_cooldown_delay_frames = s.ReadBeUInt32();
		ingestion_reduce_every_n_frame = s.ReadBeUInt32();
		overingestion_damage = s.ReadBeFloat();
		blood_healing_speed = s.ReadBeFloat();
		ingestion_satiation_material_tag = s.ReadBeString();
		m_ingestion_cooldown_frames = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt64(ingestion_size);
		s.WriteBeInt64(ingestion_capacity);
		s.WriteBeUInt32(ingestion_cooldown_delay_frames);
		s.WriteBeUInt32(ingestion_reduce_every_n_frame);
		s.WriteBeFloat(overingestion_damage);
		s.WriteBeFloat(blood_healing_speed);
		s.WriteBeString(ingestion_satiation_material_tag);
		s.WriteBeInt32(m_ingestion_cooldown_frames);

    }
}