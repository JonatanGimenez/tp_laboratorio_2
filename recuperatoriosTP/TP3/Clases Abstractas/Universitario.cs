using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        //atributos
        private int legajo;

        //constructores
        public Universitario() : base() { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        //metodos
        protected virtual string MostrarDatos()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(base.ToString());
            SB.AppendLine("LEGAJO NUMERO: " + this.legajo);

            return SB.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Universitario);
        }

        protected abstract string ParticiparEnClase();

        //Sobrecarga de operadores

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return (pg1.Equals(pg2) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo));
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }



    }
}
