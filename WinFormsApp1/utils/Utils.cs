using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1.utils
{
    public static class Utils
    {
        public static String obtenerSoapKey()
        {
            string projectPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName;
            string wsKeyFilePath = Path.Combine(projectPath, "resources", "soapkey.txt");

            if (!System.IO.File.Exists(wsKeyFilePath))
            {
                MessageBox.Show("El archivo soapkey.txt no se encontró en la carpeta resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "WSKey not Found";
            }

            string WSKey = System.IO.File.ReadAllText(wsKeyFilePath).Trim();

            return WSKey;
        }

        public static String obtenerRestKey()
        {
            string projectPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName;
            string wsKeyFilePath = Path.Combine(projectPath, "resources", "restkey.txt");

            if (!System.IO.File.Exists(wsKeyFilePath))
            {
                MessageBox.Show("El archivo restkey.txt no se encontró en la carpeta resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "WSKey not Found";
            }

            string WSKey = System.IO.File.ReadAllText(wsKeyFilePath).Trim();

            return WSKey;
        }

        public static bool ExisteError(string mensajeSalida)
        {
            if (!string.IsNullOrEmpty(mensajeSalida) && mensajeSalida.StartsWith("ERROR"))
            {
                MessageBox.Show(mensajeSalida, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public static bool ExisteAdvertencia(string mensajeSalida)
        {
            if (!string.IsNullOrEmpty(mensajeSalida) && mensajeSalida.StartsWith("ADVERTENCIA"))
            {
                MessageBox.Show(mensajeSalida, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public static bool ExisteErrorOAdvertencia(string mensajeSalida)
        {
            return ExisteError(mensajeSalida) || ExisteAdvertencia(mensajeSalida);
        }



    }
}
