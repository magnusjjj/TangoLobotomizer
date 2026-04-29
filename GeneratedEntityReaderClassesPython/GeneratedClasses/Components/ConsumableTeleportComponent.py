from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaCVector2
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class ConsumableTeleportComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    create_other_end:NoitaBool = field(default_factory=NoitaBool)
    is_at_home:NoitaBool = field(default_factory=NoitaBool)
    collision_radius:NoitaFloat = field(default_factory=NoitaFloat)
    target_location:NoitaCVector2 = field(default_factory=lambda: NoitaCVector2(NoitaFloat))
    target_id:NoitaUInt = field(default_factory=NoitaUInt)
    id:NoitaUInt = field(default_factory=NoitaUInt)
    mNextUsableFrame:NoitaInt = field(default_factory=NoitaInt)
    mHasOtherEnd:NoitaBool = field(default_factory=NoitaBool)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.create_other_end.Read(s)
        self.is_at_home.Read(s)
        self.collision_radius.Read(s)
        self.target_location.Read(s)
        self.target_id.Read(s)
        self.id.Read(s)
        self.mNextUsableFrame.Read(s)
        self.mHasOtherEnd.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.create_other_end.Write(s)
        self.is_at_home.Write(s)
        self.collision_radius.Write(s)
        self.target_location.Write(s)
        self.target_id.Write(s)
        self.id.Write(s)
        self.mNextUsableFrame.Write(s)
        self.mHasOtherEnd.Write(s)

