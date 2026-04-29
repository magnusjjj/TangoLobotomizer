from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from GeneratedClasses.PixelSprite import PixelSprite

from NoitaStream import NoitaStream
@dataclass
class PixelSpriteComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    image_file:NoitaString = field(default_factory=NoitaString)
    anchor_x:NoitaInt = field(default_factory=NoitaInt)
    anchor_y:NoitaInt = field(default_factory=NoitaInt)
    material:NoitaString = field(default_factory=NoitaString)
    diggable:NoitaBool = field(default_factory=NoitaBool)
    clean_overlapping_pixels:NoitaBool = field(default_factory=NoitaBool)
    kill_when_sprite_dies:NoitaBool = field(default_factory=NoitaBool)
    create_box2d_bodies:NoitaBool = field(default_factory=NoitaBool)
    mPixelSprite:PixelSprite = field(default_factory=PixelSprite)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.image_file.Read(s)
        self.anchor_x.Read(s)
        self.anchor_y.Read(s)
        self.material.Read(s)
        self.diggable.Read(s)
        self.clean_overlapping_pixels.Read(s)
        self.kill_when_sprite_dies.Read(s)
        self.create_box2d_bodies.Read(s)
        self.mPixelSprite.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.image_file.Write(s)
        self.anchor_x.Write(s)
        self.anchor_y.Write(s)
        self.material.Write(s)
        self.diggable.Write(s)
        self.clean_overlapping_pixels.Write(s)
        self.kill_when_sprite_dies.Write(s)
        self.create_box2d_bodies.Write(s)
        self.mPixelSprite.Write(s)

