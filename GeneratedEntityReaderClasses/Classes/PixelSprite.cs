namespace GeneratedNoitaClasses;
public class PixelSprite {
	public string Number1 { get; set; }
	public float Number2 { get; set; }
	public float Number3 { get; set; }
	public float Number4 { get; set; }
	public float Number5 { get; set; }
	public Int32 Number6 { get; set; }
	public Int32 Number7 { get; set; }
	public Int32 Number8 { get; set; }
	public bool Number9 { get; set; }
	public Int32 Number10 { get; set; }
	public string Number11 { get; set; }
	public SpecialTexture Number12 { get; set; }

    public void Load(NoitaStream s){
		Number1 = s.ReadBeString();
		Number2 = s.ReadBeFloat();
		Number3 = s.ReadBeFloat();
		Number4 = s.ReadBeFloat();
		Number5 = s.ReadBeFloat();
		Number6 = s.ReadBeInt32();
		Number7 = s.ReadBeInt32();
		Number8 = s.ReadBeInt32();
		Number9 = s.ReadBool();
		Number10 = s.ReadBeInt32();
		Number11 = s.ReadBeString();
		Number12.Load(s);

    }
    public void Save(NoitaStream s){
		s.WriteBeString(Number1);
		s.WriteBeFloat(Number2);
		s.WriteBeFloat(Number3);
		s.WriteBeFloat(Number4);
		s.WriteBeFloat(Number5);
		s.WriteBeInt32(Number6);
		s.WriteBeInt32(Number7);
		s.WriteBeInt32(Number8);
		s.WriteBool(Number9);
		s.WriteBeInt32(Number10);
		s.WriteBeString(Number11);
		Number12.Write(s);

    }
}