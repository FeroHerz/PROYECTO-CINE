using PROYECTO_CINE.CLASES;
using PROYECTO_CINE.FORMULARIOS.REPORTES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CINE.FORMULARIOS
{
    public partial class FORMULARIOADMIN : Form
    {
        public FORMULARIOADMIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_de_ventas venta = new Reporte_de_ventas();
            this.Hide();
            venta.Show();
        }

        private void FORMULARIOADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Cconexion y obtener la conexión
                Cconexion objC = new Cconexion();
                using (SqlConnection cn = objC.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string query = "UPDATE salaDEADpol SET Estado = 'disponible' WHERE SillaId BETWEEN 1 AND 20";

                        using (SqlCommand command = new SqlCommand(query, cn))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Estado de las sillas actualizado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("La conexión no está abierta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de las sillas: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FORMULARIOTRABAJADOR TRA = new FORMULARIOTRABAJADOR();
            this.Hide();
            TRA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Cconexion y obtener la conexión
                Cconexion objC = new Cconexion();
                using (SqlConnection cn = objC.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string query = "UPDATE salaIntensamente SET Estado = 'disponible' WHERE SillaId BETWEEN 1 AND 20";

                        using (SqlCommand command = new SqlCommand(query, cn))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Estado de las sillas actualizado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("La conexión no está abierta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de las sillas: " + ex.Message);
            }
        }
    }
}
