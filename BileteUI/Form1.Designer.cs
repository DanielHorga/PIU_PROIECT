namespace BileteLELE
{
    partial class Form1
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
            this.Mesaj = new System.Windows.Forms.Label();
            this.MeciText = new System.Windows.Forms.TextBox();
            this.lblMeci = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.LocatieText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAcces = new System.Windows.Forms.Label();
            this.viprb = new System.Windows.Forms.RadioButton();
            this.normalrb = new System.Windows.Forms.RadioButton();
            this.NrBileteText = new System.Windows.Forms.TextBox();
            this.PretText = new System.Windows.Forms.TextBox();
            this.lblNrBilete = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtcauta = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.Mesaj2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Mesaj
            // 
            this.Mesaj.AutoSize = true;
            this.Mesaj.Location = new System.Drawing.Point(611, 161);
            this.Mesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(44, 16);
            this.Mesaj.TabIndex = 0;
            this.Mesaj.Text = "Mesaj";
            this.Mesaj.Click += new System.EventHandler(this.label1_Click);
            // 
            // MeciText
            // 
            this.MeciText.Location = new System.Drawing.Point(39, 36);
            this.MeciText.Margin = new System.Windows.Forms.Padding(4);
            this.MeciText.Name = "MeciText";
            this.MeciText.Size = new System.Drawing.Size(265, 22);
            this.MeciText.TabIndex = 1;
            // 
            // lblMeci
            // 
            this.lblMeci.AutoSize = true;
            this.lblMeci.Location = new System.Drawing.Point(36, 9);
            this.lblMeci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeci.Name = "lblMeci";
            this.lblMeci.Size = new System.Drawing.Size(39, 16);
            this.lblMeci.TabIndex = 2;
            this.lblMeci.Text = "MECI";
            this.lblMeci.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(324, 9);
            this.lblLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(63, 16);
            this.lblLocatie.TabIndex = 3;
            this.lblLocatie.Text = "LOCATIE";
            // 
            // LocatieText
            // 
            this.LocatieText.Location = new System.Drawing.Point(327, 36);
            this.LocatieText.Margin = new System.Windows.Forms.Padding(4);
            this.LocatieText.Name = "LocatieText";
            this.LocatieText.Size = new System.Drawing.Size(265, 22);
            this.LocatieText.TabIndex = 4;
            this.LocatieText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(614, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA MECI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(614, 118);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(104, 28);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblAcces
            // 
            this.lblAcces.AutoSize = true;
            this.lblAcces.Location = new System.Drawing.Point(411, 68);
            this.lblAcces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcces.Name = "lblAcces";
            this.lblAcces.Size = new System.Drawing.Size(76, 16);
            this.lblAcces.TabIndex = 10;
            this.lblAcces.Text = "TIP ACCES";
            // 
            // viprb
            // 
            this.viprb.AutoSize = true;
            this.viprb.Location = new System.Drawing.Point(360, 90);
            this.viprb.Margin = new System.Windows.Forms.Padding(4);
            this.viprb.Name = "viprb";
            this.viprb.Size = new System.Drawing.Size(49, 20);
            this.viprb.TabIndex = 11;
            this.viprb.TabStop = true;
            this.viprb.Text = "VIP";
            this.viprb.UseVisualStyleBackColor = true;
            // 
            // normalrb
            // 
            this.normalrb.AutoSize = true;
            this.normalrb.Location = new System.Drawing.Point(483, 88);
            this.normalrb.Margin = new System.Windows.Forms.Padding(4);
            this.normalrb.Name = "normalrb";
            this.normalrb.Size = new System.Drawing.Size(85, 20);
            this.normalrb.TabIndex = 12;
            this.normalrb.TabStop = true;
            this.normalrb.Text = "NORMAL";
            this.normalrb.UseVisualStyleBackColor = true;
            // 
            // NrBileteText
            // 
            this.NrBileteText.Location = new System.Drawing.Point(39, 88);
            this.NrBileteText.Margin = new System.Windows.Forms.Padding(4);
            this.NrBileteText.Name = "NrBileteText";
            this.NrBileteText.Size = new System.Drawing.Size(265, 22);
            this.NrBileteText.TabIndex = 13;
            // 
            // PretText
            // 
            this.PretText.Location = new System.Drawing.Point(614, 88);
            this.PretText.Margin = new System.Windows.Forms.Padding(4);
            this.PretText.Name = "PretText";
            this.PretText.Size = new System.Drawing.Size(265, 22);
            this.PretText.TabIndex = 14;
            // 
            // lblNrBilete
            // 
            this.lblNrBilete.AutoSize = true;
            this.lblNrBilete.Location = new System.Drawing.Point(36, 68);
            this.lblNrBilete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNrBilete.Name = "lblNrBilete";
            this.lblNrBilete.Size = new System.Drawing.Size(106, 16);
            this.lblNrBilete.TabIndex = 15;
            this.lblNrBilete.Text = "NUMAR BILETE";
            this.lblNrBilete.Click += new System.EventHandler(this.nrBilete_Click);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(611, 68);
            this.lblPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(44, 16);
            this.lblPret.TabIndex = 16;
            this.lblPret.Text = "PRET";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(775, 118);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(100, 28);
            this.btnAfiseaza.TabIndex = 17;
            this.btnAfiseaza.Text = "AFISEAZA";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtcauta
            // 
            this.txtcauta.Location = new System.Drawing.Point(614, 471);
            this.txtcauta.Margin = new System.Windows.Forms.Padding(4);
            this.txtcauta.Name = "txtcauta";
            this.txtcauta.Size = new System.Drawing.Size(261, 22);
            this.txtcauta.TabIndex = 19;
            this.txtcauta.TextChanged += new System.EventHandler(this.txtcauta_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(611, 428);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(48, 16);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID bilet";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(614, 512);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(261, 28);
            this.btnCauta.TabIndex = 21;
            this.btnCauta.Text = "CAUTA";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // Mesaj2
            // 
            this.Mesaj2.AutoSize = true;
            this.Mesaj2.Location = new System.Drawing.Point(-3, 557);
            this.Mesaj2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mesaj2.Name = "Mesaj2";
            this.Mesaj2.Size = new System.Drawing.Size(38, 16);
            this.Mesaj2.TabIndex = 22;
            this.Mesaj2.Text = "INFO";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 219);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(604, 321);
            this.dataGrid.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 689);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Mesaj2);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtcauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNrBilete);
            this.Controls.Add(this.PretText);
            this.Controls.Add(this.NrBileteText);
            this.Controls.Add(this.normalrb);
            this.Controls.Add(this.viprb);
            this.Controls.Add(this.lblAcces);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LocatieText);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblMeci);
            this.Controls.Add(this.MeciText);
            this.Controls.Add(this.Mesaj);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(945, 655);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mesaj;
        private System.Windows.Forms.TextBox MeciText;
        private System.Windows.Forms.Label lblMeci;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.TextBox LocatieText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAcces;
        private System.Windows.Forms.RadioButton viprb;
        private System.Windows.Forms.RadioButton normalrb;
        private System.Windows.Forms.TextBox NrBileteText;
        private System.Windows.Forms.TextBox PretText;
        private System.Windows.Forms.Label lblNrBilete;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtcauta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label Mesaj2;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

