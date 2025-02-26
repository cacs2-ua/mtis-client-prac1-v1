using System.Net;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 1: Obtener los textos de los TextBox en el orden indicado
            string nifnie = textBox1.Text.Trim();
            string codigoSala = textBox2.Text.Trim();
            string codigoDispositivo = textBox13.Text.Trim();

            // WSKey se asume que es fijo según la especificación
            string WSKey = "soap-mtis-prac1";

            // Construir el SOAP envelope como string con los valores leídos
            string soapEnvelope = $@"<?xml version=""1.0"" encoding=""UTF-8""?>
<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:con=""http://www.example.org/ControlAccesos/"">
   <soapenv:Header/>
   <soapenv:Body>
      <con:registrar>
         <in>
            <nifnie>{nifnie}</nifnie>
            <codigoSala>{codigoSala}</codigoSala>
            <codigoDispositivo>{codigoDispositivo}</codigoDispositivo>
            <WSKey>{WSKey}</WSKey>
         </in>
      </con:registrar>
   </soapenv:Body>
</soapenv:Envelope>";

            // Endpoint SOAP
            string url = "http://localhost:8080/Prac1-prueba-v2/services/ControlAccesos";

            try
            {
                // Crear la solicitud HTTP (POST) para el servicio SOAP
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/xml;charset=UTF-8";
                request.Accept = "text/xml";

                // Convertir el envelope a bytes y escribirlo en el stream de la solicitud
                byte[] byteArray = Encoding.UTF8.GetBytes(soapEnvelope);
                request.ContentLength = byteArray.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(byteArray, 0, byteArray.Length);
                }

                // Obtener la respuesta del servicio SOAP
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = reader.ReadToEnd();

                    // Mostrar el resultado en un MessageBox o en otro control
                    MessageBox.Show("Respuesta SOAP:\n" + soapResult, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (WebException webEx)
            {
                // Si hay error en la llamada SOAP, se muestra el error
                using (StreamReader reader = new StreamReader(webEx.Response.GetResponseStream()))
                {
                    string errorResponse = reader.ReadToEnd();
                    MessageBox.Show("Error en la llamada SOAP:\n" + errorResponse, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}