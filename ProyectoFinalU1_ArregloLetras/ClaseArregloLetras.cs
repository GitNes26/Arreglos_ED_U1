using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalU1_ArregloLetras
{
    class ClaseArregloLetras
    {
        char[] arregloLetras = new char[100];
        char letra;

        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        public char Letra { get => letra; set => letra = value; }

        public void buscar()
        {

        }

        public void insertar(char letra)
        {
            this.Letra = letra;

            if (ArregloLetras.Length < 100)
            {
                for
            }
            else
            {
                MessageBox.Show("Arreglo lleno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

    }
}
