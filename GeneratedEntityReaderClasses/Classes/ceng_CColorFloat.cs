namespace GeneratedNoitaClasses;
public class ceng_CColorFloat {
	public float r { get; set; }
	public float g { get; set; }
	public float b { get; set; }
	public float a { get; set; }

    public void Load(NoitaStream s){
		r = s.ReadBeFloat();
		g = s.ReadBeFloat();
		b = s.ReadBeFloat();
		a = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(r);
		s.WriteBeFloat(g);
		s.WriteBeFloat(b);
		s.WriteBeFloat(a);

    }
}