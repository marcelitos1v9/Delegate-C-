using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class matematica
    {
        public string mensagemsoma = " ";
        public string mensagemsubtracao = " ";
        public string mensagemmultiplicacao = " ";
        public string mensagemdivisao = " ";

        public void somar(int n1, int n2)
        {
            mensagemsoma = ("O resultado da soma é: " + (n1 + n2));
        }
        public void subtrair(int n1, int n2)
        {
            mensagemsubtracao = ("O resultado da subtração é: " + (n1 - n2));
        }
        public void multiplicar(int n1, int n2)
        {
            mensagemmultiplicacao = ("O resultado da multiplicação é: " + (n1 * n2));
        }
        public void dividir(int n1, int n2)
        {
            mensagemdivisao = ("O resultado da divisão é: " + (n1 / n2));
        }
    }
}
