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
    public partial class ucNiveles : UserControl
    {
        public ucNiveles()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarNivelDataGridView, this.BackColor);
        }

        private async void registrarNivelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Paso 1: Recoger los textos de los TextBox (en el orden indicado)
                string descripcion = descripcionNivelTextBox.Text.Trim();
                string nivelText = nivelTextBox.Text.Trim();

                string WSKey = Utils.obtenerRestKey();

                // El campo nivel es obligatorio, se debe poder convertir a entero.
                if (!int.TryParse(nivelText, out int nivelValue))
                {
                    MessageBox.Show("El valor ingresado en nivelTextBox no es un número válido.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Paso 3: Crear el objeto Nivel usando los valores recogidos.
                // Nota: La clase Nivel requiere que "nivel" y "descripcion" no sean nulos.
                IO.Swagger.Model.Nivel nuevoNivel = new IO.Swagger.Model.Nivel(1, nivelValue, descripcion);

                // Paso 4: Crear una instancia de NivelesApi y configurar el BasePath si es necesario.
                // Se asume que la configuración ya apunta al endpoint correcto del servidor Express.
                IO.Swagger.Api.NivelesApi nivelesApi = new IO.Swagger.Api.NivelesApi();

                // Paso 5: Llamar al método asíncrono para crear el nuevo nivel en la BD.
                IO.Swagger.Model.Nivel nivelRegistrado = await nivelesApi.NuevoNivelAsync(nuevoNivel, WSKey);

                // Paso 6: Mostrar un mensaje de éxito con el ID del nivel registrado.
                MessageBox.Show("Nivel registrado exitosamente. ID: " + nivelRegistrado.Id,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores: se muestra un mensaje de error en caso de excepción.
                MessageBox.Show("Error al registrar nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucNiveles_Load(object sender, EventArgs e)
        {
            // Código opcional a ejecutar al cargar el UserControl
        }

        private void nivelTextBox_TextChanged(object sender, EventArgs e)
        {
            // Código opcional a ejecutar cuando cambie el contenido del nivelTextBox
        }

        private async void consultarNivelButton_Click(object sender, EventArgs e)
        {
            // Validar que el campo de consulta no esté vacío.
            string nivelConsultaText = consultarNivelTextBox.Text.Trim();
            if (string.IsNullOrEmpty(nivelConsultaText))
            {
                MessageBox.Show("El campo de consulta de nivel no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el contenido sea un número entero.
            if (!int.TryParse(nivelConsultaText, out int nivelConsulta))
            {
                MessageBox.Show("El valor ingresado en el campo de consulta de nivel debe ser un número entero.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la WSKey usando el método definido en Utils.
            string WSKey = Utils.obtenerRestKey();

            try
            {
                // Crear una instancia de NivelesApi.
                NivelesApi nivelesApi = new NivelesApi();

                // Llamar al método asíncrono para consultar el nivel.
                IO.Swagger.Model.Nivel nivelConsultado = await nivelesApi.ConsultarNivelAsync(nivelConsulta, WSKey);

                if (nivelConsultado == null)
                {
                    MessageBox.Show("No se encontró ningún nivel con el valor proporcionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    consultarNivelDataGridView.DataSource = null;
                }
                else
                {
                    // Mostrar el nivel consultado en el DataGridView.
                    List<IO.Swagger.Model.Nivel> listaNivel = new List<IO.Swagger.Model.Nivel> { nivelConsultado };
                    consultarNivelDataGridView.DataSource = listaNivel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultarNivelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void modificarNivelButton_Click(object sender, EventArgs e)
        {

            try
            {
                string idStr = idModificarNivelTextBox.Text.Trim();
                string nivelStr = nivelModificarNivelTextBox.Text.Trim();
                string descripcion = descripcionModificarNivelTextBox.Text.Trim();

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

                if (string.IsNullOrEmpty(nivelStr))
                {
                    MessageBox.Show("El campo de 'nivel' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(nivelStr, out int nivel))
                {
                    MessageBox.Show("El valor ingresado en el campo de 'nivel' debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("El campo de 'descripcion' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                Nivel nivelModificado = new Nivel(id, nivel, descripcion);

                NivelesApi nivelesApi = new NivelesApi();

                InlineResponse200 respuesta = await nivelesApi.ModificarNivelAsync(nivelModificado, WSKey);


                MessageBox.Show("Nivel modifcado exitosamente. ",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void eliminarNivelButton_Click(object sender, EventArgs e)
        {

            try
            {
                string nivelStr = eliminarNivelTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nivelStr))
                {
                    MessageBox.Show("El campo de 'nivel' no puede estar vacío.",
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

                NivelesApi nivelesApi = new NivelesApi();

                InlineResponse2001 respuesta = await nivelesApi.BorrarNivelAsync(nivel, WSKey);


                MessageBox.Show("Nivel borrado exitosamente. ",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el nivel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
