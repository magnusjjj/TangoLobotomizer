namespace GeneratedNoitaClasses;
public class StatusEffectDataComponent {
	public List<float> stain_effects { get; set; }
	public List<int> stain_effect_cooldowns { get; set; }
	public List<float> effects_previous { get; set; }
	public List<float> ingestion_effects { get; set; }
	public List<int> ingestion_effect_causes { get; set; }
	public List<int> ingestion_effect_causes_many { get; set; }

    public void Load(NoitaStream s){
		stain_effects = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 stain_effects.Add(float.Load(s));
}
		stain_effect_cooldowns = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 stain_effect_cooldowns.Add(int.Load(s));
}
		effects_previous = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 effects_previous.Add(float.Load(s));
}
		ingestion_effects = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 ingestion_effects.Add(float.Load(s));
}
		ingestion_effect_causes = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 ingestion_effect_causes.Add(int.Load(s));
}
		ingestion_effect_causes_many = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 ingestion_effect_causes_many.Add(int.Load(s));
}

    }
    public void Save(NoitaStream s){
		s.WriteBeUInt32(stain_effects.Length);
foreach(var item in stain_effects){ stain_effects.Write(s);
}
		s.WriteBeUInt32(stain_effect_cooldowns.Length);
foreach(var item in stain_effect_cooldowns){ stain_effect_cooldowns.Write(s);
}
		s.WriteBeUInt32(effects_previous.Length);
foreach(var item in effects_previous){ effects_previous.Write(s);
}
		s.WriteBeUInt32(ingestion_effects.Length);
foreach(var item in ingestion_effects){ ingestion_effects.Write(s);
}
		s.WriteBeUInt32(ingestion_effect_causes.Length);
foreach(var item in ingestion_effect_causes){ ingestion_effect_causes.Write(s);
}
		s.WriteBeUInt32(ingestion_effect_causes_many.Length);
foreach(var item in ingestion_effect_causes_many){ ingestion_effect_causes_many.Write(s);
}

    }
}