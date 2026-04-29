from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt
from BasicNoitaTypes import NoitaFloat

from NoitaStream import NoitaStream
@dataclass
class PathFindingGridMarkerComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    marker_work_flag:NoitaInt = field(default_factory=NoitaInt)
    marker_offset_x:NoitaFloat = field(default_factory=NoitaFloat)
    marker_offset_y:NoitaFloat = field(default_factory=NoitaFloat)
    player_marker_radius:NoitaFloat = field(default_factory=NoitaFloat)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.marker_work_flag.Read(s)
        self.marker_offset_x.Read(s)
        self.marker_offset_y.Read(s)
        self.player_marker_radius.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.marker_work_flag.Write(s)
        self.marker_offset_x.Write(s)
        self.marker_offset_y.Write(s)
        self.player_marker_radius.Write(s)

