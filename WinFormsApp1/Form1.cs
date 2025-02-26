using ServiceReference1;
using System.Net;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Paso 1: Obtener los textos de los TextBox en el orden indicado
            string nifnie = textBox1.Text.Trim();
            string codigoSalaStr = textBox2.Text.Trim();
            string codigoDispositivoStr = textBox3.Text.Trim();
            string WSKey = textBox4.Text.Trim();

            // Convertir a enteros (se asume que codigoSala y codigoDispositivo son numéricos)
            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El código de sala no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoDispositivoStr, out int codigoDispositivo))
            {
                MessageBox.Show("El código de dispositivo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 2: Crear el objeto de request (RegistroAccesosType)
            var registro = new RegistroAccesosType
            {
                nifnie = nifnie,
                codigoSala = codigoSala,
                codigoDispositivo = codigoDispositivo,
                WSKey = WSKey
            };

            try
            {
                // Paso 3: Crear el cliente SOAP y llamar a la operación registrarAsync
                using (var client = new ControlAccesosClient())
                {
                    // Llamada asíncrona a la operación registrar con el objeto registro
                    var response = await client.registrarAsync(registro);

                    // Mostrar la respuesta (response.@out contiene el mensaje de salida)
                    MessageBox.Show("Respuesta SOAP:\n" + response.@out, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // En caso de error se muestra el mensaje de error
                MessageBox.Show("Error en la llamada SOAP:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}