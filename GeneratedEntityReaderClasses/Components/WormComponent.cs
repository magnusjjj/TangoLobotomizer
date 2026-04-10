namespace GeneratedNoitaClasses;
public class WormComponent {
	public float speed { get; set; }
	public float acceleration { get; set; }
	public LensValue<float> ground_decceleration { get; set; }
	public float gravity { get; set; }
	public float tail_gravity { get; set; }
	public float part_distance { get; set; }
	public Int32 ground_check_offset { get; set; }
	public float hitbox_radius { get; set; }
	public float bite_damage { get; set; }
	public float target_kill_radius { get; set; }
	public float target_kill_ragdoll_force { get; set; }
	public float jump_cam_shake { get; set; }
	public float jump_cam_shake_distance { get; set; }
	public float eat_anim_wait_mult { get; set; }
	public string ragdoll_filename { get; set; }
	public bool is_water_worm { get; set; }
	public float max_speed { get; set; }

    public void Load(NoitaStream s){
		speed = s.ReadBeFloat();
		acceleration = s.ReadBeFloat();
		ground_decceleration.Load(s);
		gravity = s.ReadBeFloat();
		tail_gravity = s.ReadBeFloat();
		part_distance = s.ReadBeFloat();
		ground_check_offset = s.ReadBeInt32();
		hitbox_radius = s.ReadBeFloat();
		bite_damage = s.ReadBeFloat();
		target_kill_radius = s.ReadBeFloat();
		target_kill_ragdoll_force = s.ReadBeFloat();
		jump_cam_shake = s.ReadBeFloat();
		jump_cam_shake_distance = s.ReadBeFloat();
		eat_anim_wait_mult = s.ReadBeFloat();
		ragdoll_filename = s.ReadBeString();
		is_water_worm = s.ReadBool();
		max_speed = s.ReadBeFloat();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(speed);
		s.WriteBeFloat(acceleration);
		ground_decceleration.Write(s);
		s.WriteBeFloat(gravity);
		s.WriteBeFloat(tail_gravity);
		s.WriteBeFloat(part_distance);
		s.WriteBeInt32(ground_check_offset);
		s.WriteBeFloat(hitbox_radius);
		s.WriteBeFloat(bite_damage);
		s.WriteBeFloat(target_kill_radius);
		s.WriteBeFloat(target_kill_ragdoll_force);
		s.WriteBeFloat(jump_cam_shake);
		s.WriteBeFloat(jump_cam_shake_distance);
		s.WriteBeFloat(eat_anim_wait_mult);
		s.WriteBeString(ragdoll_filename);
		s.WriteBool(is_water_worm);
		s.WriteBeFloat(max_speed);

    }
}