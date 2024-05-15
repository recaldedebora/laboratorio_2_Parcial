using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recalde.Debora._23
{
    public class Paciente : Persona
    {
        private string diagnostico;
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        {
            diagnostico = string.Empty;
        }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {barrioResidencia}");
            sb.AppendLine($"Diagnostico: {diagnostico}");
            return sb.ToString();

        }
    }
}
