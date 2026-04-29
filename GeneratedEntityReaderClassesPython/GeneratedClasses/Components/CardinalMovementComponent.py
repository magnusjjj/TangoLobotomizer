from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString

from NoitaStream import NoitaStream
@dataclass
class CardinalMovementComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    horizontal_movement:NoitaBool = field(default_factory=NoitaBool)
    vertical_movement:NoitaBool = field(default_factory=NoitaBool)
    intercardinal_movement:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.horizontal_movement.Read(s)
        self.vertical_movement.Read(s)
        self.intercardinal_movement.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.horizontal_movement.Write(s)
        self.vertical_movement.Write(s)
        self.intercardinal_movement.Write(s)

