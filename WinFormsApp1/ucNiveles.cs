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
using WinFormsApp1.utils;


namespace WinFormsApp1
{
    public partial class ucNiveles : UserControl
    {
        public ucNiveles()
        {
            InitializeComponent();
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

        private void consultarNivelbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
