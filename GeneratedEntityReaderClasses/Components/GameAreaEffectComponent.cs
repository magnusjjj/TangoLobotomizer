namespace GeneratedNoitaClasses;
public class GameAreaEffectComponent : NoitaComponentBase,  iNoitaType<GameAreaEffectComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaString collide_with_tag { get; set; } = new();
	public NoitaInt frame_length { get; set; } = new();
	public NoitaVector<NoitaString> game_effect_entitities { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		collide_with_tag.Read(s);
		frame_length.Read(s);
		game_effect_entitities.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		collide_with_tag.Write(s);
		frame_length.Write(s);
		game_effect_entitities.Write(s);

    }
}