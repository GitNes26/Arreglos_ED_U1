using System;
using System.Windows.Forms;

namespace ProyectoFinalU1_ArregloLetras
{
    class ClaseArregloLetras
    {
        char[] arregloLetras = new char[5];
        char[] arregloOrdenado = new char[5];
        char[] patronABC = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] patronabc = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int a = 0, o = 0, c;
        char[] encontradas = new char[5];

        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        public char[] Encontradas { get => encontradas; set => encontradas = value; }
        public char[] ArregloOrdenado { get => arregloOrdenado; set => arregloOrdenado = value; }
        public char[] PatronABC { get => patronABC; set => patronABC = value; }
        public char[] Patronabc { get => patronabc; set => patronabc = value; }
        public int C { get => c; set => c = value; }
        public int A { get => a; set => a = value; }

        public void buscar(char Buscada)
        {
            for (int i = 0; i < ArregloOrdenado.Length; i++)
            {
                if (Buscada == ArregloOrdenado[i])
                {
                    Encontradas[i] = Buscada;
                }
            }
        }
        public void limpiarBuscador()
        {
            Array.Clear(Encontradas, 0, Encontradas.Length);
        }

        public void acomodo()
        {
            if (ArregloLetras != null)
            {
                o = 0; Array.Clear(ArregloOrdenado, 0, ArregloOrdenado.Length);
                for (int i = 0; i < PatronABC.Length; i++)
                {
                    for (int j = 0; j < ArregloLetras.Length; j++)
                    {
                        if (ArregloLetras[j] == PatronABC[i])
                        {
                            ArregloOrdenado[o] = ArregloLetras[j];
                            o++;
                        }
                    }
                    for (int j = 0; j < ArregloLetras.Length; j++)
                    {
                        if (ArregloLetras[j] == Patronabc[i])
                        {
                            ArregloOrdenado[o] = ArregloLetras[j];
                            o++;
                        }
                    }
                }
            }
        }

        public void insertar(char letra)
        {
            if (A < ArregloLetras.Length)
            {
                ArregloLetras[A] = letra;
                acomodo();
                A++;
            }
        }

        public void modificar(char Modificar, char Reemplazo)
        {
            for (int i = 0; i < ArregloOrdenado.Length; i++)
            {
                if (Modificar == ArregloLetras[i])
                {
                    ArregloLetras[i] = Reemplazo;
                }
            }
            acomodo();
        }

        public void eliminar(char Eliminada)
        {
            char t;
            C = 0;
            for (int i = 0; i < ArregloOrdenado.Length; i++)
            {
                if (Eliminada == ArregloLetras[i])
                {
                    Array.Clear(ArregloLetras, i, 1);
                    C++;
                    t = ArregloLetras[i];
                    for (int j = i; j < ArregloLetras.Length; j++)
                    {
                        if (j < ArregloLetras.Length-1)
                        {
                            ArregloLetras[j] = ArregloLetras[j + 1];
                        }
                        else
                        {
                            ArregloLetras[ArregloLetras.Length-1] = t;
                        }
                    }
                }
            }
            A -= C;
            
            acomodo();
        }

    }
}
