using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        //atributo
        public double miNumero;

        //constructores

        //constructor que no recibe parametros e inicializa en 0.
        public Numero()
        {
            this.miNumero = 0;
        }
        //constructor que recibe un parametro del tipo string y lo setea por medio del metodo SetNumero.
        public Numero(String NumeroString)
        {
            SetNumero(NumeroString);
        }
        //constructor que recibe un double como parametro y lo asigna como valor.
        public Numero(double Numero)
        {
            this.miNumero = Numero;
        }

        //metodos

        //metodo que retorna el valor del objeto tipo Numero.
        public double getNumero()
        {
            return this.miNumero;
        }

        //metodo que recibe un string y valida que sea un double
        //si es double retorna 1, si no lo es retorna 0.
        private static double validarNumero(String numeroString)
        {
            double numero = 0;

            if(numeroString != null && numeroString != "")
            {
                numero = 1;
            }

            return numero;
        }

        //metodo que recibe un parametro del tipo string, valida que sea double y lo asigna por medio del tryparse.
        //si el parametro no es double, el valor asignado es 0.
        private void SetNumero(String numeroString)
        {
            if (numeroString != null && validarNumero(numeroString) != 0)
            {
                double.TryParse(numeroString, out this.miNumero);
            }
            else
            {
                this.miNumero = 0;
            }
        }
    }
}
//tenia los nombres de los metodos con "_" pero lo modifique para que quede como lo pide el enunciado del TP.
