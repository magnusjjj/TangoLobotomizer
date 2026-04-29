from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PixelSceneComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    pixel_scene:NoitaString = field(default_factory=NoitaString)
    pixel_scene_visual:NoitaString = field(default_factory=NoitaString)
    pixel_scene_background:NoitaString = field(default_factory=NoitaString)
    background_z_index:NoitaInt = field(default_factory=NoitaInt)
    offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    skip_biome_checks:NoitaBool = field(default_factory=NoitaBool)
    skip_edge_textures:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.pixel_scene.Read(s)
        self.pixel_scene_visual.Read(s)
        self.pixel_scene_background.Read(s)
        self.background_z_index.Read(s)
        self.offset_x.Read(s)
        self.offset_y.Read(s)
        self.skip_biome_checks.Read(s)
        self.skip_edge_textures.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.pixel_scene.Write(s)
        self.pixel_scene_visual.Write(s)
        self.pixel_scene_background.Write(s)
        self.background_z_index.Write(s)
        self.offset_x.Write(s)
        self.offset_y.Write(s)
        self.skip_biome_checks.Write(s)
        self.skip_edge_textures.Write(s)

