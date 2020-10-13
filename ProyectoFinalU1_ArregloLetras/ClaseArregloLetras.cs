using System.Windows.Forms;

namespace ProyectoFinalU1_ArregloLetras
{
    class ClaseArregloLetras
    {
        char[] arregloLetras = new char[5];
        char[] arregloFantasma = new char[5];
        int[] letrasEnumeradas = new int[5];
        char[] patronLetras = new char[54] {'A','a','B','b','C','c','D','d','E','e','F','f','G','g','H','h','I','i','J','j','K','k','L','l','M','m',
            'N','n','Ñ','ñ','O','o','P','p','Q','q','R','r','S','s','T','t','U','u','V','v','W','w','X','x','Y','y','Z','z'};
        char letra, x;
        int o = 0, u= 0, a = 0;
        char[] encontrada = new char[5];
        //a=1
        //int + char letra=a  for letra==patorn letras(i) i 1 1 4 5 10 for if b mayor b+1 si mayor que si es menor se queda donde mismo 
        public char[] ArregloLetras { get => arregloLetras; set => arregloLetras = value; }
        public char Letra { get => letra; set => letra = value; }
        public char[] ArregloFantasma { get => arregloFantasma; set => arregloFantasma = value; }
        public char[] PatronLetras { get => patronLetras; set => patronLetras = value; }
        public char[] Encontrada { get => encontrada; set => encontrada = value; }
        public int[] LetrasEnumeradas { get => letrasEnumeradas; set => letrasEnumeradas = value; }
        public char X { get => x; set => x = value; }

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

        public void insertar(char l) //C
        {
            for (int i = 0; i < PatronLetras.Length; i++)
            {
                if (l == PatronLetras[i]) //Posiscion 5
                {
                    LetrasEnumeradas[o] = i; //letrasEnu[0]=5
                    break;
                }
            }
            for (int i = 0; i < LetrasEnumeradas.Length; i++)
            {
                for (int j = 1; j < LetrasEnumeradas.Length; j++) //5
                {
                    if (LetrasEnumeradas[i] >= LetrasEnumeradas[j]) //i[0]=5 == letrasEnum[0]=0
                    {
                        for (int k = 0; k < ArregloFantasma.Length; k++)
                        {

                        }
                        ArregloLetras[j] = l;
                        o++; u++;
                        break;
                    }
                    
                }break;
            }
        }
            //for (int i = 0; i < ArregloLetras.Length; i++)
            //{
            //    for (int G = 0; G < PatronLetras.Length; G++)
            //    {
            //        ArregloFantasma[G] = PatronLetras[i];

            //    }
            //}

            //for (int i = 0; i < LetrasEnumeradas.Length; i++)
            //{
            //    if (LetrasEnumeradas[i] > LetrasEnumeradas[i + 1]) //5>0
            //    {
            //        break;
            //    }
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    if (LetrasEnumeradas)
            //    {
                    //int Aux = LetrasEnumeradas[Z];
                    //LetrasEnumeradas[Z] = LetrasEnumeradas[Z + 1];
                    //LetrasEnumeradas[Z + 1] = Aux;
            //    }
            //}
        //}
        public void insertar2(char letra)
        {
            ArregloLetras[a] = letra;
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
