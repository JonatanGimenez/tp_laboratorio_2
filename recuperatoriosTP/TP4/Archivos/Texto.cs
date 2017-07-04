using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string _archivo;

        public Texto(string archivo)
        {
            this._archivo = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                using (StreamWriter escritor = File.AppendText(this._archivo))
                {
                    escritor.WriteLine(datos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool leer(out List<string> datos)
        {
            List<string> listaAux = new List<string>();
            string linea;

            try
            {
                using (StreamReader lector = new StreamReader(this._archivo))
                {
                    while ((linea = lector.ReadLine()) != null)
                    {
                        listaAux.Add(linea);
                    }
                }

                datos = listaAux;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
