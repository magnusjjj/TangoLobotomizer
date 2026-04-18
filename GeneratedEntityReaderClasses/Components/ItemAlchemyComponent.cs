namespace GeneratedNoitaClasses;
public class ItemAlchemyComponent : NoitaComponentBase,  iNoitaType<ItemAlchemyComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt material_make_always_cast { get; set; } = new();
	public NoitaInt material_remove_shuffle { get; set; } = new();
	public NoitaInt material_animate_wand { get; set; } = new();
	public NoitaInt material_animate_wand_alt { get; set; } = new();
	public NoitaInt material_increase_uses_remaining { get; set; } = new();
	public NoitaInt material_sacrifice { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		material_make_always_cast.Read(s);
		material_remove_shuffle.Read(s);
		material_animate_wand.Read(s);
		material_animate_wand_alt.Read(s);
		material_increase_uses_remaining.Read(s);
		material_sacrifice.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		material_make_always_cast.Write(s);
		material_remove_shuffle.Write(s);
		material_animate_wand.Write(s);
		material_animate_wand_alt.Write(s);
		material_increase_uses_remaining.Write(s);
		material_sacrifice.Write(s);

    }
}