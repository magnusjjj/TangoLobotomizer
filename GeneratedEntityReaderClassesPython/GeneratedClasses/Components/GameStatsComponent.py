from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class GameStatsComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    name:NoitaString = field(default_factory=NoitaString)
    stats_filename:NoitaString = field(default_factory=NoitaString)
    is_player:NoitaBool = field(default_factory=NoitaBool)
    extra_death_msg:NoitaString = field(default_factory=NoitaString)
    dont_do_logplayerkill:NoitaBool = field(default_factory=NoitaBool)
    player_polymorph_count:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.name.Read(s)
        self.stats_filename.Read(s)
        self.is_player.Read(s)
        self.extra_death_msg.Read(s)
        self.dont_do_logplayerkill.Read(s)
        self.player_polymorph_count.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.name.Write(s)
        self.stats_filename.Write(s)
        self.is_player.Write(s)
        self.extra_death_msg.Write(s)
        self.dont_do_logplayerkill.Write(s)
        self.player_polymorph_count.Write(s)

