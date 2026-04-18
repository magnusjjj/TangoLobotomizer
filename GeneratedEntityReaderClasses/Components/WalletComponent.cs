namespace GeneratedNoitaClasses;
public class WalletComponent : NoitaComponentBase,  iNoitaType<WalletComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaInt64 money { get; set; } = new();
	public NoitaInt64 money_spent { get; set; } = new();
	public NoitaInt64 mMoneyPrevFrame { get; set; } = new();
	public NoitaBool mHasReachedInf { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		money.Read(s);
		money_spent.Read(s);
		mMoneyPrevFrame.Read(s);
		mHasReachedInf.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		money.Write(s);
		money_spent.Write(s);
		mMoneyPrevFrame.Write(s);
		mHasReachedInf.Write(s);

    }
}