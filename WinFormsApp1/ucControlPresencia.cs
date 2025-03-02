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
using EmpleadosSoapServiceReference;

namespace WinFormsApp1
{
    public partial class ucControlPresencia : UserControl
    {
        public ucControlPresencia()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(controlPresenciaDataGridView, this.BackColor);
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            string codigoSalaStr = codigoSalaConsultarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(codigoSalaStr))
            {
                MessageBox.Show("El campo de consulta del 'codigoSala' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            var request = new consultarRequest
            {
                nifnie = nif,
                WSKey = WSKey
            };

            try
            {
                using (var client = new EmpleadosClient())
                {
                    var response = await client.consultarAsync(request);

                    if (Utils.ExisteErrorOAdvertencia(response.mensajeSalida))
                    {
                        return;
                    }

                    if (response.empleadoOut != null)
                    {
                        consultarEmpleadoDataGridView.DataSource = new List<EmpleadosType> { response.empleadoOut };
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
