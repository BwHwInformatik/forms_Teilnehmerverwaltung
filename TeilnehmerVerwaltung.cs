using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FormsTeilnehmerVerwaltung
{
    public partial class HauptFenster : Form
    {
        private List<TeilnehmerModel> bwhwTeilnehmer = new List<TeilnehmerModel>();

        public HauptFenster()
        {
            InitializeComponent();
            
        }

        private void EingabeElementeLeeren()
        {
            idTB.Text = string.Empty;
            vornameTB.Text = string.Empty;
            nachnameTB.Text = string.Empty;
            emailTB.Text = string.Empty;
            modulTB.Text = string.Empty;

            clearBtn1.Visible = false;
            clearBtn2.Visible = false;
            clearBtn3.Visible = false;
            clearBtn4.Visible = false;
            clearBtn5.Visible = false;
            idTB.Focus();
        }
        private void ComboBox_Aktualisieren()
        {
            comboBox1.DataSource = bwhwTeilnehmer.ToArray();
            comboBox1.ValueMember = null;
            comboBox1.DisplayMember = "ID";

            comboBox1.SelectedIndex = -1;
            EingabeElementeLeeren();
        }
        private void BeendenBtn_Click(object sender, EventArgs e) => Application.Exit();
        private void speichernBtn_Click(object sender, EventArgs e)
        {
            //Konstruktor mit Parameterübergabe
            TeilnehmerModel neuerTeilnehmer = new TeilnehmerModel(idTB.Text, vornameTB.Text, nachnameTB.Text, emailTB.Text, modulTB.Text);

            if (neuerTeilnehmer.ID == string.Empty) { MessageBox.Show("Es muss mindestens die ID vergeben werden !"); return; }

            var gefundenerTeilnehmer = bwhwTeilnehmer.Find(teilnehmer => teilnehmer.ID == neuerTeilnehmer.ID);
            if (gefundenerTeilnehmer == null )
            {
                bwhwTeilnehmer.Add(neuerTeilnehmer);

                ComboBox_Aktualisieren();

                var ausgabeTeilnehmerSpeichernForm = new AusgabeTeilnehmerSpeichern(neuerTeilnehmer);
                ausgabeTeilnehmerSpeichernForm.ShowDialog();

            }
            else {
                if (vornameTB.Text == gefundenerTeilnehmer.VorName
                    && nachnameTB.Text == gefundenerTeilnehmer.NachName
                    && emailTB.Text == gefundenerTeilnehmer.EMail
                    && modulTB.Text == gefundenerTeilnehmer.Modul)
                {
                    MessageBox.Show("Dieser Teilnehmer ist schon vorhanden!");
                }
                else
                {
                    var indexGefundenerTeilnehmer = bwhwTeilnehmer.FindIndex(teilnehmer => teilnehmer.ID == neuerTeilnehmer.ID);
                    bwhwTeilnehmer[indexGefundenerTeilnehmer].VorName = vornameTB.Text;
                    bwhwTeilnehmer[indexGefundenerTeilnehmer].NachName = nachnameTB.Text;
                    bwhwTeilnehmer[indexGefundenerTeilnehmer].EMail = emailTB.Text;
                    bwhwTeilnehmer[indexGefundenerTeilnehmer].Modul = modulTB.Text;


                    ComboBox_Aktualisieren();

                    MessageBox.Show("Daten wurden aktualisiert!");
                }
            }
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
            idTB.Focus();
        }

        private void loeschenBtn_Click(object sender, EventArgs e)
        {
            //TODO:Löschen von Teilnehmern implementieren !
            var gefundenerTeilnehmer = bwhwTeilnehmer.Find(teilnehmer => teilnehmer == comboBox1.SelectedValue);
            bwhwTeilnehmer.Remove(gefundenerTeilnehmer);


            ComboBox_Aktualisieren();
        }

        private void btnAlleTeilnehmer_Click(object sender, EventArgs e)
        {
            var ausgabeAlleTeilnehmerForm = new AusgabeAlleTeilnehmer(bwhwTeilnehmer);
            ausgabeAlleTeilnehmerForm.ShowDialog();
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            clearBtn1.Visible = false;
        }
        private void idTB_TextChanged(object sender, EventArgs e)
        {
            if (idTB.Text != string.Empty)
                clearBtn1.Visible = true;
            idTB.Focus();
        }
        private void clearBtn2_Click(object sender, EventArgs e)
        {
            vornameTB.Text = string.Empty;
            clearBtn2.Visible = false;
        }
        private void vornameTB_TextChanged(object sender, EventArgs e)
        {
            if (vornameTB.Text != string.Empty)
                clearBtn2.Visible = true;
            vornameTB.Focus();
        }
        private void clearBtn3_Click(object sender, EventArgs e)
        {
            nachnameTB.Text = string.Empty;
            clearBtn3.Visible = false;

        }
        private void nachnameTB_TextChanged(object sender, EventArgs e)
        {
            if (nachnameTB.Text != string.Empty)
                clearBtn3.Visible = true;
            nachnameTB.Focus();
        }
        private void clearBtn4_Click(object sender, EventArgs e)
        {
            emailTB.Text = string.Empty;
            clearBtn4.Visible = false;
        }
        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            if (emailTB.Text != string.Empty)
                clearBtn4.Visible = true;
            emailTB.Focus();
        }
        private void clearBtn5_Click(object sender, EventArgs e)
        {
            modulTB.Text = string.Empty;
            clearBtn5.Visible = false;
        }
        private void modulTB_TextChanged(object sender, EventArgs e)
        {
            if (modulTB.Text != string.Empty)
                clearBtn5.Visible = true;
            modulTB.Focus();
        }
        private void OeffneDateiBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".json",
                Filter = "JSON Datei (.json)|*.json"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonTeilnehmer = JsonConvert.DeserializeObject<List<TeilnehmerModel>>(File.ReadAllText(openFileDialog.FileName));

                bwhwTeilnehmer = jsonTeilnehmer;
                ComboBox_Aktualisieren();
                MessageBox.Show("Daten wurden aus der Datei geladen !");

            }
        }
        private void speichereDateiBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = ".json",
                Filter = "JSON Datei (.json)|*.json"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(bwhwTeilnehmer, Formatting.Indented));

                MessageBox.Show("Daten wurden in die Datei gespeichert !");
            }
        }
    }
}
