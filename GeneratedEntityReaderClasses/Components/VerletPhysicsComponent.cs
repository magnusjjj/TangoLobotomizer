namespace GeneratedNoitaClasses;
public class VerletPhysicsComponent {
	public Int32 num_points { get; set; }
	public Int32 num_links { get; set; }
	public Int32 width { get; set; }
	public UInt32 type { get; set; }
	public float resting_distance { get; set; }
	public float mass_min { get; set; }
	public float mass_max { get; set; }
	public float stiffness { get; set; }
	public float velocity_dampening { get; set; }
	public float liquid_damping { get; set; }
	public float gets_entity_velocity_coeff { get; set; }
	public bool collide_with_cells { get; set; }
	public bool simulate_gravity { get; set; }
	public bool simulate_wind { get; set; }
	public float wind_change_speed { get; set; }
	public bool constrain_stretching { get; set; }
	public bool pixelate_sprite_transforms { get; set; }
	public bool scale_sprite_x { get; set; }
	public bool follow_entity_transform { get; set; }
	public CVector2<float> animation_target_offset { get; set; }
	public float animation_amount { get; set; }
	public float animation_speed { get; set; }
	public float animation_energy { get; set; }
	public float cloth_sprite_z_index { get; set; }
	public Int32 stain_cells_probability { get; set; }
	public UInt32 cloth_color_edge { get; set; }
	public UInt32 cloth_color { get; set; }
	public CVector2<float> m_position_previous { get; set; }
	public bool m_is_culled_previous { get; set; }
	public List<UInt32> colors { get; set; }
	public List<UInt32> materials { get; set; }

    public void Load(NoitaStream s){
		num_points = s.ReadBeInt32();
		num_links = s.ReadBeInt32();
		width = s.ReadBeInt32();
		type = s.ReadBeUInt32();
		resting_distance = s.ReadBeFloat();
		mass_min = s.ReadBeFloat();
		mass_max = s.ReadBeFloat();
		stiffness = s.ReadBeFloat();
		velocity_dampening = s.ReadBeFloat();
		liquid_damping = s.ReadBeFloat();
		gets_entity_velocity_coeff = s.ReadBeFloat();
		collide_with_cells = s.ReadBool();
		simulate_gravity = s.ReadBool();
		simulate_wind = s.ReadBool();
		wind_change_speed = s.ReadBeFloat();
		constrain_stretching = s.ReadBool();
		pixelate_sprite_transforms = s.ReadBool();
		scale_sprite_x = s.ReadBool();
		follow_entity_transform = s.ReadBool();
		animation_target_offset.Load(s);
		animation_amount = s.ReadBeFloat();
		animation_speed = s.ReadBeFloat();
		animation_energy = s.ReadBeFloat();
		cloth_sprite_z_index = s.ReadBeFloat();
		stain_cells_probability = s.ReadBeInt32();
		cloth_color_edge = s.ReadBeUInt32();
		cloth_color = s.ReadBeUInt32();
		m_position_previous.Load(s);
		m_is_culled_previous = s.ReadBool();
		colors = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 colors.Add(UInt32.Load(s));
}
		materials = [];
UInt32 len = s.ReadBeUInt32();
for(int i = 0; i < len; i++) {
 materials.Add(UInt32.Load(s));
}

    }
    public void Save(NoitaStream s){
		s.WriteBeInt32(num_points);
		s.WriteBeInt32(num_links);
		s.WriteBeInt32(width);
		s.WriteBeUInt32(type);
		s.WriteBeFloat(resting_distance);
		s.WriteBeFloat(mass_min);
		s.WriteBeFloat(mass_max);
		s.WriteBeFloat(stiffness);
		s.WriteBeFloat(velocity_dampening);
		s.WriteBeFloat(liquid_damping);
		s.WriteBeFloat(gets_entity_velocity_coeff);
		s.WriteBool(collide_with_cells);
		s.WriteBool(simulate_gravity);
		s.WriteBool(simulate_wind);
		s.WriteBeFloat(wind_change_speed);
		s.WriteBool(constrain_stretching);
		s.WriteBool(pixelate_sprite_transforms);
		s.WriteBool(scale_sprite_x);
		s.WriteBool(follow_entity_transform);
		animation_target_offset.Write(s);
		s.WriteBeFloat(animation_amount);
		s.WriteBeFloat(animation_speed);
		s.WriteBeFloat(animation_energy);
		s.WriteBeFloat(cloth_sprite_z_index);
		s.WriteBeInt32(stain_cells_probability);
		s.WriteBeUInt32(cloth_color_edge);
		s.WriteBeUInt32(cloth_color);
		m_position_previous.Write(s);
		s.WriteBool(m_is_culled_previous);
		s.WriteBeUInt32(colors.Length);
foreach(var item in colors){ colors.Write(s);
}
		s.WriteBeUInt32(materials.Length);
foreach(var item in materials){ materials.Write(s);
}

    }
}