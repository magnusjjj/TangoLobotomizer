namespace GeneratedNoitaClasses;
public class FishAIComponent : NoitaComponentBase,  iNoitaType<FishAIComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt direction { get; set; } = new();
	public NoitaFloat speed { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_min { get; set; } = new();
	public NoitaCVector2<NoitaFloat> aabb_max { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		direction.Read(s);
		speed.Read(s);
		aabb_min.Read(s);
		aabb_max.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		direction.Write(s);
		speed.Write(s);
		aabb_min.Write(s);
		aabb_max.Write(s);

    }
}