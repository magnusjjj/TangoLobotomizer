namespace GeneratedNoitaClasses;
public class HitboxComponent{
	public bool is_player{ get; set; }
	public bool is_enemy{ get; set; }
	public bool is_item{ get; set; }
	public float aabb_min_x{ get; set; }
	public float aabb_max_x{ get; set; }
	public float aabb_min_y{ get; set; }
	public float aabb_max_y{ get; set; }
	public List<float> offset{ get; set; }
	public float damage_multiplier{ get; set; }

}