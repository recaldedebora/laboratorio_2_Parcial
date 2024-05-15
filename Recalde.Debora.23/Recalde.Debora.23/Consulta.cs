using System.Text;

namespace Recalde.Debora._23
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        public DateTime Fecha { get => fecha; }
        internal Paciente Paciente { get => paciente; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Fecha} se ha atendido a {paciente.NombreCompleto}");

            return sb.ToString();
        }
    }
}