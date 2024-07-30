using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CINE.FORMULARIOS
{
    public partial class FORMULARIOTRABAJADOR : Form
    {
        public FORMULARIOTRABAJADOR()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaDeadPool dEADPOOL = new SalaDeadPool();
            this.Hide();
            dEADPOOL.Show();
        }

        private void FORMULARIOTRABAJADOR_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InicioSesion ini = new InicioSesion();
            this.Hide();
            ini.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaIntensamente dEADPOOL = new SalaIntensamente();
            this.Hide();
            dEADPOOL.Show();
        }
    }
}
