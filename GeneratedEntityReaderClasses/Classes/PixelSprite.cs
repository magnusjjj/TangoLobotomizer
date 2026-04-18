namespace GeneratedNoitaClasses;
public class PixelSprite :  iNoitaType<PixelSprite>{
	public NoitaString Number1 { get; set; } = new();
	public NoitaFloat Number2 { get; set; } = new();
	public NoitaFloat Number3 { get; set; } = new();
	public NoitaFloat Number4 { get; set; } = new();
	public NoitaFloat Number5 { get; set; } = new();
	public NoitaInt Number6 { get; set; } = new();
	public NoitaInt Number7 { get; set; } = new();
	public NoitaInt Number8 { get; set; } = new();
	public NoitaBool Number9 { get; set; } = new();
	public NoitaInt Number10 { get; set; } = new();
	public NoitaString Number11 { get; set; } = new();
	public NoitaSpecialTexture Number12 { get; set; } = new();

    public void Read(NoitaStream s){
		Number1.Read(s);
		Number2.Read(s);
		Number3.Read(s);
		Number4.Read(s);
		Number5.Read(s);
		Number6.Read(s);
		Number7.Read(s);
		Number8.Read(s);
		Number9.Read(s);
		Number10.Read(s);
		Number11.Read(s);
		Number12.Read(s);

    }
    public void Write(NoitaStream s){
		Number1.Write(s);
		Number2.Write(s);
		Number3.Write(s);
		Number4.Write(s);
		Number5.Write(s);
		Number6.Write(s);
		Number7.Write(s);
		Number8.Write(s);
		Number9.Write(s);
		Number10.Write(s);
		Number11.Write(s);
		Number12.Write(s);

    }
}