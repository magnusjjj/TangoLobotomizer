from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from GeneratedClasses.ValueRange import ValueRange

from NoitaStream import NoitaStream
@dataclass
class LifetimeComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    lifetime:NoitaInt = field(default_factory=NoitaInt)
    randomize_lifetime:ValueRange = field(default_factory=ValueRange)
    fade_sprites:NoitaBool = field(default_factory=NoitaBool)
    kill_parent:NoitaBool = field(default_factory=NoitaBool)
    kill_all_parents:NoitaBool = field(default_factory=NoitaBool)
    serialize_duration:NoitaBool = field(default_factory=NoitaBool)
    kill_frame_serialized:NoitaInt = field(default_factory=NoitaInt)
    creation_frame_serialized:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.lifetime.Read(s)
        self.randomize_lifetime.Read(s)
        self.fade_sprites.Read(s)
        self.kill_parent.Read(s)
        self.kill_all_parents.Read(s)
        self.serialize_duration.Read(s)
        self.kill_frame_serialized.Read(s)
        self.creation_frame_serialized.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.lifetime.Write(s)
        self.randomize_lifetime.Write(s)
        self.fade_sprites.Write(s)
        self.kill_parent.Write(s)
        self.kill_all_parents.Write(s)
        self.serialize_duration.Write(s)
        self.kill_frame_serialized.Write(s)
        self.creation_frame_serialized.Write(s)

