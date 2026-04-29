from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class AudioComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    file:NoitaString = field(default_factory=NoitaString)
    event_root:NoitaString = field(default_factory=NoitaString)
    audio_physics_material:NoitaString = field(default_factory=NoitaString)
    set_latest_event_position:NoitaBool = field(default_factory=NoitaBool)
    remove_latest_event_on_destroyed:NoitaBool = field(default_factory=NoitaBool)
    send_message_on_event_dead:NoitaBool = field(default_factory=NoitaBool)
    play_only_if_visible:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.file.Read(s)
        self.event_root.Read(s)
        self.audio_physics_material.Read(s)
        self.set_latest_event_position.Read(s)
        self.remove_latest_event_on_destroyed.Read(s)
        self.send_message_on_event_dead.Read(s)
        self.play_only_if_visible.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.file.Write(s)
        self.event_root.Write(s)
        self.audio_physics_material.Write(s)
        self.set_latest_event_position.Write(s)
        self.remove_latest_event_on_destroyed.Write(s)
        self.send_message_on_event_dead.Write(s)
        self.play_only_if_visible.Write(s)

