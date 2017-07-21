using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Models
{
    public abstract class Persona:IEnteInstituto //public sealed no puede heredar
    {
        public static int ContadorPersonas = 0;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        protected int Inasistencias { get; set; }
        public string NombreCompleto
        {
            get
            {
                //return Nombre + " " + Apellido;¡
                //return string.Format("{0} {1}", "Nombre", "Apellido")
                return $"{Nombre}{Apellido}";
            }
        }

        public string CodigoInterno { get; set; }

        static Persona()
        {
            ContadorPersonas++;
            //ContadorPersonas += 1;
        }
        public abstract string ConstruirResumen();

        public string ConstruirLlaveSecreta(string nombreEnte)
        {
            var rnd = new Random();
            return rnd.Next(1, 998795).ToString();
           
        }
    }
}
