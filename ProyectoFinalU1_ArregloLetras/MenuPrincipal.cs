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
            this.Tt_Texto.SetToolTip(textBox1, "Ingrese una letra de la Aa-Zz (ya sea mayuscula o minuscula)");
            this.Tt_Texto.SetToolTip(Btn_Insertar, "Este botón, agregará la letra escrita arriba");
            this.Tt_Texto.SetToolTip(Btn_Eliminar, "Este botón, eliminará la letra escrita arriba (si la letra se repite en el arreglo, afectará a todas las iguales)");
            this.Tt_Texto.SetToolTip(Btn_Modificar, "Este botón, Modificará la letra escrita arriba-izquierda por la que se escriba arriba-derecha (si la letra se repite en el arreglo, afectará a todas las iguales)");
            this.Tt_Texto.SetToolTip(txModificar, "Ingrese la letra que desea modificar");
            this.Tt_Texto.SetToolTip(txReemplazar, "Ingrese la letra por la cual desea reemplazar");
            this.Tt_Texto.SetToolTip(Btn_Buscar, "Este botón, Buscará la letra escrita a lado");
            this.Tt_Texto.SetToolTip(Btn_Limpiar, "Este botón, Limpiará y reiniciará los valores en pantalla");
            this.Tt_Texto.SetToolTip(Btn_Salir, "Este botón, cerrará la aplicación 'MenúPrincipal'");
            this.Tt_Texto.SetToolTip(listBox1, "Área donde se muestra el arreglo de letras ordenadas Aa-Zz");
            this.Tt_Texto.SetToolTip(listBox2, "Área donde se muestran las buscadas");

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Buscar.Text == "Buscar")
                {
                    
                    arreglo.buscar(Convert.ToChar(txBuscador.Text));
                    
                    for (int i = 0; i < arreglo.Encontradas.Length; i++)
                    {
                        if (arreglo.Encontradas[i] != 0)
                        {
                            listBox2.Items.Add(i + 1 + " → " + arreglo.Encontradas[i]);
                        }
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
            try
            {
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
                    textBox1.Focus();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
                }
                textBox1.Clear();
                textBox1.Focus();

            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Arreglo Lleno.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                Btn_Insertar.Enabled = false;
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
                }
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                arreglo.modificar(Convert.ToChar(txModificar.Text), Convert.ToChar(txReemplazar.Text));
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
                }
                txModificar.Clear();
                txReemplazar.Clear();
                txModificar.Focus();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
                }
                txModificar.Clear();
                txReemplazar.Clear();
                txModificar.Focus();

            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                arreglo.eliminar(Convert.ToChar(textBox1.Text));
                textBox1.Clear();
                listBox1.Items.Clear();
                for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                {
                    if (arreglo.ArregloOrdenado[i] != 0)
                    {
                        listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                    }
                }
                Btn_Insertar.Enabled = true;
                textBox1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
        }     

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txModificar.Clear();
            txReemplazar.Clear();
            txBuscador.Clear();
            Btn_Buscar.Text = "Buscar";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Btn_Insertar.Enabled = true;
            arreglo.reiniciar();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    listBox1.Items.Clear();
                    arreglo.insertar(Convert.ToChar(textBox1.Text));

                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                    textBox1.Clear();
                    textBox1.Focus();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                    textBox1.Clear();
                    textBox1.Focus();

                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Arreglo Lleno.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    Btn_Insertar.Enabled = false;
                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                }
            }
        }

        private void txReemplazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    listBox1.Items.Clear();
                    arreglo.modificar(Convert.ToChar(txModificar.Text), Convert.ToChar(txReemplazar.Text));
                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                    txModificar.Clear();
                    txReemplazar.Clear();
                    txModificar.Focus();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("El dato que ingresaste no es valido, Favor de ingrezar una letra mayuscula o minuscula de la A -Z", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for (int i = 0; i < arreglo.ArregloOrdenado.Length; i++)
                    {
                        if (arreglo.ArregloOrdenado[i] != 0)
                        {
                            listBox1.Items.Add(i + 1 + " → " + arreglo.ArregloOrdenado[i]);
                        }
                    }
                    txModificar.Clear();
                    txReemplazar.Clear();
                    txModificar.Focus();

                }
            }
        }

        private void txBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (Btn_Buscar.Text == "Buscar")
                    {

                        arreglo.buscar(Convert.ToChar(txBuscador.Text));

                        for (int i = 0; i < arreglo.Encontradas.Length; i++)
                        {
                            if (arreglo.Encontradas[i] != 0)
                            {
                                listBox2.Items.Add(i + 1 + " → " + arreglo.Encontradas[i]);
                            }
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
        }

    }
}
