using System.Windows.Forms;

namespace ProyectoFinalU1_ArregloLetras
{
    class ClaseArregloLetras
    {
        char[] arregloLetras = new char[5];
        char[] arregloFantasma = new char[5];
        char[] arregloOrdenado = new char[5];
        char[] patronABC = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] patronabc = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        //char letra, x;
        int a = 0, o = 0, u = 0;
        char[] encontrada = new char[5];
        //a=1
        //int + char letra=a  for letra==patorn letras(i) i 1 1 4 5 10 for if b mayor b+1 si mayor que si es menor se queda donde mismo 
        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        //public char Letra { get => letra; set => letra = value; }
        public char[] ArregloFantasma { get => arregloFantasma; set => arregloFantasma = value; }
        public char[] Encontrada { get => encontrada; set => encontrada = value; }
        public char[] ArregloOrdenado { get => arregloOrdenado; set => arregloOrdenado = value; }
        //public char X { get => x; set => x = value; }
        public char[] PatronABC { get => patronABC; set => patronABC = value; }
        public char[] Patronabc { get => patronabc; set => patronabc = value; }

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

        public void acomodo() //C
        {
            if (ArregloLetras != null)
            {
                o = 0;
                for (int i = 0; i < PatronABC.Length; i++)
                {
                    for (int j = 0; j < ArregloLetras.Length; j++)
                    {
                        if (ArregloLetras[j] == PatronABC[i])
                        {
                            ArregloFantasma[o] = ArregloLetras[j];
                            o++;
                        }
                    }
                    for (int j = 0; j < ArregloLetras.Length; j++)
                    {
                        if (ArregloLetras[j] == Patronabc[i])
                        {
                            ArregloFantasma[o] = ArregloLetras[j];
                            o++;
                        }
                    }
                }
                //u = 0;
                //for (int i = 0; i < ArregloLetras.Length; i++)
                //{
                //    for (int j = 0; j < ArregloLetras.Length; j++)
                //    {
                //        if (ArregloFantasma[j] == PatronABC[i])
                //        {
                //            ArregloOrdenado[u] = ArregloFantasma[j];
                //            u++;
                //        }
                //    }
                //    for (int j = 0; j < ArregloLetras.Length; j++)
                //    {
                //        if (ArregloFantasma[j] == Patronabc[i])
                //        {
                //            ArregloOrdenado[u] = ArregloFantasma[j];
                //            u++;
                //        }
                //    }
                //}
            }
        }

        public void insertar(char letra)
        {
            ArregloLetras[a] = letra;
            acomodo();
            a++;
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
                if (Eliminada == PatronABC[i])
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
