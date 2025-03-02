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

using WinFormsApp1.utils;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class ucControlAccesos : UserControl
    {
        public ucControlAccesos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        /// <summary>
        /// Configura las propiedades del DataGridView para mostrar los registros de acceso.
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Se generan automáticamente las columnas a partir de las propiedades de InstanciaRegistroAccesosType
            registrosAccesosDataGridView.AutoGenerateColumns = true;
            registrosAccesosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registrosAccesosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            registrosAccesosDataGridView.MultiSelect = false;
            registrosAccesosDataGridView.ReadOnly = true;
            registrosAccesosDataGridView.AllowUserToAddRows = false;
            registrosAccesosDataGridView.AllowUserToDeleteRows = false;
            registrosAccesosDataGridView.RowHeadersVisible = false;
        }

        private async void registrarRegistroAccesoButton_Click(object sender, EventArgs e)
        {
            /*
            // Paso 1: Obtener los textos de los TextBox en el orden indicado
            string nifnie = NIFTextBox.Text.Trim();
            string codigoSalaStr = codigoSalaTextBox.Text.Trim();
            string codigoDispositivoStr = codigoDispositivoTextBox.Text.Trim();

            string WSKey = Utils.obtenerSoapKey();

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
            */
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón "Consultar". Realiza la llamada SOAP para consultar registros de acceso.
        /// </summary>
        private async void consultarButton_Click(object sender, EventArgs e)
        {
            // Paso 1: Leer los valores de los TextBox de consulta
            string nif = nifConsultarTextBox.Text.Trim();
            string codigoSalaStr = codigoSalaConsultarTextBox.Text.Trim();
            string codigoDispositivoStr = codigoDispositivoConsultarTextBox.Text.Trim();
            string fechaDesdeStr = fechaDesdeConsultarTextBox.Text.Trim();
            string fechaHastaStr = fechaHastaConsultarTextBox.Text.Trim();

            // Validar y convertir los campos numéricos
            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El código de sala de consulta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(codigoDispositivoStr, out int codigoDispositivo))
            {
                MessageBox.Show("El código de dispositivo de consulta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir las fechas de consulta; se utiliza el formato ISO: "yyyy-MM-ddTHH:mm:ss"
            DateTime fechaDesde, fechaHasta;
            try
            {
                fechaDesde = DateTime.ParseExact(fechaDesdeStr, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de 'fechaDesde' no es válido. Utilice: yyyy-MM-ddTHH:mm:ss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                fechaHasta = DateTime.ParseExact(fechaHastaStr, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de 'fechaHasta' no es válido. Utilice: yyyy-MM-ddTHH:mm:ss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la WSKey desde el archivo (se asume que Utils.obtenerSoapKey() está implementado)
            string WSKey = Utils.obtenerSoapKey();

            // Paso 2: Crear el objeto de consulta
            var fechasConsulta = new FechasRegistroAccesosType
            {
                nifnie = nif,
                codigoSala = codigoSala,
                codigoDispositivo = codigoDispositivo,
                fechaDesde = fechaDesde,
                fechaHasta = fechaHasta
            };

            // Construir el request para el método consultar
            var request = new consultarRequest(fechasConsulta, WSKey);

            // Paso 3: Llamar al servicio SOAP y obtener la respuesta
            try
            {
                using (var client = new ControlAccesosClient())
                {
                    var response = await client.consultarAsync(request);

                    if (Utils.ExisteError(response.mensajeSalida))
                    {
                        return;
                    }

                    if (Utils.ExisteAdvertencia(response.mensajeSalida))
                    {
                        return;
                    }

                    if (response.@out != null && response.@out.Length > 0)
                    {
                        // Enlazar el array de registros al DataGridView para mostrar los resultados
                        registrosAccesosDataGridView.DataSource = response.@out;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros de acceso con los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        registrosAccesosDataGridView.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar registros de acceso:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void codigoSalaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucControlAccesos_Load(object sender, EventArgs e)
        {

        }
    }
}
