using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTeilnehmerVerwaltung
{
    public partial class AusgabeAlleTeilnehmer : Form
    {
        private List<TeilnehmerModel> bwhwListeTeilnehmer = new List<TeilnehmerModel>();
        public AusgabeAlleTeilnehmer(List<TeilnehmerModel> pListeTeilnehmer)
        {
            InitializeComponent();
            bwhwListeTeilnehmer = pListeTeilnehmer;
        }

        private void AusgabeAlleTeilnehmer_Load(object sender, EventArgs e)
        {
            // Erstellen des DataTable-Objektes
            DataTable datenTabelle = new DataTable("AlleTeilnehmer");

            // SpaltenNamen zur DatenTablle hinzufügen
            datenTabelle.Columns.Add("ID");
            datenTabelle.Columns.Add("VorName");
            datenTabelle.Columns.Add("NachName");
            datenTabelle.Columns.Add("EMail");
            datenTabelle.Columns.Add("Modul");

            // DatenTablle mit vorhandenen Teilnehmern aus der TeilnehmerListe füllen
            foreach (var element in bwhwListeTeilnehmer)
            {
                datenTabelle.Rows.Add(element.ID, element.VorName, element.NachName, element.EMail, element.Modul);
            }

            // DatenGridAnsicht(DataGridView) soll die DatenTablle als Datenquelle verwenden
            dataGridViewTeilnehmer.DataSource = datenTabelle;
        }

        private void beendenBtn_Click(object sender, EventArgs e) => this.Close();

    }
}
