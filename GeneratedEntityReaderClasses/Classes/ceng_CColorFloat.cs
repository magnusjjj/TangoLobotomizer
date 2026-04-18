namespace GeneratedNoitaClasses;
public class ceng_CColorFloat :  iNoitaType<ceng_CColorFloat>{
	public NoitaFloat r { get; set; } = new();
	public NoitaFloat g { get; set; } = new();
	public NoitaFloat b { get; set; } = new();
	public NoitaFloat a { get; set; } = new();

    public void Read(NoitaStream s){
		r.Read(s);
		g.Read(s);
		b.Read(s);
		a.Read(s);

    }
    public void Write(NoitaStream s){
		r.Write(s);
		g.Write(s);
		b.Write(s);
		a.Write(s);

    }
}