namespace GeneratedNoitaClasses;
public class MagicConvertMaterialComponent {
	public Int32 radius { get; set; }
	public Int32 min_radius { get; set; }
	public bool is_circle { get; set; }
	public Int32 steps_per_frame { get; set; }
	public Int32 from_material { get; set; }
	public string from_material_tag { get; set; }
	public bool from_any_material { get; set; }
	public Int32 to_material { get; set; }
	public bool clean_stains { get; set; }
	public bool extinguish_fire { get; set; }
	public Int32 fan_the_flames { get; set; }
	public Int32 temperature_reaction_temp { get; set; }
	public Int32 ignite_materials { get; set; }
	public bool loop { get; set; }
	public bool kill_when_finished { get; set; }
	public bool convert_entities { get; set; }
	public bool stain_frozen { get; set; }
	public float reaction_audio_amount { get; set; }
	public bool convert_same_material { get; set; }
	public string from_material_array { get; set; }
	public string to_material_array { get; set; }
	public Int32 mRadius { get; set; }

    public void Load(NoitaStream s){
		radius = s.ReadBeInt32();
		min_radius = s.ReadBeInt32();
		is_circle = s.ReadBool();
		steps_per_frame = s.ReadBeInt32();
		from_material = s.ReadBeInt32();
		from_material_tag = s.ReadBeString();
		from_any_material = s.ReadBool();
		to_material = s.ReadBeInt32();
		clean_stains = s.ReadBool();
		extinguish_fire = s.ReadBool();
		fan_the_flames = s.ReadBeInt32();
		temperature_reaction_temp = s.ReadBeInt32();
		ignite_materials = s.ReadBeInt32();
		loop = s.ReadBool();
		kill_when_finished = s.ReadBool();
		convert_entities = s.ReadBool();
		stain_frozen = s.ReadBool();
		reaction_audio_amount = s.ReadBeFloat();
		convert_same_material = s.ReadBool();
		from_material_array = s.ReadBeString();
		to_material_array = s.ReadBeString();
		mRadius = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(radius);
		s.WriteBeInt32(min_radius);
		s.WriteBool(is_circle);
		s.WriteBeInt32(steps_per_frame);
		s.WriteBeInt32(from_material);
		s.WriteBeString(from_material_tag);
		s.WriteBool(from_any_material);
		s.WriteBeInt32(to_material);
		s.WriteBool(clean_stains);
		s.WriteBool(extinguish_fire);
		s.WriteBeInt32(fan_the_flames);
		s.WriteBeInt32(temperature_reaction_temp);
		s.WriteBeInt32(ignite_materials);
		s.WriteBool(loop);
		s.WriteBool(kill_when_finished);
		s.WriteBool(convert_entities);
		s.WriteBool(stain_frozen);
		s.WriteBeFloat(reaction_audio_amount);
		s.WriteBool(convert_same_material);
		s.WriteBeString(from_material_array);
		s.WriteBeString(to_material_array);
		s.WriteBeInt32(mRadius);

    }
}