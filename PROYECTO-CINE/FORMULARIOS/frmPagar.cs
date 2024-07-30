using PROYECTO_CINE.CLASES;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO_CINE.FORMULARIOS
{
    public partial class frmPagar : Form
    {
        public frmPagar(string silla, string pelicula, int total, int suelto, int suelto1)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asigna los valores a los controles del formulario
            txtSilla.Text = silla;
            txtPelicula.Text = pelicula;
            txtTotal.Text = total.ToString();
            txtSuelto.Text = suelto.ToString();
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            // Código para manejar la carga del formulario, si es necesario
        }

       

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string pelicula = txtPelicula.Text;
            string nombreCliente = txtNombreCliente.Text;
            string dni = txtDNI.Text;
            string silla = txtSilla.Text;
            decimal total = decimal.Parse(txtTotal.Text);
            decimal suelto = decimal.Parse(txtSuelto.Text);

            try
            {
                // Crear una instancia de Cconexion y obtener la conexión
                Cconexion objC = new Cconexion();
                using (SqlConnection cn = objC.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO Reservas (Pelicula, NombreCliente, DNI, Silla, Total, Suelto) VALUES (@Pelicula, @NombreCliente, @DNI, @Silla, @Total, @Suelto)";

                        using (SqlCommand command = new SqlCommand(query, cn))
                        {
                            command.Parameters.AddWithValue("@Pelicula", pelicula);
                            command.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                            command.Parameters.AddWithValue("@DNI", dni);
                            command.Parameters.AddWithValue("@Silla", silla);
                            command.Parameters.AddWithValue("@Total", total);
                            command.Parameters.AddWithValue("@Suelto", suelto);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pago realizado con éxito");
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("La conexión no está abierta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el pago: " + ex.Message);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
