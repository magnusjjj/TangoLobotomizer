namespace GeneratedNoitaClasses;
public class PixelSceneComponent {
	public string pixel_scene { get; set; }
	public string pixel_scene_visual { get; set; }
	public string pixel_scene_background { get; set; }
	public Int32 background_z_index { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }
	public bool skip_biome_checks { get; set; }
	public bool skip_edge_textures { get; set; }

    public void Load(NoitaStream s){
		pixel_scene = s.ReadBeString();
		pixel_scene_visual = s.ReadBeString();
		pixel_scene_background = s.ReadBeString();
		background_z_index = s.ReadBeInt32();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();
		skip_biome_checks = s.ReadBool();
		skip_edge_textures = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeString(pixel_scene);
		s.WriteBeString(pixel_scene_visual);
		s.WriteBeString(pixel_scene_background);
		s.WriteBeInt32(background_z_index);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);
		s.WriteBool(skip_biome_checks);
		s.WriteBool(skip_edge_textures);

    }
}