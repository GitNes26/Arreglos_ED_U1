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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.Height = 350;
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }

        private void Btn_Creditos_Click(object sender, EventArgs e)
        {
            if (Btn_Creditos.Text == "Créditos (↓)"){
                this.Height = 600;
                Btn_Creditos.Text = "Créditos (↑)";
            }
            else {
                this.Height = 350;
                Btn_Creditos.Text = "Créditos (↓)";
            }
        }
    }
}
