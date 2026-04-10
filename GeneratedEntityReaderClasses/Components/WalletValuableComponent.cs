namespace GeneratedNoitaClasses;
public class WalletValuableComponent {
	public Int32 money_value { get; set; }

    public void Load(NoitaStream s){
		money_value = s.ReadBeInt32();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(money_value);

    }
}