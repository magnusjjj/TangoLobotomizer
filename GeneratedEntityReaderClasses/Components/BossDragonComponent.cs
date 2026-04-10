namespace GeneratedNoitaClasses;
public class BossDragonComponent {
	public float speed { get; set; }
	public float speed_hunt { get; set; }
	public float acceleration { get; set; }
	public float direction_adjust_speed { get; set; }
	public float direction_adjust_speed_hunt { get; set; }
	public float gravity { get; set; }
	public float tail_gravity { get; set; }
	public float part_distance { get; set; }
	public Int32 ground_check_offset { get; set; }
	public float eat_ground_radius { get; set; }
	public bool eat_ground { get; set; }
	public float hitbox_radius { get; set; }
	public float bite_damage { get; set; }
	public float target_kill_radius { get; set; }
	public float target_kill_ragdoll_force { get; set; }
	public float hunt_box_radius { get; set; }
	public float random_target_box_radius { get; set; }
	public Int32 new_hunt_target_check_every { get; set; }
	public Int32 new_random_target_check_every { get; set; }
	public float jump_cam_shake { get; set; }
	public float jump_cam_shake_distance { get; set; }
	public float eat_anim_wait_mult { get; set; }
	public string projectile_1 { get; set; }
	public Int32 projectile_1_count { get; set; }
	public string projectile_2 { get; set; }
	public Int32 projectile_2_count { get; set; }
	public string ragdoll_filename { get; set; }

    public void Load(NoitaStream s){
		speed = s.ReadBeFloat();
		speed_hunt = s.ReadBeFloat();
		acceleration = s.ReadBeFloat();
		direction_adjust_speed = s.ReadBeFloat();
		direction_adjust_speed_hunt = s.ReadBeFloat();
		gravity = s.ReadBeFloat();
		tail_gravity = s.ReadBeFloat();
		part_distance = s.ReadBeFloat();
		ground_check_offset = s.ReadBeInt32();
		eat_ground_radius = s.ReadBeFloat();
		eat_ground = s.ReadBool();
		hitbox_radius = s.ReadBeFloat();
		bite_damage = s.ReadBeFloat();
		target_kill_radius = s.ReadBeFloat();
		target_kill_ragdoll_force = s.ReadBeFloat();
		hunt_box_radius = s.ReadBeFloat();
		random_target_box_radius = s.ReadBeFloat();
		new_hunt_target_check_every = s.ReadBeInt32();
		new_random_target_check_every = s.ReadBeInt32();
		jump_cam_shake = s.ReadBeFloat();
		jump_cam_shake_distance = s.ReadBeFloat();
		eat_anim_wait_mult = s.ReadBeFloat();
		projectile_1 = s.ReadBeString();
		projectile_1_count = s.ReadBeInt32();
		projectile_2 = s.ReadBeString();
		projectile_2_count = s.ReadBeInt32();
		ragdoll_filename = s.ReadBeString();

    }
    public void Save(NoitaStream s){
		s.WriteBeFloat(speed);
		s.WriteBeFloat(speed_hunt);
		s.WriteBeFloat(acceleration);
		s.WriteBeFloat(direction_adjust_speed);
		s.WriteBeFloat(direction_adjust_speed_hunt);
		s.WriteBeFloat(gravity);
		s.WriteBeFloat(tail_gravity);
		s.WriteBeFloat(part_distance);
		s.WriteBeInt32(ground_check_offset);
		s.WriteBeFloat(eat_ground_radius);
		s.WriteBool(eat_ground);
		s.WriteBeFloat(hitbox_radius);
		s.WriteBeFloat(bite_damage);
		s.WriteBeFloat(target_kill_radius);
		s.WriteBeFloat(target_kill_ragdoll_force);
		s.WriteBeFloat(hunt_box_radius);
		s.WriteBeFloat(random_target_box_radius);
		s.WriteBeInt32(new_hunt_target_check_every);
		s.WriteBeInt32(new_random_target_check_every);
		s.WriteBeFloat(jump_cam_shake);
		s.WriteBeFloat(jump_cam_shake_distance);
		s.WriteBeFloat(eat_anim_wait_mult);
		s.WriteBeString(projectile_1);
		s.WriteBeInt32(projectile_1_count);
		s.WriteBeString(projectile_2);
		s.WriteBeInt32(projectile_2_count);
		s.WriteBeString(ragdoll_filename);

    }
}