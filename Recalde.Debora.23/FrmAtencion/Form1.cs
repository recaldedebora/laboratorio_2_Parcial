using Recalde.Debora._23;
namespace FrmAtencion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedIndex > -1 && lstPacientes.SelectedIndex > -1)
            {
                PersonalMedico medicoSeleccionado = (PersonalMedico)lstMedicos.SelectedItem;
                Paciente pacienteSeleccionado = (Paciente)lstPacientes.SelectedItem;
                pacienteSeleccionado.Diagnostico = "Paciente curado";
                Consulta nuevaConsulta = medicoSeleccionado + pacienteSeleccionado;
                MessageBox.Show(nuevaConsulta.ToString(), "Atención finalizada", MessageBoxButtons.OK);
                lstMedicos.SelectedItems.Clear();
                lstPacientes.SelectedItems.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedIndex > -1)
            {
                PersonalMedico medicoSeleccionado = (PersonalMedico)lstMedicos.SelectedItem;
                rtbInfoMedico.Text = medicoSeleccionado.FichaExtra();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmarSalida())
            {
                e.Cancel = true;
            }
        }

        private bool ConfirmarSalida()
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }
    }
}