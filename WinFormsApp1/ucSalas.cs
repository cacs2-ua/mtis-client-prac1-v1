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
    public partial class ucSalas : UserControl
    {
        public ucSalas()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarSalasDataGridView, this.BackColor);
        }

        private async void consultarSalaButton_Click(object sender, EventArgs e)
        {
            string codigoSalaStr = codigoSalaConsultarSalaTextBox.Text.Trim();
            if (string.IsNullOrEmpty(codigoSalaStr))
            {
                MessageBox.Show("El campo del 'codigoSala' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el contenido sea un número entero.
            if (!int.TryParse(codigoSalaStr, out int codigoSala))
            {
                MessageBox.Show("El valor ingresado en el campo de 'codigoSala' debe ser un número entero.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la WSKey usando el método definido en Utils.
            string WSKey = Utils.obtenerRestKey();

            try
            {
                SalasApi salasApi = new SalasApi();

                IO.Swagger.Model.Sala salaConsultada = await salasApi.ConsultarSalaAsync(codigoSala, WSKey);

                if (salaConsultada == null)
                {
                    MessageBox.Show("No se encontró ninguna sala con el codigo proporcionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    consultarSalasDataGridView.DataSource = null;
                }
                else
                {
                    List<IO.Swagger.Model.Sala> listaSala = new List<IO.Swagger.Model.Sala> { salaConsultada };
                    consultarSalasDataGridView.DataSource = listaSala;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void crearSalaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoSalaStr = codigoSalaCrearSalaTextBox.Text.Trim();
                string nombre = nombreRegistrarSalaTextBox.Text.Trim();
                string nivelStr = nivelRegistrarSalaTextBox.Text.Trim();

                if (string.IsNullOrEmpty(codigoSalaStr))
                {
                    MessageBox.Show("El campo de consulta de 'codigoSala' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(codigoSalaStr, out int codigoSala))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'codigoSala' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El campo de consulta de 'nombre' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nivelStr))
                {
                    MessageBox.Show("El campo de consulta de 'nivel' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(nivelStr, out int nivel))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'nivel' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                IO.Swagger.Model.Sala nuevaSala = new IO.Swagger.Model.Sala(1, codigoSala, nombre, nivel);

                IO.Swagger.Api.SalasApi salasApi = new IO.Swagger.Api.SalasApi();

                IO.Swagger.Model.Sala salaRegistrada = await salasApi.NuevoSalaAsync(nuevaSala, WSKey);

                MessageBox.Show("Sala registrada exitosamente. ID: " + salaRegistrada.Id,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void modificarSalaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string idStr = idModificarSalaTextBox.Text.Trim();
                string codigoSalaStr = codigoSalaModificarTextBox.Text.Trim();
                string nombre = nombreModificarSalaTextBox.Text.Trim();
                string nivelStr = nivelModificarSalaTextBox.Text.Trim();

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

                if (string.IsNullOrEmpty(codigoSalaStr))
                {
                    MessageBox.Show("El campo de consulta de 'codigoSala' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(codigoSalaStr, out int codigoSala))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'codigoSala' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El campo de consulta de 'nombre' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nivelStr))
                {
                    MessageBox.Show("El campo de consulta de 'nivel' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(nivelStr, out int nivel))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'nivel' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                Sala salaModificada = new Sala(id, codigoSala, nombre, nivel);

                SalasApi salasApi = new SalasApi();

                InlineResponse200 respuesta = await salasApi.ModificarSalaAsync(salaModificada, WSKey);


                MessageBox.Show("Sala modifcada exitosamente. ",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
