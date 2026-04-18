namespace GeneratedNoitaClasses;
public class PixelSpriteComponent : NoitaComponentBase,  iNoitaType<PixelSpriteComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString image_file { get; set; } = new();
	public NoitaInt anchor_x { get; set; } = new();
	public NoitaInt anchor_y { get; set; } = new();
	public NoitaString material { get; set; } = new();
	public NoitaBool diggable { get; set; } = new();
	public NoitaBool clean_overlapping_pixels { get; set; } = new();
	public NoitaBool kill_when_sprite_dies { get; set; } = new();
	public NoitaBool create_box2d_bodies { get; set; } = new();
	public PixelSprite mPixelSprite { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		image_file.Read(s);
		anchor_x.Read(s);
		anchor_y.Read(s);
		material.Read(s);
		diggable.Read(s);
		clean_overlapping_pixels.Read(s);
		kill_when_sprite_dies.Read(s);
		create_box2d_bodies.Read(s);
		mPixelSprite.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		image_file.Write(s);
		anchor_x.Write(s);
		anchor_y.Write(s);
		material.Write(s);
		diggable.Write(s);
		clean_overlapping_pixels.Write(s);
		kill_when_sprite_dies.Write(s);
		create_box2d_bodies.Write(s);
		mPixelSprite.Write(s);

    }
}