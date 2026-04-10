namespace GeneratedNoitaClasses;
public class LightComponent {
	public bool update_properties { get; set; }
	public float radius { get; set; }
	public UInt32 r { get; set; }
	public UInt32 g { get; set; }
	public UInt32 b { get; set; }
	public float offset_x { get; set; }
	public float offset_y { get; set; }
	public float fade_out_time { get; set; }
	public float blinking_freq { get; set; }

    public void Load(NoitaStream s){
		update_properties = s.ReadBool();
		radius = s.ReadBeFloat();
		r = s.ReadBeUInt32();
		g = s.ReadBeUInt32();
		b = s.ReadBeUInt32();
		offset_x = s.ReadBeFloat();
		offset_y = s.ReadBeFloat();
		fade_out_time = s.ReadBeFloat();
		blinking_freq = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBool(update_properties);
		s.WriteBeFloat(radius);
		s.WriteBeUInt32(r);
		s.WriteBeUInt32(g);
		s.WriteBeUInt32(b);
		s.WriteBeFloat(offset_x);
		s.WriteBeFloat(offset_y);
		s.WriteBeFloat(fade_out_time);
		s.WriteBeFloat(blinking_freq);

    }
}