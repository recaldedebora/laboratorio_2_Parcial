using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recalde.Debora._23
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        private DateTime nacimiento;
        protected string nombre;
        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            barrioResidencia = string.Empty;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }
        public int Edad
        {
            get 
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            } 
        }
        public string NombreCompleto
        {
            get
            {
                return $"{apellido}, {nombre}";
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(NombreCompleto);
            return sb.ToString();
        }
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());
            return sb.ToString();
        }
        internal abstract string FichaExtra();
    }
}
