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
        char[] arregloFantasma = new char[100];
        char[] patronLetras = new char[54] {'A','a','B','b','C','c','D','d','E','e','F','f','G','g','H','h','I','i','J','j','K','k','L','l','M','m',
            'N','n','Ñ','ñ','O','o','P','p','Q','q','R','r','S','s','T','t','U','u','V','v','W','w','X','x','Y','y','Z','z'};
        char letra;
        char[] encontrada = new char[100];

        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        public char Letra { get => letra; set => letra = value; }
        public char[] ArregloFantasma { get => arregloFantasma; set => arregloFantasma = value; }
        public char[] PatronLetras { get => patronLetras; set => patronLetras = value; }
        public char[] Encontrada { get => encontrada; set => encontrada = value; }

        public void buscar(char Buscada)
        {
            for (int i = 0; i < ArregloLetras.Length; i++)
            {
                if (Buscada == ArregloLetras[i])
                {
                    Encontrada[i] = Buscada;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es valido o no existe, intente con otra letra (Aa-Zz)", "VALOR INVALIDO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void insertar()
        {
            for (int i = 0; i < ArregloLetras.Length; i++)
            {
                ArregloLetras[i] = Letra;

                //for (int f = 0; f < ArregloFantasma.Length; f++)
                //{
                //    if (ArregloLetras[i] < ArregloFantasma[f])
                //    {

                //    }
                //}
            }
            
        }

        public void modificar(char Modificar, char Reemplazo)
        {
            for (int i = 0; i < ArregloLetras.Length; i++)
            {
                if (Modificar == ArregloLetras[i])
                {
                    arregloLetras[i] = Reemplazo;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es valido o no existe, intente con otra letra (Aa-Zz)", "VALOR INVALIDO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void eliminar(char Eliminada)
        {
            for (int i = 0; i < ArregloFantasma.Length; i++)
            {
                if (Eliminada == PatronLetras[i])
                {
                    
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es valido o no existe, intente con otra letra (Aa-Zz)", "VALOR INVALIDO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}
