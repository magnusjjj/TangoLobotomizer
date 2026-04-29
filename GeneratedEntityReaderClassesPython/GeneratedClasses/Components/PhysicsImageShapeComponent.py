from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PhysicsImageShapeComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    is_root:NoitaBool = field(default_factory=NoitaBool)
    body_id:NoitaInt = field(default_factory=NoitaInt)
    use_sprite:NoitaBool = field(default_factory=NoitaBool)
    is_circle:NoitaBool = field(default_factory=NoitaBool)
    centered:NoitaBool = field(default_factory=NoitaBool)
    offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    z:NoitaFloat = field(default_factory=NoitaFloat)
    image_file:NoitaString = field(default_factory=NoitaString)
    material:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.is_root.Read(s)
        self.body_id.Read(s)
        self.use_sprite.Read(s)
        self.is_circle.Read(s)
        self.centered.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
        self.z.Read(s)
        self.image_file.Read(s)
        self.material.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.is_root.Write(s)
        self.body_id.Write(s)
        self.use_sprite.Write(s)
        self.is_circle.Write(s)
        self.centered.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)
        self.z.Write(s)
        self.image_file.Write(s)
        self.material.Write(s)

