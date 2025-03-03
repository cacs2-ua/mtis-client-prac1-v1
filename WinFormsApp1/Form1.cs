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
            this.AutoScroll = true;
            this.WindowState = FormWindowState.Maximized;
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

        /*

        private async void button1_Click(object sender, EventArgs e)
        {
            // Paso 1: Obtener los textos de los TextBox en el orden indicado
            string nifnie = textBox1.Text.Trim();
            string codigoSalaStr = textBox2.Text.Trim();
            string codigoDispositivoStr = textBox3.Text.Trim();

            // Paso 1.1: Leer la WSKey desde el archivo de texto en la carpeta "resources"
            string wsKeyFilePath = System.IO.Path.Combine(Application.StartupPath, "resources", "wskey.txt");

            if (!System.IO.File.Exists(wsKeyFilePath))
            {
                MessageBox.Show("El archivo wskey.txt no se encontr� en la carpeta resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = System.IO.File.ReadAllText(wsKeyFilePath).Trim();

            // Convertir a enteros (se asume que codigoSala y codigoDispositivo son num�ricos)
            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El c�digo de sala no es v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoDispositivoStr, out int codigoDispositivo))
            {
                MessageBox.Show("El c�digo de dispositivo no es v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Paso 3: Crear el cliente SOAP y llamar a la operaci�n registrarAsync
                using (var client = new ControlAccesosClient())
                {
                    var response = await client.registrarAsync(registro);

                    // Mostrar la respuesta
                    MessageBox.Show("Respuesta SOAP:\n" + response.@out, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la llamada SOAP:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Limpia el contenido anterior del panel
            panelContenedor.Controls.Clear();

            // Crea una nueva instancia del UserControl correspondiente
            ucEmpleados uc = new ucEmpleados();

            // Ajusta el ancho del UserControl para que sea exactamente el mismo que el del panel
            uc.Width = panelContenedor.ClientSize.Width;

            // Opcional: anclar el control a la esquina superior izquierda para que se mantenga en su posici�n
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Agrega el UserControl al panel
            panelContenedor.Controls.Add(uc);

        }

        private void ControlAccesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Limpia el contenido anterior del panel
            panelContenedor.Controls.Clear();

            // Crea una nueva instancia del UserControl correspondiente
            ucControlAccesos uc = new ucControlAccesos();

            // Ajusta el ancho del UserControl para que sea exactamente el mismo que el del panel
            uc.Width = panelContenedor.ClientSize.Width;

            // Opcional: anclar el control a la esquina superior izquierda para que se mantenga en su posici�n
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Agrega el UserControl al panel
            panelContenedor.Controls.Add(uc);

        }

        private void ControlPresenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            ucControlPresencia uc = new ucControlPresencia();
            uc.Width = panelContenedor.ClientSize.Width;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelContenedor.Controls.Add(uc);
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            ucSalas uc = new ucSalas();
            uc.Width = panelContenedor.ClientSize.Width;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelContenedor.Controls.Add(uc);

        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            ucNiveles uc = new ucNiveles();
            uc.Width = panelContenedor.ClientSize.Width;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelContenedor.Controls.Add(uc);

        }

        private void dispositivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            ucDispositivos uc = new ucDispositivos();
            uc.Width = panelContenedor.ClientSize.Width;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelContenedor.Controls.Add(uc);

        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void validacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            ucValidaciones uc = new ucValidaciones();
            uc.Width = panelContenedor.ClientSize.Width;
            uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelContenedor.Controls.Add(uc);

        }
    }
}