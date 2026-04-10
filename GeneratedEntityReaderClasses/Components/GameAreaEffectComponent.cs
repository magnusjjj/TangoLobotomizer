namespace GeneratedNoitaClasses;
public class GameAreaEffectComponent {
	public float radius { get; set; }
	public string collide_with_tag { get; set; }
	public Int32 frame_length { get; set; }
	public List<string> game_effect_entitities { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeFloat();
		collide_with_tag = s.ReadBeString();
		frame_length = s.ReadBeInt32();
		game_effect_entitities = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 game_effect_entitities.Add(string.Load(s));
}

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(radius);
		s.WriteBeString(collide_with_tag);
		s.WriteBeInt32(frame_length);
		s.WriteBeUInt32(game_effect_entitities.Length);
foreach(var item in game_effect_entitities){ game_effect_entitities.Write(s);
}

    }
}