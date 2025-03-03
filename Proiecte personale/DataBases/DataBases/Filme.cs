using DataBases.MovieDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBases
{
    public partial class Filme : Form
    {
        public Filme()
        {
            InitializeComponent();
        }

        private void Filme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.movieDataSet.Film);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            //(@REGIZOR, @AN_AP, @TITLU, @DURATA);
            string regizor = txtRegizor.Text; 
            int an_ap = 0;
            try
            {
                 an_ap = int.Parse(txtAnAP.Text);
            }
            catch
            {
                MessageBox.Show("An de aparitie invalid", "An invlaid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnAP.Text = string.Empty;
                return;
            }
            int durata = 0 ;
            string titlu = txtTitlu.Text;
            try
            {
                durata = int.Parse(txtDurata.Text);
            }
            catch
            {
                MessageBox.Show("Durata invalida", "Durata invlaida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDurata.Text = string.Empty;
                return;
            }

            filmTableAdapter.InsertMovie(regizor, an_ap, titlu, durata);
            filmTableAdapter.Fill(movieDataSet.Film);
        }

        string regizorName = string.Empty;

        private void txtChooseRegizor_TextChanged(object sender, EventArgs e)
        {
            regizorName = txtChooseRegizor.Text;

            filmTableAdapter.RegizorSort(movieDataSet.Film, regizorName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtRegizorUpdate.Text;
            int an = int.Parse(txtAN_AP.Text);
            string titlu = txtTitluUpdate.Text;
            int durata = int.Parse(txtDurataUpdate.Text);

            filmTableAdapter.UpdateFilm(name, an, titlu, durata, id);
            filmTableAdapter.Fill(movieDataSet.Film);
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            int ls = int.Parse(txtLS.Text);
            int ld = int.Parse(txtLD.Text);

            filmTableAdapter.BetweenDurata(movieDataSet.Film, ls, ld);
        }
    }
}
