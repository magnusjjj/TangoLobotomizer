namespace GeneratedNoitaClasses;
public class PixelSpriteComponent{
	public string image_file{ get; set; }
	public int anchor_x{ get; set; }
	public int anchor_y{ get; set; }
	public string material{ get; set; }
	public bool diggable{ get; set; }
	public bool clean_overlapping_pixels{ get; set; }
	public bool kill_when_sprite_dies{ get; set; }
	public bool create_box2d_bodies{ get; set; }
	public object? mPixelSprite{ get; set; }

}