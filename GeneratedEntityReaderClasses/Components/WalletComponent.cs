namespace GeneratedNoitaClasses;
public class WalletComponent {
	public Int64 money { get; set; }
	public Int64 money_spent { get; set; }
	public Int64 mMoneyPrevFrame { get; set; }
	public bool mHasReachedInf { get; set; }

    public void Load(NoitaStream s){
		money = s.ReadBeInt64();
		money_spent = s.ReadBeInt64();
		mMoneyPrevFrame = s.ReadBeInt64();
		mHasReachedInf = s.ReadBool();

    }
    public void Save(NoitaStream s){
		s.WriteBeInt64(money);
		s.WriteBeInt64(money_spent);
		s.WriteBeInt64(mMoneyPrevFrame);
		s.WriteBool(mHasReachedInf);

    }
}