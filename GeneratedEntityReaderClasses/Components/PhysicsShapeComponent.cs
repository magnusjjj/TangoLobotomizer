namespace GeneratedNoitaClasses;
public class PhysicsShapeComponent : NoitaComponentBase,  iNoitaType<PhysicsShapeComponent>{
	public NoitaBool Deleted { get; set; } = new();
	public NoitaBool Enabled { get; set; } = new();
	public NoitaString Tags { get; set; } = new();
	public NoitaBool recreate { get; set; } = new();
	public NoitaBool is_circle { get; set; } = new();
	public NoitaBool is_box { get; set; } = new();
	public NoitaBool is_capsule { get; set; } = new();
	public NoitaBool is_based_on_sprite { get; set; } = new();
	public NoitaFloat friction { get; set; } = new();
	public NoitaFloat restitution { get; set; } = new();
	public NoitaFloat density { get; set; } = new();
	public NoitaFloat local_position_x { get; set; } = new();
	public NoitaFloat local_position_y { get; set; } = new();
	public NoitaFloat radius_x { get; set; } = new();
	public NoitaFloat radius_y { get; set; } = new();
	public NoitaFloat capsule_x_percent { get; set; } = new();
	public NoitaFloat capsule_y_percent { get; set; } = new();
	public NoitaInt material { get; set; } = new();

    public void Read(NoitaStream s){
		Deleted.Read(s);
		Enabled.Read(s);
		Tags.Read(s);
		recreate.Read(s);
		is_circle.Read(s);
		is_box.Read(s);
		is_capsule.Read(s);
		is_based_on_sprite.Read(s);
		friction.Read(s);
		restitution.Read(s);
		density.Read(s);
		local_position_x.Read(s);
		local_position_y.Read(s);
		radius_x.Read(s);
		radius_y.Read(s);
		capsule_x_percent.Read(s);
		capsule_y_percent.Read(s);
		material.Read(s);

    }
    public void Write(NoitaStream s){
		Deleted.Write(s);
		Enabled.Write(s);
		Tags.Write(s);
		recreate.Write(s);
		is_circle.Write(s);
		is_box.Write(s);
		is_capsule.Write(s);
		is_based_on_sprite.Write(s);
		friction.Write(s);
		restitution.Write(s);
		density.Write(s);
		local_position_x.Write(s);
		local_position_y.Write(s);
		radius_x.Write(s);
		radius_y.Write(s);
		capsule_x_percent.Write(s);
		capsule_y_percent.Write(s);
		material.Write(s);

    }
}