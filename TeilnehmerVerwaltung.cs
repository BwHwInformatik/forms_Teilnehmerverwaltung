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
    public partial class HauptFenster : Form
    {
        private List<TeilnehmerModel> bwhwTeilnehmer = new List<TeilnehmerModel>();

        public HauptFenster()
        {
            InitializeComponent();
        }

        private void BeendenBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void OeffneDateiBtn_Click(object sender, EventArgs e)
        {
            //TODO:Teilnehmer-Datei implementieren
        }

        private void speichernBtn_Click(object sender, EventArgs e)
        {
            //Konstruktor mit Parameterübergabe
            TeilnehmerModel neuerTeilnehmer = new TeilnehmerModel(idTB.Text, vornameTB.Text, nachnameTB.Text, emailTB.Text, modulTB.Text);

            if (neuerTeilnehmer.ID == string.Empty) { MessageBox.Show("Es muss mindestens die ID vergeben werden !"); return; }

            if (bwhwTeilnehmer.Find(teilnehmer => teilnehmer.ID == neuerTeilnehmer.ID) == null )
            {
                bwhwTeilnehmer.Add(neuerTeilnehmer);

                comboBox1.DataSource = bwhwTeilnehmer.ToArray();
                comboBox1.ValueMember = null;
                comboBox1.DisplayMember = "ID";


                var ausgabeTeilnehmerSpeichernForm = new AusgabeTeilnehmerSpeichern(neuerTeilnehmer);
                ausgabeTeilnehmerSpeichernForm.ShowDialog();

            }
            else { MessageBox.Show("Teilnehmer mit dieser ID existiert bereits"); }
        }
        private void comboBox1_OnDropDownClosed(object sender, EventArgs e)
        {
            var gefundenerTeilnehmer = bwhwTeilnehmer.Find(teilnehmer => teilnehmer == comboBox1.SelectedValue);

            if (gefundenerTeilnehmer != null)
            {
                idTB.Text = gefundenerTeilnehmer.ID;
                vornameTB.Text = gefundenerTeilnehmer.VorName;
                nachnameTB.Text = gefundenerTeilnehmer.NachName;
                emailTB.Text = gefundenerTeilnehmer.EMail;
                modulTB.Text = gefundenerTeilnehmer.Modul;
            }
        }

        private void loeschenBtn_Click(object sender, EventArgs e)
        {
            //TODO:Löschen von Teilnehmern implementieren !
        }

        private void btnAlleTeilnehmer_Click(object sender, EventArgs e)
        {
            var ausgabeAlleTeilnehmerForm = new AusgabeAlleTeilnehmer(bwhwTeilnehmer);
            ausgabeAlleTeilnehmerForm.ShowDialog();
        }
    }
}
