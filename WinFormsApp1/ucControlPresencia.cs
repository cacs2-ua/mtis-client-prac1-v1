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

namespace WinFormsApp1
{
    public partial class ucControlPresencia : UserControl
    {
        public ucControlPresencia()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(controlPresenciaDataGridView, this.BackColor);
        }

        private async void consultarButton_Click(object sender, EventArgs e)
        {
            string codigoSalaStr = codigoSalaConsultarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(codigoSalaStr))
            {
                MessageBox.Show("El campo de consulta del 'codigoSala' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El codigoSala debe de ser un numero entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            var request = new controlEmpleadoSalaRequest
            {
                codigoSala = codigoSala,
                WSKey = WSKey
            };

            try
            {
                using (var client = new ControlPresenciaClient())
                {
                    var response = await client.controlEmpleadoSalaAsync(request);

                    if (Utils.ExisteErrorOAdvertencia(response.mensajeSalida))
                    {
                        return;
                    }

                    if (response.empleadosOut != null)
                    {
                        controlPresenciaDataGridView.DataSource = response.empleadosOut.ToList();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void registrarButton_Click(object sender, EventArgs e)
        {
            string nifnie = NIFRegistrarTextBox.Text.Trim();
            string codigoSalaStr = codigoSalaRegistrarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nifnie))
            {
                MessageBox.Show("El campo de consulta del 'nifnie' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(codigoSalaStr))
            {
                MessageBox.Show("El campo de consulta del 'codigoSala' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El 'codigoSala' debe de ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            var registro = new ControlPresenciaOperationType
            {
                nifnie = nifnie,
                codigoSala = codigoSala
            };

            try
            {
                using (var client = new ControlPresenciaClient())
                {
                    var response = await client.registrarAsync(registro, WSKey);

                    if (Utils.ExisteErrorOAdvertencia(response.mensajeSalida))
                    {
                        return;
                    }

                    MessageBox.Show("Respuesta SOAP:\n" + response.mensajeSalida, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la llamada SOAP:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            string nifnie = NIFEliminarTextBox.Text.Trim();
            string codigoSalaStr = codigoSalaEliminarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nifnie))
            {
                MessageBox.Show("El campo de consulta del 'NIF/NIE' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(codigoSalaStr))
            {
                MessageBox.Show("El campo de consulta del 'codigoSala' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El 'codigoSala' debe de ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            var registro = new ControlPresenciaOperationType
            {
                nifnie = nifnie,
                codigoSala = codigoSala
            };

            try
            {
                using (var client = new ControlPresenciaClient())
                {
                    var response = await client.eliminarAsync(registro, WSKey);

                    if (Utils.ExisteErrorOAdvertencia(response.mensajeSalida))
                    {
                        return;
                    }

                    MessageBox.Show(response.mensajeSalida, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
