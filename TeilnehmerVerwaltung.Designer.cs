
namespace FormsTeilnehmerVerwaltung
{
    partial class HauptFenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HauptFenster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.csvSpeichernBtn = new System.Windows.Forms.Button();
            this.jsonSpeichernBtn = new System.Windows.Forms.Button();
            this.jsonOeffnenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beendenBtn = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.vornameTB = new System.Windows.Forms.TextBox();
            this.nachnameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.modulTB = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.vornameLbl = new System.Windows.Forms.Label();
            this.nachnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.modulLbl = new System.Windows.Forms.Label();
            this.speichernBtn = new System.Windows.Forms.Button();
            this.loeschenBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAlleTeilnehmer = new System.Windows.Forms.Button();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.clearBtn3 = new System.Windows.Forms.Button();
            this.clearBtn4 = new System.Windows.Forms.Button();
            this.clearBtn5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.csvSpeichernBtn);
            this.panel1.Controls.Add(this.jsonSpeichernBtn);
            this.panel1.Controls.Add(this.jsonOeffnenBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 445);
            this.panel1.TabIndex = 0;
            // 
            // csvSpeichernBtn
            // 
            this.csvSpeichernBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csvSpeichernBtn.ForeColor = System.Drawing.Color.White;
            this.csvSpeichernBtn.Location = new System.Drawing.Point(48, 379);
            this.csvSpeichernBtn.Name = "csvSpeichernBtn";
            this.csvSpeichernBtn.Size = new System.Drawing.Size(143, 29);
            this.csvSpeichernBtn.TabIndex = 4;
            this.csvSpeichernBtn.Text = "Csv-Datei speichern";
            this.csvSpeichernBtn.UseVisualStyleBackColor = true;
            this.csvSpeichernBtn.Click += new System.EventHandler(this.csvSpeichern_Click);
            // 
            // jsonSpeichernBtn
            // 
            this.jsonSpeichernBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jsonSpeichernBtn.ForeColor = System.Drawing.Color.White;
            this.jsonSpeichernBtn.Location = new System.Drawing.Point(48, 344);
            this.jsonSpeichernBtn.Name = "jsonSpeichernBtn";
            this.jsonSpeichernBtn.Size = new System.Drawing.Size(143, 29);
            this.jsonSpeichernBtn.TabIndex = 3;
            this.jsonSpeichernBtn.Text = "Json-Datei speichern";
            this.jsonSpeichernBtn.UseVisualStyleBackColor = true;
            this.jsonSpeichernBtn.Click += new System.EventHandler(this.jsonSpeichern_Click);
            // 
            // jsonOeffnenBtn
            // 
            this.jsonOeffnenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jsonOeffnenBtn.ForeColor = System.Drawing.Color.White;
            this.jsonOeffnenBtn.Location = new System.Drawing.Point(48, 309);
            this.jsonOeffnenBtn.Name = "jsonOeffnenBtn";
            this.jsonOeffnenBtn.Size = new System.Drawing.Size(143, 29);
            this.jsonOeffnenBtn.TabIndex = 2;
            this.jsonOeffnenBtn.Text = "Json-Datei öffnen";
            this.jsonOeffnenBtn.UseVisualStyleBackColor = true;
            this.jsonOeffnenBtn.Click += new System.EventHandler(this.jsonOeffnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teilnehmerverwaltung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsTeilnehmerVerwaltung.Properties.Resources.BWHWLogoMedium;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // beendenBtn
            // 
            this.beendenBtn.BackColor = System.Drawing.Color.Transparent;
            this.beendenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.beendenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beendenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.beendenBtn.Location = new System.Drawing.Point(745, 12);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(75, 29);
            this.beendenBtn.TabIndex = 1;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = false;
            this.beendenBtn.Click += new System.EventHandler(this.BeendenBtn_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(383, 93);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(280, 29);
            this.idTB.TabIndex = 2;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // vornameTB
            // 
            this.vornameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vornameTB.Location = new System.Drawing.Point(383, 138);
            this.vornameTB.Name = "vornameTB";
            this.vornameTB.Size = new System.Drawing.Size(280, 29);
            this.vornameTB.TabIndex = 3;
            this.vornameTB.TextChanged += new System.EventHandler(this.vornameTB_TextChanged);
            // 
            // nachnameTB
            // 
            this.nachnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachnameTB.Location = new System.Drawing.Point(383, 181);
            this.nachnameTB.Name = "nachnameTB";
            this.nachnameTB.Size = new System.Drawing.Size(280, 29);
            this.nachnameTB.TabIndex = 4;
            this.nachnameTB.TextChanged += new System.EventHandler(this.nachnameTB_TextChanged);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(383, 226);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(280, 29);
            this.emailTB.TabIndex = 5;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // modulTB
            // 
            this.modulTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulTB.Location = new System.Drawing.Point(383, 271);
            this.modulTB.Name = "modulTB";
            this.modulTB.Size = new System.Drawing.Size(280, 29);
            this.modulTB.TabIndex = 6;
            this.modulTB.TextChanged += new System.EventHandler(this.modulTB_TextChanged);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(274, 96);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(27, 24);
            this.idLbl.TabIndex = 7;
            this.idLbl.Text = "ID";
            // 
            // vornameLbl
            // 
            this.vornameLbl.AutoSize = true;
            this.vornameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vornameLbl.Location = new System.Drawing.Point(274, 141);
            this.vornameLbl.Name = "vornameLbl";
            this.vornameLbl.Size = new System.Drawing.Size(88, 24);
            this.vornameLbl.TabIndex = 8;
            this.vornameLbl.Text = "Vorname";
            // 
            // nachnameLbl
            // 
            this.nachnameLbl.AutoSize = true;
            this.nachnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachnameLbl.Location = new System.Drawing.Point(274, 184);
            this.nachnameLbl.Name = "nachnameLbl";
            this.nachnameLbl.Size = new System.Drawing.Size(103, 24);
            this.nachnameLbl.TabIndex = 9;
            this.nachnameLbl.Text = "Nachname";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(274, 229);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(57, 24);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "EMail";
            // 
            // modulLbl
            // 
            this.modulLbl.AutoSize = true;
            this.modulLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulLbl.Location = new System.Drawing.Point(274, 274);
            this.modulLbl.Name = "modulLbl";
            this.modulLbl.Size = new System.Drawing.Size(63, 24);
            this.modulLbl.TabIndex = 11;
            this.modulLbl.Text = "Modul";
            // 
            // speichernBtn
            // 
            this.speichernBtn.BackColor = System.Drawing.Color.Transparent;
            this.speichernBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speichernBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speichernBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.speichernBtn.Location = new System.Drawing.Point(383, 331);
            this.speichernBtn.Name = "speichernBtn";
            this.speichernBtn.Size = new System.Drawing.Size(75, 29);
            this.speichernBtn.TabIndex = 12;
            this.speichernBtn.Text = "Speichern";
            this.speichernBtn.UseVisualStyleBackColor = false;
            this.speichernBtn.Click += new System.EventHandler(this.speichernBtn_Click);
            // 
            // loeschenBtn
            // 
            this.loeschenBtn.BackColor = System.Drawing.Color.Transparent;
            this.loeschenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loeschenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loeschenBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.loeschenBtn.Location = new System.Drawing.Point(588, 331);
            this.loeschenBtn.Name = "loeschenBtn";
            this.loeschenBtn.Size = new System.Drawing.Size(75, 29);
            this.loeschenBtn.TabIndex = 13;
            this.loeschenBtn.Text = "Löschen";
            this.loeschenBtn.UseVisualStyleBackColor = false;
            this.loeschenBtn.Click += new System.EventHandler(this.loeschenBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(383, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 32);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_OnDropDownClosed);
            // 
            // btnAlleTeilnehmer
            // 
            this.btnAlleTeilnehmer.BackColor = System.Drawing.Color.Transparent;
            this.btnAlleTeilnehmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlleTeilnehmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleTeilnehmer.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnAlleTeilnehmer.Location = new System.Drawing.Point(383, 11);
            this.btnAlleTeilnehmer.Name = "btnAlleTeilnehmer";
            this.btnAlleTeilnehmer.Size = new System.Drawing.Size(280, 29);
            this.btnAlleTeilnehmer.TabIndex = 17;
            this.btnAlleTeilnehmer.Text = "AlleTeilnehmer";
            this.btnAlleTeilnehmer.UseVisualStyleBackColor = false;
            this.btnAlleTeilnehmer.Click += new System.EventHandler(this.btnAlleTeilnehmer_Click);
            // 
            // clearBtn1
            // 
            this.clearBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn1.AutoSize = true;
            this.clearBtn1.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn1.FlatAppearance.BorderSize = 0;
            this.clearBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearBtn1.Location = new System.Drawing.Point(637, 96);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(23, 23);
            this.clearBtn1.TabIndex = 18;
            this.clearBtn1.Text = "x";
            this.clearBtn1.UseVisualStyleBackColor = false;
            this.clearBtn1.Visible = false;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn1_Click);
            // 
            // clearBtn2
            // 
            this.clearBtn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn2.AutoSize = true;
            this.clearBtn2.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn2.FlatAppearance.BorderSize = 0;
            this.clearBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearBtn2.Location = new System.Drawing.Point(637, 141);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(23, 23);
            this.clearBtn2.TabIndex = 19;
            this.clearBtn2.Text = "x";
            this.clearBtn2.UseVisualStyleBackColor = false;
            this.clearBtn2.Visible = false;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // clearBtn3
            // 
            this.clearBtn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn3.AutoSize = true;
            this.clearBtn3.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn3.FlatAppearance.BorderSize = 0;
            this.clearBtn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearBtn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearBtn3.Location = new System.Drawing.Point(637, 184);
            this.clearBtn3.Name = "clearBtn3";
            this.clearBtn3.Size = new System.Drawing.Size(23, 23);
            this.clearBtn3.TabIndex = 20;
            this.clearBtn3.Text = "x";
            this.clearBtn3.UseVisualStyleBackColor = false;
            this.clearBtn3.Visible = false;
            this.clearBtn3.Click += new System.EventHandler(this.clearBtn3_Click);
            // 
            // clearBtn4
            // 
            this.clearBtn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn4.AutoSize = true;
            this.clearBtn4.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn4.FlatAppearance.BorderSize = 0;
            this.clearBtn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearBtn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearBtn4.Location = new System.Drawing.Point(637, 229);
            this.clearBtn4.Name = "clearBtn4";
            this.clearBtn4.Size = new System.Drawing.Size(23, 23);
            this.clearBtn4.TabIndex = 21;
            this.clearBtn4.Text = "x";
            this.clearBtn4.UseVisualStyleBackColor = false;
            this.clearBtn4.Visible = false;
            this.clearBtn4.Click += new System.EventHandler(this.clearBtn4_Click);
            // 
            // clearBtn5
            // 
            this.clearBtn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn5.AutoSize = true;
            this.clearBtn5.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn5.FlatAppearance.BorderSize = 0;
            this.clearBtn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearBtn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearBtn5.Location = new System.Drawing.Point(637, 274);
            this.clearBtn5.Name = "clearBtn5";
            this.clearBtn5.Size = new System.Drawing.Size(23, 23);
            this.clearBtn5.TabIndex = 22;
            this.clearBtn5.Text = "x";
            this.clearBtn5.UseVisualStyleBackColor = false;
            this.clearBtn5.Visible = false;
            this.clearBtn5.Click += new System.EventHandler(this.clearBtn5_Click);
            // 
            // HauptFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(832, 445);
            this.ControlBox = false;
            this.Controls.Add(this.clearBtn5);
            this.Controls.Add(this.clearBtn4);
            this.Controls.Add(this.clearBtn3);
            this.Controls.Add(this.clearBtn2);
            this.Controls.Add(this.clearBtn1);
            this.Controls.Add(this.btnAlleTeilnehmer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loeschenBtn);
            this.Controls.Add(this.speichernBtn);
            this.Controls.Add(this.modulLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nachnameLbl);
            this.Controls.Add(this.vornameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.modulTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.nachnameTB);
            this.Controls.Add(this.vornameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.beendenBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HauptFenster";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teilnehmerverwaltung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.Button jsonOeffnenBtn;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox vornameTB;
        private System.Windows.Forms.TextBox nachnameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox modulTB;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label vornameLbl;
        private System.Windows.Forms.Label nachnameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label modulLbl;
        private System.Windows.Forms.Button speichernBtn;
        private System.Windows.Forms.Button loeschenBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAlleTeilnehmer;
        private System.Windows.Forms.Button jsonSpeichernBtn;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.Button clearBtn3;
        private System.Windows.Forms.Button clearBtn4;
        private System.Windows.Forms.Button clearBtn5;
        private System.Windows.Forms.Button csvSpeichernBtn;
    }
}

