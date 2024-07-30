using PROYECTO_CINE.CLASES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTO_CINE.FORMULARIOS
{
    public partial class SalaDeadPool : Form
    {
        private List<int> sillasSeleccionadas = new List<int>();
        private const int precioSilla = 200;

        public SalaDeadPool()
        {
            InitializeComponent();
             this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SalaDeadPool_Load(object sender, EventArgs e)
        {
            this.salaDEADpolTableAdapter.Fill(this.cINEDataSet.salaDEADpol);
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            ActualizarBoton(button1, 0);
            ActualizarBoton(button2, 1);
            ActualizarBoton(button3, 2);
            ActualizarBoton(button4, 3);
            ActualizarBoton(button5, 4);
            ActualizarBoton(button6, 5);
            ActualizarBoton(button7, 6);
            ActualizarBoton(button8, 7);
            ActualizarBoton(button9, 8);
            ActualizarBoton(button10, 9);
            ActualizarBoton(button11, 10);
            ActualizarBoton(button12, 11);
            ActualizarBoton(button13, 12);
            ActualizarBoton(button14, 13);
            ActualizarBoton(button15, 14);
            ActualizarBoton(button16, 15);
            ActualizarBoton(button17, 16);
            ActualizarBoton(button18, 17);
            ActualizarBoton(button19, 18);
            ActualizarBoton(button20, 19);
        }

        private void ActualizarBoton(Button boton, int indiceFila)
        {
            if (dataGridView1.Rows.Count > indiceFila && dataGridView1.Rows[indiceFila].Cells[1].Value != null)
            {
                string estado = dataGridView1.Rows[indiceFila].Cells[1].Value.ToString();
                boton.Text = estado;

                if (estado.Equals("Ocupado", StringComparison.OrdinalIgnoreCase))
                {
                    boton.BackColor = Color.Red;
                }
                else if (estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase))
                {
                    boton.BackColor = Color.Green;
                }
                else
                {
                    boton.BackColor = SystemColors.Control; // Color predeterminado del botón
                }

                boton.Tag = indiceFila + 1; // Almacena el número de silla en la propiedad Tag del botón
                boton.Click += Button_Click; // Asigna el evento Click
            }
            else
            {
                boton.Text = "Valor no disponible";
                boton.BackColor = SystemColors.Control; // Color predeterminado del botón
                boton.Tag = null;
            }
        }

        private void VerificarYActualizarSilla(Button boton)
        {
            if (boton != null && boton.Tag != null)
            {
                int numeroSilla = (int)boton.Tag;
                string estado = boton.Text;

                if (estado.Equals("Ocupado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La silla está ocupada y no se puede seleccionar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (sillasSeleccionadas.Contains(numeroSilla))
                    {
                        sillasSeleccionadas.Remove(numeroSilla);
                        boton.BackColor = Color.Green;
                    }
                    else
                    {
                        sillasSeleccionadas.Add(numeroSilla);
                        boton.BackColor = Color.Yellow;
                    }

                    // Actualizar la lista de sillas y el total
                    txtsilla.Text = string.Join(", ", sillasSeleccionadas);
                    int total = sillasSeleccionadas.Count * precioSilla;
                    txtTotal.Text = total.ToString();
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            VerificarYActualizarSilla(boton);
        }

        private void txtsilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (sillasSeleccionadas.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(txtpago.Text))
                {
                    int total = int.Parse(txtTotal.Text);
                    int pago = int.Parse(txtpago.Text);

                    // Añadir la condición para verificar que el pago sea igual o mayor al total
                    if (pago >= total)
                    {
                        Cconexion objC = new Cconexion();
                        SqlConnection cn = objC.leer();

                        if (cn.State == ConnectionState.Open)
                        {
                            foreach (int silla in sillasSeleccionadas)
                            {
                                ActualizarEstadoSilla(cn, silla, "Ocupado");
                            }
                            ActualizarBotones();

                            // Recoger los valores para pasar al formulario de pago
                            string sillas = string.Join(", ", sillasSeleccionadas);
                            string pelicula = txtPelicula.Text;
                            int suelto = int.Parse(txtSuelto.Text);

                            // Abrir el formulario de pago y pasar los valores
                            frmPagar frmPagar = new frmPagar(sillas, pelicula, total, pago, suelto);

                            frmPagar.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("La conexión a la base de datos no está abierta.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pago debe ser igual o mayor al total.", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El campo de pago no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione al menos una silla antes de proceder con el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ActualizarEstadoSilla(SqlConnection cn, int sillaId, string nuevoEstado)
        {
            string query = "UPDATE salaDEADpol SET Estado = @NuevoEstado WHERE SillaId = @SillaId";
            SqlCommand command = new SqlCommand(query, cn);
            command.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
            command.Parameters.AddWithValue("@SillaId", sillaId);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pago realizado con éxito. El estado de la silla ha sido actualizado a ocupado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el estado de la silla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el estado de la silla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el valor del suelto cuando cambie el total
            ActualizarSuelto();
        }

        private void txtPelicula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el valor del suelto cuando cambie el pago
            ActualizarSuelto();
        }

        private void ActualizarSuelto()
        {
            if (int.TryParse(txtTotal.Text, out int total) && int.TryParse(txtpago.Text, out int pago))
            {
                int suelto = pago - total;
                txtSuelto.Text = suelto.ToString();
            }
            else
            {
                txtSuelto.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FORMULARIOTRABAJADOR FORT = new FORMULARIOTRABAJADOR();
            this.Hide();
            FORT.Show();
        }

        private void txtSuelto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
