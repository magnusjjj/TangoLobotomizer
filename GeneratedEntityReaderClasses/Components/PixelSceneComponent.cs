namespace GeneratedNoitaClasses;
public class PixelSceneComponent : NoitaComponentBase,  iNoitaType<PixelSceneComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaString pixel_scene { get; set; } = new();
	public NoitaString pixel_scene_visual { get; set; } = new();
	public NoitaString pixel_scene_background { get; set; } = new();
	public NoitaInt background_z_index { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();
	public NoitaBool skip_biome_checks { get; set; } = new();
	public NoitaBool skip_edge_textures { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		pixel_scene.Read(s);
		pixel_scene_visual.Read(s);
		pixel_scene_background.Read(s);
		background_z_index.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		skip_biome_checks.Read(s);
		skip_edge_textures.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		pixel_scene.Write(s);
		pixel_scene_visual.Write(s);
		pixel_scene_background.Write(s);
		background_z_index.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		skip_biome_checks.Write(s);
		skip_edge_textures.Write(s);

    }
}