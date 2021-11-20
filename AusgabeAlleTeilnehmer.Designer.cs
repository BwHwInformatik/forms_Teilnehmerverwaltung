
namespace FormsTeilnehmerVerwaltung
{
    partial class AusgabeAlleTeilnehmer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTeilnehmer = new System.Windows.Forms.DataGridView();
            this.beendenBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeilnehmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeilnehmer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewTeilnehmer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTeilnehmer.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.dataGridViewTeilnehmer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewTeilnehmer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTeilnehmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeilnehmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewTeilnehmer.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewTeilnehmer.Location = new System.Drawing.Point(10, 104);
            this.dataGridViewTeilnehmer.Name = "dataGridViewTeilnehmer";
            this.dataGridViewTeilnehmer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTeilnehmer.RowTemplate.ReadOnly = true;
            this.dataGridViewTeilnehmer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTeilnehmer.Size = new System.Drawing.Size(543, 346);
            this.dataGridViewTeilnehmer.TabIndex = 0;
            // 
            // beendenBtn
            // 
            this.beendenBtn.BackColor = System.Drawing.Color.Transparent;
            this.beendenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.beendenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beendenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenBtn.ForeColor = System.Drawing.Color.White;
            this.beendenBtn.Location = new System.Drawing.Point(478, 12);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(75, 29);
            this.beendenBtn.TabIndex = 19;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = false;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsTeilnehmerVerwaltung.Properties.Resources.BWHWLogoMedium;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Alle Teilnehmer";
            // 
            // AusgabeAlleTeilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(562, 454);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.beendenBtn);
            this.Controls.Add(this.dataGridViewTeilnehmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AusgabeAlleTeilnehmer";
            this.Text = "Alle Teilnehmer";
            this.Load += new System.EventHandler(this.AusgabeAlleTeilnehmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeilnehmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeilnehmer;
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}