using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ucControlAccesos : UserControl
    {
        public ucControlAccesos()
        {
            InitializeComponent();
        }

        private async void registrarRegistroAccesoButton_Click(object sender, EventArgs e)
        {
            // Paso 1: Obtener los textos de los TextBox en el orden indicado
            string nifnie = NIFTextBox.Text.Trim();
            string codigoSalaStr = codigoSalaTextBox.Text.Trim();
            string codigoDispositivoStr = codigoDispositivoTextBox.Text.Trim();

            // Paso 1.1: Leer la WSKey desde el archivo de texto en la carpeta "resources"
            string wsKeyFilePath = System.IO.Path.Combine(Application.StartupPath, "resources", "wskey.txt");

            if (!System.IO.File.Exists(wsKeyFilePath))
            {
                MessageBox.Show("El archivo wskey.txt no se encontró en la carpeta resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = System.IO.File.ReadAllText(wsKeyFilePath).Trim();

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
    }
}
