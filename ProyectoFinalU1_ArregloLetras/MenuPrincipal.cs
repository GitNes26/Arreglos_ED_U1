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

        public MenuPrincipal()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            textBox1.Focus();

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Buscar.Text == "Buscar")
                {
                    
                    arreglo.buscar(Convert.ToChar(txBuscador.Text));
                    if (arreglo.Encontradas[0] != '\0')
                    { 
                        for (int i = 0; i < arreglo.Encontradas.Length; i++)
                        {
                            if (arreglo.Encontradas[i] != 0)
                            {
                                listBox2.Items.Add(i + 1 + " → " + arreglo.Encontradas[i]);
                            }
                        }
                    }
                    else
                    {
                        listBox2.Items.Add("No se encontro ninguna");
                        listBox2.Items.Add("letra '" + txBuscador.Text + "'");
                    }

                    Btn_Buscar.Text = "otra";
                }
                else
                {
                    listBox2.Items.Clear();
                    arreglo.limpiarBuscador();
                    txBuscador.Clear();
                    Btn_Buscar.Text = "Buscar";
                    txBuscador.Focus();
                }
            }
            catch (System.FormatException)

            {

                MessageBox.Show("El valor ingresado no es valido o no existe, intente con otra letra (Aa-Zz)", "VALOR INVALIDO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            //try
            //{

                listBox1.Items.Clear();
                arreglo.insertar(Convert.ToChar(textBox1.Text));
                    
                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i+1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                    textBox1.Clear();
                    //l++;
                    textBox1.Focus();
            //}
            //catch (System.FormatException)
            //{
            //    MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBox1.Clear();
            //    textBox1.Focus();

            //}
            //catch (System.IndexOutOfRangeException)
            //{
            //    MessageBox.Show("Arreglo Lleno.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    textBox1.Clear();
            //    Btn_Insertar.Enabled = false;
            //    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
            //    {
            //        if (arreglo.ArregloOrdenado[i] != 0)
            //        {
            //            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
            //        }
            //    }
            //}
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                arreglo.modificar(Convert.ToChar(textBox1.Text), Convert.ToChar(txReemplazar.Text));
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
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
            arreglo.eliminar(Convert.ToChar(textBox1.Text));
            textBox1.Clear();
            txReemplazar.Clear();
            txBuscador.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
            {
                if (arreglo.ArregloOrdenado[i] != 0)
                {
                    listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                }
            }
            textBox1.Clear();
            Btn_Insertar.Enabled = true;
            textBox1.Focus();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
