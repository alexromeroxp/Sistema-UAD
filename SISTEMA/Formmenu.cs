using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void aLUMNOToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificaralumno m = new FormModificaralumno();
            m.Show();
        }

        private void aLUMNOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgregaralumno m = new FormAgregaralumno();
            m.Show();
        }

        private void mAESTROToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgregarMaestro m = new FormAgregarMaestro();
            m.Show();
        }

        private void aLUMNOToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminarAlumno m = new FormEliminarAlumno();
            m.Show();
        }

        private void mAESTROToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminarmaestro m = new FormEliminarmaestro();
            m.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultaralumno m = new FormConsultaralumno();
            m.Show();
        }

        private void ConsultarMaestro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarmaestro m = new FormConsultarmaestro();
            m.Show();
        }

        private void mAESTROToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificarmaestro m = new FormModificarmaestro();
            m.Show();
        }

        private void mATERIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgregarmateria m = new FormAgregarmateria();
            m.Show();

        }

        private void mATERIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminarmateria m = new FormEliminarmateria();
            m.Show();
        }

        private void mATERIAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultarmateria m = new FormConsultarmateria();
            m.Show();
        }

        private void mATERIAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificarmateria m = new FormModificarmateria();
            m.Show();
        }
    }
}
