using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;
using WinFormsApp1.utils;


namespace WinFormsApp1
{
    public partial class ucDispositivos : UserControl
    {
        public ucDispositivos()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarDispositivoDataGridView, this.BackColor);
        }

        private async void consultarDispositivoButton_Click(object sender, EventArgs e)
        {
            string codigoConsultaText = codigoConsultarDispositivoTextBox.Text.Trim();
            if (string.IsNullOrEmpty(codigoConsultaText))
            {
                MessageBox.Show("El campo de consulta de 'codigo' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoConsultaText, out int codigo))
            {
                MessageBox.Show("El valor ingresado en el campo de consulta de 'codigo' debe ser un número entero positivo.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerRestKey();

            try
            {
                DispositivosApi dispositivosApi = new DispositivosApi();

                Dispositivo dispositivoConsultado = await dispositivosApi.ConsultarDispositivoAsync(codigo, WSKey);

                if (dispositivoConsultado == null)
                {
                    MessageBox.Show("No se encontró ningún dispositivo con el valor proporcionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    consultarDispositivoDataGridView.DataSource = null;
                }
                else
                {
                    List<Dispositivo> listaDispositivo = new List<Dispositivo> { dispositivoConsultado };
                    consultarDispositivoDataGridView.DataSource = listaDispositivo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el dispositivo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
