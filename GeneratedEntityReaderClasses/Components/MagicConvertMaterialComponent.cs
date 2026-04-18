namespace GeneratedNoitaClasses;
public class MagicConvertMaterialComponent : NoitaComponentBase,  iNoitaType<MagicConvertMaterialComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt radius { get; set; } = new();
	public NoitaInt min_radius { get; set; } = new();
	public NoitaBool is_circle { get; set; } = new();
	public NoitaInt steps_per_frame { get; set; } = new();
	public NoitaInt from_material { get; set; } = new();
	public NoitaString from_material_tag { get; set; } = new();
	public NoitaBool from_any_material { get; set; } = new();
	public NoitaInt to_material { get; set; } = new();
	public NoitaBool clean_stains { get; set; } = new();
	public NoitaBool extinguish_fire { get; set; } = new();
	public NoitaInt fan_the_flames { get; set; } = new();
	public NoitaInt temperature_reaction_temp { get; set; } = new();
	public NoitaInt ignite_materials { get; set; } = new();
	public NoitaBool loop { get; set; } = new();
	public NoitaBool kill_when_finished { get; set; } = new();
	public NoitaBool convert_entities { get; set; } = new();
	public NoitaBool stain_frozen { get; set; } = new();
	public NoitaFloat reaction_audio_amount { get; set; } = new();
	public NoitaBool convert_same_material { get; set; } = new();
	public NoitaString from_material_array { get; set; } = new();
	public NoitaString to_material_array { get; set; } = new();
	public NoitaInt mRadius { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		radius.Read(s);
		min_radius.Read(s);
		is_circle.Read(s);
		steps_per_frame.Read(s);
		from_material.Read(s);
		from_material_tag.Read(s);
		from_any_material.Read(s);
		to_material.Read(s);
		clean_stains.Read(s);
		extinguish_fire.Read(s);
		fan_the_flames.Read(s);
		temperature_reaction_temp.Read(s);
		ignite_materials.Read(s);
		loop.Read(s);
		kill_when_finished.Read(s);
		convert_entities.Read(s);
		stain_frozen.Read(s);
		reaction_audio_amount.Read(s);
		convert_same_material.Read(s);
		from_material_array.Read(s);
		to_material_array.Read(s);
		mRadius.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		radius.Write(s);
		min_radius.Write(s);
		is_circle.Write(s);
		steps_per_frame.Write(s);
		from_material.Write(s);
		from_material_tag.Write(s);
		from_any_material.Write(s);
		to_material.Write(s);
		clean_stains.Write(s);
		extinguish_fire.Write(s);
		fan_the_flames.Write(s);
		temperature_reaction_temp.Write(s);
		ignite_materials.Write(s);
		loop.Write(s);
		kill_when_finished.Write(s);
		convert_entities.Write(s);
		stain_frozen.Write(s);
		reaction_audio_amount.Write(s);
		convert_same_material.Write(s);
		from_material_array.Write(s);
		to_material_array.Write(s);
		mRadius.Write(s);

    }
}