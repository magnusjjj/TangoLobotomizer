namespace GeneratedNoitaClasses;
public class PathFindingJumpParams :  iNoitaType<PathFindingJumpParams>{
	public NoitaFloat x { get; set; } = new();
	public NoitaFloat y { get; set; } = new();
	public NoitaFloat lob { get; set; } = new();

    public void Read(NoitaStream s){
		x.Read(s);
		y.Read(s);
		lob.Read(s);

    }
    public void Write(NoitaStream s){
		x.Write(s);
		y.Write(s);
		lob.Write(s);

    }
}