namespace GeneratedNoitaClasses;
public class GameLogComponent {
	public bool report_death { get; set; }
	public bool report_damage { get; set; }
	public bool report_new_biomes { get; set; }
	public List<string> mVisitiedBiomes { get; set; }

    public void Load(NoitaStream s){
		report_death = s.ReadBool();
		report_damage = s.ReadBool();
		report_new_biomes = s.ReadBool();
		mVisitiedBiomes = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 mVisitiedBiomes.Add(string.Load(s));
}

    }
    public void Save(NoitaStream s){
		s.WriteBool(report_death);
		s.WriteBool(report_damage);
		s.WriteBool(report_new_biomes);
		s.WriteBeUInt32(mVisitiedBiomes.Length);
foreach(var item in mVisitiedBiomes){ mVisitiedBiomes.Write(s);
}

    }
}