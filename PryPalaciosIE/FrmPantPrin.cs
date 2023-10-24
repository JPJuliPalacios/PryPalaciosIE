using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPalaciosIE
{
    public partial class FrmPantPrin : Form
    {
        public FrmPantPrin()
        {
            InitializeComponent();
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarProv frmMostrarProv = new frmMostrarProv();
            frmMostrarProv.ShowDialog();
            this.Close();
        }

        private void cargarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProv frmCargaProv = new frmCargaProv();
            frmCargaProv.ShowDialog();
            this.Close();
        }
    }
}
