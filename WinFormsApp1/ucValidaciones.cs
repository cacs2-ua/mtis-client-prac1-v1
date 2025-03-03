using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.utils;
using ControlPresenciaSoapServiceReference;
using ValidacionesSoapServiceReference;

namespace WinFormsApp1
{
    public partial class ucValidaciones : UserControl
    {
        public ucValidaciones()
        {
            InitializeComponent();
        }

        private async void nifValidarButton_Click(object sender, EventArgs e)
        {
            string nif = nifValidarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("El campo del 'nif' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            try
            {
                using (var client = new ValidacionesClient())
                {
                    var response = await client.validarNIFAsync(nif, WSKey);

                    if (Utils.ExisteErrorOAdvertencia(response.Body.mensajeSalida))
                    {
                        return;
                    }

                    MessageBox.Show("Respuesta SOAP:\n" + response.Body.mensajeSalida, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void nieValidarButton_Click(object sender, EventArgs e)
        {
            string nie = nieValidarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nie))
            {
                MessageBox.Show("El campo del 'nie' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            try
            {
                using (var client = new ValidacionesClient())
                {
                    var response = await client.validarNIEAsync(nie, WSKey);

                    if (Utils.ExisteErrorOAdvertencia(response.Body.mensajeSalida))
                    {
                        return;
                    }

                    MessageBox.Show("Respuesta SOAP:\n" + response.Body.mensajeSalida, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
