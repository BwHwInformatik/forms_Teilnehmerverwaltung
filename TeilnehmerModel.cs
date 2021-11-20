using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.Linq.Mapping;

namespace FormsTeilnehmerVerwaltung
{
    public class TeilnehmerModel
    {
        [JsonConstructor]
        public TeilnehmerModel(
            [JsonProperty("ID")] string ID,
            [JsonProperty("Vorname")] string VorName,
            [JsonProperty("Nachname")] string NachName,
            [JsonProperty("EMail")] string EMail,
            [JsonProperty("Modul")] string Modul
        )
        {
            this.ID = ID;
            this.VorName = VorName != string.Empty ? VorName : "FehlerVN";
            this.NachName = NachName != string.Empty ? NachName : "FehlerNN"; ;
            this.EMail = EMail != string.Empty ? EMail : "Fehler@Fehler.de"; ;
            this.Modul = Modul != string.Empty ? Modul : "FehlerMOD"; ;
        }

        [Column(Name = "ID", IsPrimaryKey = true)]
        public string ID { get; }

        [Column(Name = "Vorname")]
        public string VorName { get; set; }

        [Column(Name = "Nachname")]
        public string NachName { get; set; }

        [Column(Name = "EMail")]
        public string EMail { get; set; }

        [Column(Name = "Modul")]
        public string Modul { get; set; }
    }
}
