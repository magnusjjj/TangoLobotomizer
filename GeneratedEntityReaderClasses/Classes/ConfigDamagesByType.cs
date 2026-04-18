namespace GeneratedNoitaClasses;
public class ConfigDamagesByType :  iNoitaType<ConfigDamagesByType>{
	public NoitaFloat melee { get; set; } = new();
	public NoitaFloat projectile { get; set; } = new();
	public NoitaFloat explosion { get; set; } = new();
	public NoitaFloat electricity { get; set; } = new();
	public NoitaFloat fire { get; set; } = new();
	public NoitaFloat drill { get; set; } = new();
	public NoitaFloat slice { get; set; } = new();
	public NoitaFloat ice { get; set; } = new();
	public NoitaFloat healing { get; set; } = new();
	public NoitaFloat physics_hit { get; set; } = new();
	public NoitaFloat radioactive { get; set; } = new();
	public NoitaFloat poison { get; set; } = new();
	public NoitaFloat overeating { get; set; } = new();
	public NoitaFloat curse { get; set; } = new();
	public NoitaFloat holy { get; set; } = new();

    public void Read(NoitaStream s){
		melee.Read(s);
		projectile.Read(s);
		explosion.Read(s);
		electricity.Read(s);
		fire.Read(s);
		drill.Read(s);
		slice.Read(s);
		ice.Read(s);
		healing.Read(s);
		physics_hit.Read(s);
		radioactive.Read(s);
		poison.Read(s);
		overeating.Read(s);
		curse.Read(s);
		holy.Read(s);

    }
    public void Write(NoitaStream s){
		melee.Write(s);
		projectile.Write(s);
		explosion.Write(s);
		electricity.Write(s);
		fire.Write(s);
		drill.Write(s);
		slice.Write(s);
		ice.Write(s);
		healing.Write(s);
		physics_hit.Write(s);
		radioactive.Write(s);
		poison.Write(s);
		overeating.Write(s);
		curse.Write(s);
		holy.Write(s);

    }
}