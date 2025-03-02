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
    public partial class ucEmpleados : UserControl
    {
        public ucEmpleados()
        {
            InitializeComponent();
            Utils.ConfigurarDataGridView(consultarEmpleadoDataGridView, this.BackColor);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private async void consultarEmpleadoButton_Click(object sender, EventArgs e)
        {
            // Paso 1: Leer los valores de los TextBox de consulta
            string nif = consultarEmpleadoTextBox.Text.Trim();

            // Validar y convertir los campos numéricos
            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("El campo de consulta del NIF/NIE no puede estar vacío.",
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

        private async void registrarEmpleadoButton_Click(object sender, EventArgs e)
        {
            string nifnie = nifNieRegistrarEmpleadoTextBox.Text.Trim();
            string nombreApellidos = nombreApellidosRegistrarEmpleadoTextBox.Text.Trim();
            string email = emailRegistrarEmpleadoTextBox.Text.Trim();
            string naf = nafRegistrarEmpleadoTextBox.Text.Trim();
            string iban = ibanRegistrarEmpleadoTextBox.Text.Trim();
            string idNivelStr = idNivelRegistrarEmpleadoTextBox.Text.Trim();
            string usuario = usuarioRegistrarEmpleadoTextBox.Text.Trim();
            string password = passwordRegisrarEmpleadoTextBox.Text.Trim();
            string validoStr = validoRegistrarEmpleadoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nifnie))
            {
                MessageBox.Show("El campo de consulta del NIF/NIE no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombreApellidos))
            {
                MessageBox.Show("El campo de consulta de 'nombreApellidos' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo de consulta del 'email' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(naf))
            {
                MessageBox.Show("El campo de consulta del 'naf' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(iban))
            {
                MessageBox.Show("El campo de consulta del 'iban' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(idNivelStr))
            {
                MessageBox.Show("El campo de consulta del 'idNivel' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El campo de consulta del 'usuario' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo de consulta del 'password' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(validoStr))
            {
                MessageBox.Show("El campo de consulta del 'valido' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(idNivelStr, out int idNivel))
            {
                MessageBox.Show("El id del nivel no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(validoStr, out int valido))
            {
                MessageBox.Show("El atributo 'valido' no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            EmpleadosType registro = new EmpleadosType
            {
                nifnie = nifnie,
                nombreApellidos = nombreApellidos,
                email = email,
                naf = naf,
                iban = iban,
                idNivel = idNivel,
                usuario = usuario,
                password = password,
                valido = valido,
                id = 0
            };

            try
            {
                using (var client = new EmpleadosClient())
                {
                    var response = await client.nuevoAsync(registro, WSKey);

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

        private async void modificarEmpleadoButton_Click(object sender, EventArgs e)
        {
            String idStr = idModificarEmpleadoTextBox.Text.Trim();
            string nifnie = nifNieModificarEmpleadoTextBox.Text.Trim();
            string nombreApellidos = nombreApellidosModificarEmpleadoTextBox.Text.Trim();
            string email = emailModificarEmpleadoTextBox.Text.Trim();
            string naf = nafModificarEmpleadoTextBox.Text.Trim();
            string iban = ibanModificarEmpleadoTextBox.Text.Trim();
            string idNivelStr = idNivelModificarEmpleadoTextBox.Text.Trim();
            string usuario = usuarioModificarEmpleadoTextBox.Text.Trim();
            string password = passwordModificarEmpleadoTextBox.Text.Trim();
            string validoStr = validoModificarEmpleadoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(idStr))
            {
                MessageBox.Show("El campo de consulta del 'id' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(idStr, out int id))
            {
                MessageBox.Show("El id del empleado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nifnie))
            {
                MessageBox.Show("El campo de consulta del NIF/NIE no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombreApellidos))
            {
                MessageBox.Show("El campo de consulta de 'nombreApellidos' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo de consulta del 'email' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(naf))
            {
                MessageBox.Show("El campo de consulta del 'naf' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(iban))
            {
                MessageBox.Show("El campo de consulta del 'iban' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(idNivelStr))
            {
                MessageBox.Show("El campo de consulta del 'idNivel' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(idNivelStr, out int idNivel))
            {
                MessageBox.Show("El id del nivel no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El campo de consulta del 'usuario' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo de consulta del 'password' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(validoStr))
            {
                MessageBox.Show("El campo de consulta del 'valido' no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(validoStr, out int valido))
            {
                MessageBox.Show("El atributo 'valido' no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            EmpleadosType registro = new EmpleadosType
            {
                nifnie = nifnie,
                nombreApellidos = nombreApellidos,
                email = email,
                naf = naf,
                iban = iban,
                idNivel = idNivel,
                usuario = usuario,
                password = password,
                valido = valido,
                id = id
            };

            try
            {
                using (var client = new EmpleadosClient())
                {
                    var response = await client.modificarAsync(registro, WSKey);

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
            string nif = eliminarEmpleadoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nif))
            {
                MessageBox.Show("El campo de consulta del NIF/NIE no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string WSKey = Utils.obtenerSoapKey();

            try
            {
                using (var client = new EmpleadosClient())
                {
                    var response = await client.borrarAsync(nif, WSKey);

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
