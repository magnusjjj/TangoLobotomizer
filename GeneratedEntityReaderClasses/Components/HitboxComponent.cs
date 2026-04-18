namespace GeneratedNoitaClasses;
public class HitboxComponent : NoitaComponentBase,  iNoitaType<HitboxComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool is_player { get; set; } = new();
	public NoitaBool is_enemy { get; set; } = new();
	public NoitaBool is_item { get; set; } = new();
	public NoitaFloat aabb_min_x { get; set; } = new();
	public NoitaFloat aabb_max_x { get; set; } = new();
	public NoitaFloat aabb_min_y { get; set; } = new();
	public NoitaFloat aabb_max_y { get; set; } = new();
	public NoitaCVector2<NoitaFloat> offset { get; set; } = new();
	public NoitaFloat damage_multiplier { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		is_player.Read(s);
		is_enemy.Read(s);
		is_item.Read(s);
		aabb_min_x.Read(s);
		aabb_max_x.Read(s);
		aabb_min_y.Read(s);
		aabb_max_y.Read(s);
		offset.Read(s);
		damage_multiplier.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		is_player.Write(s);
		is_enemy.Write(s);
		is_item.Write(s);
		aabb_min_x.Write(s);
		aabb_max_x.Write(s);
		aabb_min_y.Write(s);
		aabb_max_y.Write(s);
		offset.Write(s);
		damage_multiplier.Write(s);

    }
}