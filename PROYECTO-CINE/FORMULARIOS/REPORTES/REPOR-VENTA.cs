using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CINE.FORMULARIOS.REPORTES
{
    public partial class Reporte_de_ventas : Form
    {
        public Reporte_de_ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reporte_de_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cINEDataSet2.Reservas' Puede moverla o quitarla según sea necesario.
            this.reservasTableAdapter.Fill(this.cINEDataSet2.Reservas);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMULARIOADMIN admin = new FORMULARIOADMIN();
            this.Hide();
            admin.Show();
        }
    }
}
