from dataclasses import dataclass, field
from BasicNoitaTypes import NoitaBool
from BasicNoitaTypes import NoitaString
from BasicNoitaTypes import NoitaInt64
from BasicNoitaTypes import NoitaUInt
from BasicNoitaTypes import NoitaFloat
from BasicNoitaTypes import NoitaInt

from NoitaStream import NoitaStream
@dataclass
class IngestionComponent:
    Deleted:NoitaBool = field(default_factory=NoitaBool)
    Enabled:NoitaBool = field(default_factory=NoitaBool)
    Tags:NoitaString = field(default_factory=NoitaString)
    ingestion_size:NoitaInt64 = field(default_factory=NoitaInt64)
    ingestion_capacity:NoitaInt64 = field(default_factory=NoitaInt64)
    ingestion_cooldown_delay_frames:NoitaUInt = field(default_factory=NoitaUInt)
    ingestion_reduce_every_n_frame:NoitaUInt = field(default_factory=NoitaUInt)
    overingestion_damage:NoitaFloat = field(default_factory=NoitaFloat)
    blood_healing_speed:NoitaFloat = field(default_factory=NoitaFloat)
    ingestion_satiation_material_tag:NoitaString = field(default_factory=NoitaString)
    m_ingestion_cooldown_frames:NoitaInt = field(default_factory=NoitaInt)
    
    def Read(self, s:NoitaStream):
        self.Deleted.Read(s)
        self.Enabled.Read(s)
        self.Tags.Read(s)
        self.ingestion_size.Read(s)
        self.ingestion_capacity.Read(s)
        self.ingestion_cooldown_delay_frames.Read(s)
        self.ingestion_reduce_every_n_frame.Read(s)
        self.overingestion_damage.Read(s)
        self.blood_healing_speed.Read(s)
        self.ingestion_satiation_material_tag.Read(s)
        self.m_ingestion_cooldown_frames.Read(s)
    
    def Write(self, s:NoitaStream):
        self.Deleted.Write(s)
        self.Enabled.Write(s)
        self.Tags.Write(s)
        self.ingestion_size.Write(s)
        self.ingestion_capacity.Write(s)
        self.ingestion_cooldown_delay_frames.Write(s)
        self.ingestion_reduce_every_n_frame.Write(s)
        self.overingestion_damage.Write(s)
        self.blood_healing_speed.Write(s)
        self.ingestion_satiation_material_tag.Write(s)
        self.m_ingestion_cooldown_frames.Write(s)

