using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        ETipo _tipo;
        private short _cantidadDeCalorias;

        public enum ETipo 
        { 
            Entera, 
            Descremada 
        }

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo) : base(marca, codigoDeBarras, color)
        {
            _tipo = tipo;
            this._cantidadDeCalorias = 20;
        }
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color) : this(marca, codigoDeBarras, color, ETipo.Entera)
        {
        }


        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return this._cantidadDeCalorias;
            }
            set
            {
                this._cantidadDeCalorias = value;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CALORIAS: " + this.CantidadCalorias);
            sb.AppendLine("TIPO: " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
