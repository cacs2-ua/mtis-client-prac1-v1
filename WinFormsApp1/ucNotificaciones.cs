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
    public partial class ucNotificaciones : UserControl
    {
        public ucNotificaciones()
        {
            InitializeComponent();
        }

        private async void notificarPresenciaSalaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string WSKey = Utils.obtenerRestKey();

                NotificacionesApi notificacionesApi = new NotificacionesApi();
                InlineResponse2001 respuesta = await notificacionesApi.NotificarPresenciaSalaAsync(WSKey);

                MessageBox.Show(respuesta.Message,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al notificar presencia en sala: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void notificarUsuarioValidoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nif = nifNotificarUsuarioValidoTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nif))
                {
                    MessageBox.Show("El campo de consulta de 'nif' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                NotificacionesUsuarioValidoBody notificacion = new NotificacionesUsuarioValidoBody(nif);

                NotificacionesApi notificacionesApi = new NotificacionesApi();
                InlineResponse2001 respuesta = await notificacionesApi.NotificarUsuarioValidoAsync(notificacion, WSKey);

                MessageBox.Show(respuesta.Message,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: El empleado introducido no es válido: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void notificarErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nif = nifNotificarErrorTextBox.Text.Trim();
                string errorStr = errorNotificarErrorTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nif))
                {
                    MessageBox.Show("El campo de consulta de 'nif' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(errorStr))
                {
                    MessageBox.Show("El campo de consulta de 'error' no puede estar vacío.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WSKey = Utils.obtenerRestKey();

                NotificacionesErrorBody notificacion = new NotificacionesErrorBody(nif, errorStr);

                NotificacionesApi notificacionesApi = new NotificacionesApi();
                InlineResponse2001 respuesta = await notificacionesApi.NotificarErrorAsync(notificacion, WSKey);

                MessageBox.Show(respuesta.Message,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al notificar el error al empleado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
