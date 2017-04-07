using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {
        //atributos

        Numero numero1 = new Numero();
        Numero numero2 = new Numero();


        //metodo Operar, recibe dos objetos del tipo Numero y un operador del tipo String.
        //valida que los objetos no sean null y que el operador sea valido.
        //retorna la operacion del switch del caso que corresponda a cada operador.

        public static double Operar(Numero numero1, Numero numero2, String operador)
        {
            double retorno = 0;
            
            if(numero1 != null && numero2 != null)
            {
               operador = _validarOperador(operador);

               switch (operador)
               {
                   case "+":
                       retorno = numero1.getNumero() + numero2.getNumero();
                       break;
                   case "-":
                       retorno = numero1.getNumero() - numero2.getNumero();
                       break;
                   case "*":
                       retorno = numero1.getNumero() * numero2.getNumero();
                       break;
                   case "/":
                       if (numero2.getNumero() != 0) //verifica que no sea una division por 0.
                       {
                           retorno = numero1.getNumero() / numero2.getNumero();
                       }
                       break;
               }
            }

            return retorno;
        }

        //valida que el operador recibido como parametro correcto.
        //en caso de no ser un operador valido retorna "+"
        private static String _validarOperador(String operador)
        {
            String retorno = "+";

            if (operador != null && (operador.Equals("+") || operador.Equals("-") || operador.Equals("*") || operador.Equals("/")))
            {
                retorno = operador;
            }

            return retorno;
        }
    }
}
