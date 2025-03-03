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

        private async void registrarDispositivoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoDispositivoStr = codigoCrearDispositivoTextBox.Text.Trim();
                string descripcion = descripcionCrearDispositivoTextBox.Text.Trim();

                if (string.IsNullOrEmpty(codigoDispositivoStr))
                {
                    MessageBox.Show("El campo de consulta de 'codigoDispositivo' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(codigoDispositivoStr, out int codigoDispositivo))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'codigoDispositivo' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("El campo de consulta de 'descripcion' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                Dispositivo nuevoDispositivo = new Dispositivo(1, codigoDispositivo, descripcion);

                DispositivosApi dispositivosApi = new DispositivosApi();
                Dispositivo dispositivoRegistrado = await dispositivosApi.NuevoDispositivoAsync(nuevoDispositivo, WSKey);

                MessageBox.Show("Dispositivo registrado exitosamente. ID: " + dispositivoRegistrado.Id,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el dispositivo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void modificarDispositivoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string idStr = idModificarDispositivoTextBox.Text.Trim();
                string codigoDispositivoStr = codigoModificarDispositivoTextBox.Text.Trim();
                string descripcion = descripcionModificarDispositivoTextBox.Text.Trim();

                if (string.IsNullOrEmpty(idStr))
                {
                    MessageBox.Show("El campo de consulta de 'id' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(idStr, out int id))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'id' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(codigoDispositivoStr))
                {
                    MessageBox.Show("El campo de consulta de 'codigoDispositivo' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(codigoDispositivoStr, out int codigoDispositivo))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'codigoDispositivo' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("El campo de consulta de 'descripcion' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                Dispositivo modificadoDispositivo = new Dispositivo(id, codigoDispositivo, descripcion);

                DispositivosApi dispositivosApi = new DispositivosApi();
                InlineResponse200 respuesta  = await dispositivosApi.ModificarDispositivoAsync(modificadoDispositivo, WSKey);

                MessageBox.Show("Dispositivo modificado exitosamente. ID: " + modificadoDispositivo.Id,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dispositivo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
