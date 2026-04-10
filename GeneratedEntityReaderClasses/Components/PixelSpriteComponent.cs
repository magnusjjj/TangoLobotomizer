namespace GeneratedNoitaClasses;
public class PixelSpriteComponent {
	public string image_file { get; set; }
	public Int32 anchor_x { get; set; }
	public Int32 anchor_y { get; set; }
	public string material { get; set; }
	public bool diggable { get; set; }
	public bool clean_overlapping_pixels { get; set; }
	public bool kill_when_sprite_dies { get; set; }
	public bool create_box2d_bodies { get; set; }
	public PixelSprite mPixelSprite { get; set; }

    public void Load(NoitaStream s){
		image_file = s.ReadBeString();
		anchor_x = s.ReadBeInt32();
		anchor_y = s.ReadBeInt32();
		material = s.ReadBeString();
		diggable = s.ReadBool();
		clean_overlapping_pixels = s.ReadBool();
		kill_when_sprite_dies = s.ReadBool();
		create_box2d_bodies = s.ReadBool();
		mPixelSprite.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeString(image_file);
		s.WriteBeInt32(anchor_x);
		s.WriteBeInt32(anchor_y);
		s.WriteBeString(material);
		s.WriteBool(diggable);
		s.WriteBool(clean_overlapping_pixels);
		s.WriteBool(kill_when_sprite_dies);
		s.WriteBool(create_box2d_bodies);
		mPixelSprite.Write(s);

    }
}