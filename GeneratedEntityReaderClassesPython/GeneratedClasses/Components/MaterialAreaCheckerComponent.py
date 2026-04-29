from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from GeneratedClasses.types_aabb import types_aabb

from NoitaStream import NoitaStream
@dataclass
class MaterialAreaCheckerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    update_every_x_frame:NoitaInt = field(default_factory=NoitaInt)
    look_for_failure:NoitaBool = field(default_factory=NoitaBool)
    area_aabb:types_aabb = field(default_factory=types_aabb)
    material:NoitaInt = field(default_factory=NoitaInt)
    material2:NoitaInt = field(default_factory=NoitaInt)
    count_min:NoitaInt = field(default_factory=NoitaInt)
    always_check_fullness:NoitaBool = field(default_factory=NoitaBool)
    kill_after_message:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.update_every_x_frame.Read(s)
        self.look_for_failure.Read(s)
        self.area_aabb.Read(s)
        self.material.Read(s)
        self.material2.Read(s)
        self.count_min.Read(s)
        self.always_check_fullness.Read(s)
        self.kill_after_message.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.update_every_x_frame.Write(s)
        self.look_for_failure.Write(s)
        self.area_aabb.Write(s)
        self.material.Write(s)
        self.material2.Write(s)
        self.count_min.Write(s)
        self.always_check_fullness.Write(s)
        self.kill_after_message.Write(s)

