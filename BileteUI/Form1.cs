using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BileteLibrary;
using BILETETOT;

namespace BileteLELE
{
    public partial class Form1 : Form
    {
        Admnistrare adminBilete;

        private int nrBilet = 0;
        private int nextIdBilet = 1;
        public Form1()
        {
            string NumeFisierBilete = ConfigurationManager.AppSettings["NumeFisierBilete"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierBilete = locatieFisierSolutie + "\\" + NumeFisierBilete;
            adminBilete = new Admnistrare(caleCompletaFisierBilete);
            InitializeComponent();
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9 , FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii Meci";
            viprb.Text = "VIP";
            normalrb.Text = "NORMAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mesaj.Text = "";
            Mesaj.ForeColor = Color.Blue;
        }

        private void AfiseazaBiletele()
        {
            dataGrid.Columns.Add("Nume", "Meci");
            dataGrid.Columns.Add("Oras", "Locatie");
            dataGrid.Columns.Add("Data ", "Data");
            dataGrid.Columns.Add("Bilete", "NrBilete");
            dataGrid.Columns.Add("Pret", "Pret");

            int numarBilete = 0;
            Bilete[] bilete = adminBilete.getBilete(out numarBilete);

            var i = 0;
            foreach (var bilet in bilete)
            {
                if (bilet == null) break;
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = bilet.Meci;
                dataGrid.Rows[i].Cells[1].Value = bilet.LocatieMeci;
                dataGrid.Rows[i].Cells[2].Value = bilet.DataMeci;
                dataGrid.Rows[i].Cells[3].Value = bilet.NumarBilete;
                dataGrid.Rows[i].Cells[4].Value = bilet.PretBilete;
                i++;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nrBilete_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Int32.TryParse(NrBileteText.Text, out int nrBil);
            Int32.TryParse(PretText.Text, out int pret);
            string intrare = "";
            if (!DateInvalide())
            {
                Mesaj.Text = "EROARE!";
                return;
            }
            Mesaj.Text = "";
            
            if(viprb.Checked)
            {
                intrare = viprb.Text;
            }
            if (normalrb.Checked)
            {
                intrare = normalrb.Text;
            }

            Bilete bilete = new Bilete( nextIdBilet, MeciText.Text, LocatieText.Text, intrare, nrBil, pret, dateTimePicker1.Value);
            adminBilete.AddBilet(bilete);
            Mesaj.Text = "Biletul a fost plasat cu succes";
            Resetare();
        }

        private bool DateInvalide()
        {
            string meci = MeciText.Text;
            string locatie = LocatieText.Text;
            if( !(Int32.TryParse(NrBileteText.Text, out int nrBil)))
            {
                nrBil = -1;
            }
            if(!(Int32.TryParse(PretText.Text, out int pret)))
            {
                pret = -1;
            }
            bool ok = true;

            if (meci.Length < 1)
            {
                lblMeci.ForeColor = Color.Blue;
                ok = false;
            }
            else
            {
                lblMeci.ForeColor = Color.DarkOrange;
            }

            if (locatie.Length < 1)
            {
                lblLocatie.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblLocatie.ForeColor = Color.DarkOrange;
            }

            if (nrBil < 0)
            {
                lblNrBilete.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblNrBilete.ForeColor= Color.DarkOrange;
            }
            if (pret < 0)
            {
                lblPret.ForeColor = Color.Red;
                ok = false;
            }
            else
            {
                lblPret.ForeColor = Color.DarkOrange;
            }
            if ( !viprb.Checked && !normalrb.Checked ) 
            {
                lblAcces.ForeColor = Color.Red;
                ok = false;
            }
            else
            { 
                lblAcces.ForeColor = Color.DarkOrange;
            }

            return ok;
        }

        private void Resetare()
        { 
            MeciText.Text = LocatieText.Text = NrBileteText.Text = PretText.Text = string.Empty;
            viprb.Checked = false;
            normalrb.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaBiletele();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string mesaj = "";
            Bilete bilete = new Bilete();
            if (!int.TryParse(txtcauta.Text, out int id))
            {
                lblId.ForeColor = Color.Red;
                ok = false;
                Mesaj2.Text = "ID nu exista!\n";
            }
            else
            {
                bilete = adminBilete.getBilet(id);
                if (bilete.IdBilet != 0)
                {
                    lblId.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lblId.ForeColor = Color.Red;
                    ok = false;
                    Mesaj2.Text = "Biletul nu exista\n";
                }
            }
            Mesaj2.Text = mesaj;
            if (!ok) return;
            Mesaj2.Text = bilete.Info();
            Mesaj2.ForeColor = Color.Blue;
        }

        private void txtcauta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
