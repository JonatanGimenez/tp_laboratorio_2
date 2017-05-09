using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2017
{
    public class Snacks : Producto
    {

        private short _cantidadDeCalorias;

        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color): base(marca, codigoDeBarras, color)
        {
            this._cantidadDeCalorias = 104;
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
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

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.ToString());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
