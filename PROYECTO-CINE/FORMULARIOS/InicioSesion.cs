using PROYECTO_CINE.CLASES;
using PROYECTO_CINE.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CINE
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtContra.Text;

            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor ingresar los datos");
            }
            else
            {
                Cconexion objC = new Cconexion();
                SqlConnection cn = objC.leer();
                if (cn.State == ConnectionState.Open)
                {
                    try
                    {
                        
                        string query = "SELECT Roles_ID FROM Usuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @pass";
                        SqlCommand comando = new SqlCommand(query, cn);

                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@pass", pass);
                        SqlDataReader rs = comando.ExecuteReader();

                        int rolesId = -1;

                        if (rs.HasRows)
                        {
                            while (rs.Read())
                            {
                                rolesId = rs.GetInt32(rs.GetOrdinal("Roles_ID"));
                            }

                            switch (rolesId)
                            {
                                case 1:
                                    FORMULARIOADMIN frmPrincipal = new FORMULARIOADMIN();
                                    MessageBox.Show("Bienvenido" + " " + usuario + " " + "CINESCHAPIN");
                                    frmPrincipal.Show();
                                    break;
                                case 2:
                                    FORMULARIOTRABAJADOR frm = new FORMULARIOTRABAJADOR();
                                    MessageBox.Show("Bienvenido" + " " + usuario + " " + "CINESCHAPIN");
                                    frm.Show();
                                    break;
                                default:
                                    MessageBox.Show("El usuario no tiene un rol válido.");
                                    break;
                            }

                            this.Hide();
                        }
                        else
                        {
                            txtUsuario.Text = "";
                            txtContra.Text = "";
                            MessageBox.Show("Datos incorrectos. Por favor revisar datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar conectar: " + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
