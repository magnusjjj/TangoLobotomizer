namespace GeneratedNoitaClasses;
public class StatusEffectDataComponent : NoitaComponentBase,  iNoitaType<StatusEffectDataComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaVector<NoitaFloat> stain_effects { get; set; } = new();
	public NoitaVector<NoitaInt> stain_effect_cooldowns { get; set; } = new();
	public NoitaVector<NoitaFloat> effects_previous { get; set; } = new();
	public NoitaVector<NoitaFloat> ingestion_effects { get; set; } = new();
	public NoitaVector<NoitaInt> ingestion_effect_causes { get; set; } = new();
	public NoitaVector<NoitaInt> ingestion_effect_causes_many { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		stain_effects.Read(s);
		stain_effect_cooldowns.Read(s);
		effects_previous.Read(s);
		ingestion_effects.Read(s);
		ingestion_effect_causes.Read(s);
		ingestion_effect_causes_many.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		stain_effects.Write(s);
		stain_effect_cooldowns.Write(s);
		effects_previous.Write(s);
		ingestion_effects.Write(s);
		ingestion_effect_causes.Write(s);
		ingestion_effect_causes_many.Write(s);

    }
}