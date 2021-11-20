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
    public partial class AusgabeTeilnehmerSpeichern : Form
    {
        public AusgabeTeilnehmerSpeichern(TeilnehmerModel neuerTeilnehmer)
        {
            InitializeComponent();

            idTB.Text = neuerTeilnehmer.ID;
        }

        private void beendenBtn_Click(object sender, EventArgs e) => this.Close();

    }
}
