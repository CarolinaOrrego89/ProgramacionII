using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmEstadistica = new Form1();
            frmEstadistica.MdiParent = this;
                 frmEstadistica.Show();

        }

        private void conversoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversores frmconversores = new conversores();
            frmconversores.MdiParent = this;
            frmconversores.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            conversores frmconversores = new conversores();
            frmconversores.MdiParent = this;
            frmconversores.Show();
            lblformularioActivo.Text = frmconversores.Text;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 frmEstadistica = new Form1();
            frmEstadistica.MdiParent = this;
            frmEstadistica.Show();
            lblformularioActivo.Text = frmEstadistica.Text;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
       
            lblstatusfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblformularioActivo_Click(object sender, EventArgs e)
        {

        }
    }
}
