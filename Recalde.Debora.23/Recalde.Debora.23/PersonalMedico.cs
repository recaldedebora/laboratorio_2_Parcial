using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Recalde.Debora._23
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }
        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {esResidente}");
            sb.AppendLine($"ATENCIONES:");
            foreach (Consulta consulta in consultas)
            {
                sb.Append(consulta.ToString());
            }
            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            if (doctor != null && paciente != null)
            {
                Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(nuevaConsulta);
                return nuevaConsulta;
            }
            return null;
        }
    }
}
