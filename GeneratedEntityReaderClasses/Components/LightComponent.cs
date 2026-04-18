namespace GeneratedNoitaClasses;
public class LightComponent : NoitaComponentBase,  iNoitaType<LightComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool update_properties { get; set; } = new();
	public NoitaFloat radius { get; set; } = new();
	public NoitaUInt r { get; set; } = new();
	public NoitaUInt g { get; set; } = new();
	public NoitaUInt b { get; set; } = new();
	public NoitaFloat offset_x { get; set; } = new();
	public NoitaFloat offset_y { get; set; } = new();
	public NoitaFloat fade_out_time { get; set; } = new();
	public NoitaFloat blinking_freq { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		update_properties.Read(s);
		radius.Read(s);
		r.Read(s);
		g.Read(s);
		b.Read(s);
		offset_x.Read(s);
		offset_y.Read(s);
		fade_out_time.Read(s);
		blinking_freq.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		update_properties.Write(s);
		radius.Write(s);
		r.Write(s);
		g.Write(s);
		b.Write(s);
		offset_x.Write(s);
		offset_y.Write(s);
		fade_out_time.Write(s);
		blinking_freq.Write(s);

    }
}