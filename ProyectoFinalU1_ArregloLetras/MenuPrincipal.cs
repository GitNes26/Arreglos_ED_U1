using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalU1_ArregloLetras
{
    public partial class MenuPrincipal : Form
    {
        ClaseArregloLetras arreglo = new ClaseArregloLetras();
        int l = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                arreglo.insertar(Convert.ToChar(textBox1.Text));
                for (int i = 0; i < arreglo.ArregloLetras.Length; i++)
                {
                    listBox1.Items.Add(arreglo.ArregloLetras[i]);
                }
                textBox1.Clear();
                l++;
                textBox1.Focus();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();

            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Arreglo Lleno.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Enabled = false;
                Btn_Insertar.Enabled = false;
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Modificar.Text == "Modificar")
                {
                    groupBox1.Visible = true;

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
