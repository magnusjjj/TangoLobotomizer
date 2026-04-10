namespace GeneratedNoitaClasses;
public class HitboxComponent {
	public bool is_player { get; set; }
	public bool is_enemy { get; set; }
	public bool is_item { get; set; }
	public float aabb_min_x { get; set; }
	public float aabb_max_x { get; set; }
	public float aabb_min_y { get; set; }
	public float aabb_max_y { get; set; }
	public CVector2<float> offset { get; set; }
	public float damage_multiplier { get; set; }

    public void Load(NoitaStream s){
		is_player = s.ReadBool();
		is_enemy = s.ReadBool();
		is_item = s.ReadBool();
		aabb_min_x = s.ReadBeFloat();
		aabb_max_x = s.ReadBeFloat();
		aabb_min_y = s.ReadBeFloat();
		aabb_max_y = s.ReadBeFloat();
		offset.Load(s);
		damage_multiplier = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(is_player);
		s.WriteBool(is_enemy);
		s.WriteBool(is_item);
		s.WriteBeFloat(aabb_min_x);
		s.WriteBeFloat(aabb_max_x);
		s.WriteBeFloat(aabb_min_y);
		s.WriteBeFloat(aabb_max_y);
		offset.Write(s);
		s.WriteBeFloat(damage_multiplier);

    }
}